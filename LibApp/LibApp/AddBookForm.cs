using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace LibApp
{
    public partial class AddBookForm : Form
    {
        private List<Book> library;
        private List<Hall> halls;

        public AddBookForm(List<Book> library, List<Hall> halls)
        {
            InitializeComponent();
            this.library = library;
            this.halls = halls;
            PopulateHallsComboBox();
        }

        private void PopulateHallsComboBox()
        {
            hallsComboBox.Items.Clear();
            foreach (var hall in halls)
            {
                hallsComboBox.Items.Add(hall.Name);
            }
        }

        private void saveBookButton_Click(object sender, EventArgs e)
        {
            try
            {
                Book newBook = new Book
                {
                    Title = titleTextBox.Text,
                    Author = authorTextBox.Text,
                    Year = int.Parse(yearTextBox.Text),
                    Code = GenerateBookCode(),
                    Copies = int.Parse(copiesTextBox.Text),
                    HallName = hallsComboBox.SelectedItem.ToString(),
                    IssueDate = DateTime.MinValue,
                    ReceiptDate = DateTime.Now,
                    IsSingleCopy = int.Parse(copiesTextBox.Text) == 1
                };

                library.Add(newBook);
                SaveLibrary();

                // Логирование действия
                Logger.Log("Добавление книги", $"Книга {newBook.Title} добавлена.");

                MessageBox.Show("Книга успешно добавлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        private string GenerateBookCode()
        {
            return $"BK-{library.Count + 1:D4}";
        }

        private void SaveLibrary()
        {
            string json = JsonConvert.SerializeObject(library, Formatting.Indented);
            File.WriteAllText("library.json", json);
        }
    }
}
