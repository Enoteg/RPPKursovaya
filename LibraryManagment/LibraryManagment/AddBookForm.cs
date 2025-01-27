// AddBookForm.cs
using System;
using System.Windows.Forms;
using LibraryManagement.Models;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace LibraryManagement
{
    public partial class AddBookForm : Form
    {
        public Book NewBook { get; private set; }

        public AddBookForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Валидация данных
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Введите название книги.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAuthor.Text))
            {
                MessageBox.Show("Введите автора книги.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCode.Text))
            {
                MessageBox.Show("Введите код книги.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtCopies.Value < 1)
            {
                MessageBox.Show("Количество экземпляров должно быть больше нуля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Создание новой книги
            NewBook = new Book
            {
                Title = txtTitle.Text,
                Author = txtAuthor.Text,
                Code = txtCode.Text,
                Copies = (int)txtCopies.Value
            };

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
