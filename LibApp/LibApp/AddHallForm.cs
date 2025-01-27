using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace LibApp
{
    public partial class AddHallForm : Form
    {
        private List<Hall> halls;

        public AddHallForm(List<Hall> halls)
        {
            InitializeComponent();
            this.halls = halls;
        }

        private void saveHallButton_Click(object sender, EventArgs e)
        {
            try
            {
                Hall newHall = new Hall
                {
                    Name = nameTextBox.Text,
                    LibraryName = libraryNameTextBox.Text,
                    Specialization = specializationTextBox.Text,
                    Capacity = int.Parse(capacityTextBox.Text)
                };

                halls.Add(newHall);
                SaveHalls();
                Logger.Log("Добавление зала", $"Зал {newHall.Name} добавлен.");
                MessageBox.Show("Зал успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Неправильный формат данных. Пожалуйста, введите данные в виде целых чисел.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveHalls()
        {
            string json = JsonConvert.SerializeObject(halls, Formatting.Indented);
            File.WriteAllText("halls.json", json);
        }
    }
}
