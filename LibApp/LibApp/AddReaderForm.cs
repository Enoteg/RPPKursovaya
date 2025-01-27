using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace LibApp
{
    public partial class AddReaderForm : Form
    {
        private List<Reader> readers;
        private List<Hall> halls;

        public AddReaderForm(List<Reader> readers, List<Hall> halls)
        {
            InitializeComponent();
            this.readers = readers;
            this.halls = halls;
            registrationDateTextBox.Text = DateTime.Now.ToString("dd.MM.yyyy");
            PopulateHallsComboBox();
        }

        private void PopulateHallsComboBox()
        {
            hallsComboBox.Items.Clear();
            hallsComboBox.Items.AddRange(halls.Select(h => h.Name).ToArray());
            if (hallsComboBox.Items.Count > 0)
            {
                hallsComboBox.SelectedIndex = 0;
            }
        }

        private void saveReaderButton_Click(object sender, EventArgs e)
{
    try
    {
        if (string.IsNullOrWhiteSpace(fioTextBox.Text) ||
            string.IsNullOrWhiteSpace(phoneNumberTextBox.Text) ||
            string.IsNullOrWhiteSpace(dateOfBirthTextBox.Text) ||
            hallsComboBox.SelectedItem == null)
        {
            MessageBox.Show("Пожалуйста, заполните все обязательные поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var newReader = new Reader
        {
            FIO = fioTextBox.Text.Trim(),
            PhoneNumber = phoneNumberTextBox.Text.Trim(),
            RegistrationDate = DateTime.Parse(registrationDateTextBox.Text),
            DateOfBirth = DateTime.Parse(dateOfBirthTextBox.Text),
            Education = educationTextBox.Text.Trim(),
            TicketNumber = GenerateTicketNumber(),
            HallName = hallsComboBox.SelectedItem.ToString()
        };

        string selectedHallName = hallsComboBox.SelectedItem.ToString();
        var selectedHall = halls.FirstOrDefault(h => h.Name == selectedHallName);

        if (selectedHall == null)
        {
            MessageBox.Show("Выбранный зал не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (selectedHall.Readers.Any(r => r.TicketNumber == newReader.TicketNumber))
        {
            MessageBox.Show("Читатель с таким номером билета уже находится в этом зале.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (selectedHall.OccupiedSeats >= selectedHall.Capacity)
        {
            MessageBox.Show("В этом зале больше нет свободных мест.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        selectedHall.Readers.Add(newReader);
        selectedHall.OccupiedSeats++;
        readers.Add(newReader);

        SaveReaders();
        SaveHalls();

        // Логирование действия
        Logger.Log("Добавление читателя", $"Читатель {newReader.FIO} добавлен в зал {selectedHallName}.");

        MessageBox.Show("Читатель успешно добавлен в библиотеку!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        this.DialogResult = DialogResult.OK;
        this.Close();
    }
    catch (FormatException)
    {
        MessageBox.Show("Неправильный формат даты. Пожалуйста, введите дату в формате дд.мм.гггг.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}

        private string GenerateTicketNumber()
        {
            return $"Ч-{readers.Count + 1:D4}";
        }

        private void SaveHalls()
        {
            string json = JsonConvert.SerializeObject(halls, Formatting.Indented);
            File.WriteAllText("halls.json", json);
        }


        private void SaveReaders()
        {
            File.WriteAllText("readers.json", JsonConvert.SerializeObject(readers, Formatting.Indented));
        }
    }
}
