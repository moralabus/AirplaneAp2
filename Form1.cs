using AirplaneAp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AirplaneAp2
{
    public partial class Form1 : Form
    {
        private List<Airplane> airplanes = new List<Airplane>(); // Список для хранения самолетов

        public Form1()
        {
            InitializeComponent();
            buttonAddAirplane.Click += buttonAddAirplane_Click;
            buttonSortByFuelConsumption.Click += buttonSortByFuelConsumption_Click_1;
            this.BackColor = Airplane.BackColor; // Использование статического свойства для смены фона
        }

        private void buttonAddAirplane_Click(object sender, EventArgs e)
        {
            // Получаем данные с формы
            string airplaneName = textBoxAirplaneName.Text?.Trim();
            string model = comboBoxModel.SelectedItem?.ToString();
            int range = (int)numericUpDownRange.Value;
            string company = comboBoxCompany.SelectedItem?.ToString();
            decimal fuelConsumption = numericUpDownFuelConsumption.Value;
            DateTime manufactureDate = dateTimePickerManufactureDate.Value;

            // Проверяем, что все поля заполнены
            if (string.IsNullOrEmpty(airplaneName) || string.IsNullOrEmpty(model) ||  string.IsNullOrEmpty(company))
            {
                MessageBox.Show("Эй, не забывай заполнять все поля, пожалуйста!");
                return;
            }

            
            if (char.IsLower(airplaneName[0]))
            {
                airplaneName = char.ToUpper(airplaneName[0]) + airplaneName.Substring(1);
            }

            // Создаем объект самолета
            Airplane newAirplane = new Airplane(airplaneName, model, range, company, fuelConsumption, manufactureDate);

            // Добавляем в список
            airplanes.Add(newAirplane);

            // Обновляем ListBox
            UpdateListBox();

            // Очищаем поля после добавления
            textBoxAirplaneName.Clear();
            comboBoxModel.SelectedIndex = -1;
            numericUpDownRange.Value = 0;
            comboBoxCompany.SelectedIndex = -1;
            numericUpDownFuelConsumption.Value = 0;
            dateTimePickerManufactureDate.Value = DateTime.Now;
        }

        private void buttonSortByFuelConsumption_Click_1(object sender, EventArgs e)
        {
            SortAirplanesByFuelConsumption();
        }

        private void SortAirplanesByFuelConsumption()
        {
            airplanes = airplanes.OrderBy(a => a.FuelConsumption).ToList();
            UpdateListBox();
        }

        private void UpdateListBox()
        {
            listBoxAirplanes.Items.Clear();
            foreach (var airplane in airplanes)
            {
                listBoxAirplanes.Items.Add(airplane);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Заполняем модели и авиакомпании
            comboBoxModel.Items.AddRange(new string[] { "Boeing 737", "Airbus A320", "Embraer 190" });
            comboBoxCompany.Items.AddRange(new string[] { "Aeroflot", "S7 Airlines", "Utair" });
        }
    }
}