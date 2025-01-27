using System;
using System.Windows.Forms;
using LibraryManagment.Models;
using LibraryManagement.Services;
using LibraryManagement;

namespace LibraryManagement
{
    public partial class MainForm : Form
    {
        private readonly ReaderService _readerService;
        private readonly BookService _bookService;
        private readonly RoomService _roomService;
        public MainForm()
        {
            InitializeComponent();
            _readerService = new ReaderService();
            _bookService = new BookService();
            _roomService = new RoomService();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Load initial data and setup
        }

        private void btnAddReader_Click(object sender, EventArgs e)
        {
            var addReaderForm = new AddReaderForm();
            if (addReaderForm.ShowDialog() == DialogResult.OK)
            {
                var newReader = addReaderForm.NewReader;
                _readerService.AddReader(newReader);
                MessageBox.Show("Читатель успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            var addBookForm = new AddBookForm();
            if (addBookForm.ShowDialog() == DialogResult.OK)
            {
                var newBook = addBookForm.NewBook;
                _bookService.AddBook(newBook);
                MessageBox.Show("Книга успешно добавлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnViewRooms_Click(object sender, EventArgs e)
        {
            var viewRoomsForm = new ViewRoomsForm(_roomService); // Убедитесь, что _roomService инициализирован
            viewRoomsForm.ShowDialog();
        }

    }
}
