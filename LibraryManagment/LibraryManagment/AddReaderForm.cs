// AddReaderForm.cs
using System;
using System.Windows.Forms;
using System.Xml.Linq;
using LibraryManagment.Models;

namespace LibraryManagement
{
    public partial class AddReaderForm : Form
    {
        public Reader NewReader { get; private set; }

        public AddReaderForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Валидация данных
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Введите имя читателя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!DateTime.TryParse(dtpBirthDate.Text, out var birthDate))
            {
                MessageBox.Show("Введите корректную дату рождения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Создание нового читателя
            NewReader = new Reader
            {
                Name = txtName.Text,
                BirthDate = birthDate,
                PhoneNumber = txtPhoneNumber.Text,
                Education = txtEducation.Text
            };

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
