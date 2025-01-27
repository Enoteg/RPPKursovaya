using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace LibApp
{
    public partial class MainForm : Form
    {
        private List<Book> library = new List<Book>();
        private List<Reader> readers = new List<Reader>();
        private List<Hall> halls = new List<Hall>();
        private List<IssuedBook> issuedBooks = new List<IssuedBook>();
        private List<string> authors;

        public MainForm()
        {
            InitializeComponent();
            DeserializeData();
            InitializeDataGridViews();
            PopulateComboBoxes();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.singleCopyBooksButton.Click += new System.EventHandler(this.singleCopyBooksButton_Click);
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerializeData();
        }

        private void SerializeData()
        {
            try
            {
                var settings = new JsonSerializerSettings
                {
                    Formatting = Formatting.Indented,
                    DateFormatString = "dd.MM.yyyy"
                };

                File.WriteAllText("books.json", JsonConvert.SerializeObject(library, settings));
                File.WriteAllText("readers.json", JsonConvert.SerializeObject(readers, settings));
                File.WriteAllText("issuedBooks.json", JsonConvert.SerializeObject(issuedBooks, settings));
                File.WriteAllText("halls.json", JsonConvert.SerializeObject(halls, settings));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoveDuplicateReadersInHalls()
        {
            foreach (var hall in halls)
            {
                var uniqueReaders = new List<Reader>();
                var addedTicketNumbers = new HashSet<string>();

                foreach (var reader in hall.Readers)
                {
                    if (addedTicketNumbers.Add(reader.TicketNumber))
                    {
                        uniqueReaders.Add(reader);
                    }
                }

                hall.Readers = uniqueReaders;
                hall.OccupiedSeats = uniqueReaders.Count;
            }

            SerializeData();
        }

        private void DeserializeData()
        {
            try
            {
                var settings = new JsonSerializerSettings
                {
                    DateFormatString = "dd.MM.yyyy"
                };

                library = File.Exists("books.json") ? JsonConvert.DeserializeObject<List<Book>>(File.ReadAllText("books.json"), settings) ?? new List<Book>() : new List<Book>();
                readers = File.Exists("readers.json") ? JsonConvert.DeserializeObject<List<Reader>>(File.ReadAllText("readers.json"), settings) ?? new List<Reader>() : new List<Reader>();
                halls = File.Exists("halls.json") ? JsonConvert.DeserializeObject<List<Hall>>(File.ReadAllText("halls.json"), settings) ?? new List<Hall>() : new List<Hall>();
                issuedBooks = File.Exists("issuedBooks.json") ? JsonConvert.DeserializeObject<List<IssuedBook>>(File.ReadAllText("issuedBooks.json"), settings) ?? new List<IssuedBook>() : new List<IssuedBook>();

                foreach (var book in library)
                {
                    book.IsSingleCopy = book.Copies == 1;
                }

                foreach (var reader in readers)
                {
                    var hall = halls.FirstOrDefault(h => h.Name == reader.HallName);
                    if (hall != null)
                    {
                        hall.AddReader(reader);
                    }
                }

                authors = library.Select(b => b.Author).Distinct().ToList();

                RemoveDuplicateReadersInHalls();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeDataGridViews()
        {
            InitializeDataGridView(booksDataGridView, new[] { "Title", "Author", "Year", "Code", "IssueDate", "ReceiptDate", "HallName", "Copies" });
            InitializeDataGridView(readersDataGridView, new[] { "FIO", "PhoneNumber", "RegistrationDate", "TicketNumber", "DateOfBirth", "Education", "HallName" });
            InitializeDataGridView(hallsDataGridView, new[] { "Name", "LibraryName", "Specialization", "Capacity", "OccupiedSeats", "AvailableSeats" });
            InitializeDataGridView(issueBooksDataGridView, new[] { "BookTitle", "ReaderFIO", "IssueDate" });
            UpdateDataGridViews();
        }

        private void InitializeDataGridView(DataGridView dataGridView, string[] columns)
        {
            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();

            var headerTranslations = new Dictionary<string, string>
{
    { "Title", "Название" },
    { "Author", "Автор" },
    { "Year", "Год" },
    { "Code", "Шифр" },
    { "IssueDate", "Дата выдачи" },
    { "ReceiptDate", "Дата поступления" },
    { "HallName", "Зал" },
    { "Copies", "Количество экземпляров" },
    { "FIO", "ФИО" },
    { "PhoneNumber", "Телефон" },
    { "RegistrationDate", "Дата регистрации" },
    { "TicketNumber", "Номер билета" },
    { "DateOfBirth", "Дата рождения" },
    { "Education", "Образование" },
    { "Name", "Название зала" },
    { "LibraryName", "Название библиотеки" },
    { "Specialization", "Специализация" },
    { "Capacity", "Вместимость" },
    { "OccupiedSeats", "Занято мест" },
    { "AvailableSeats", "Свободно мест" },
    { "BookTitle", "Название книги" },
    { "ReaderFIO", "ФИО читателя" }
};

            foreach (var column in columns)
            {
                dataGridView.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = column,
                    HeaderText = headerTranslations.ContainsKey(column) ? headerTranslations[column] : column,
                    ReadOnly = true
                });
            }

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridView.ScrollBars = ScrollBars.Both;
            dataGridView.AllowUserToAddRows = false;
        }

        private void UpdateDataGridViews()
        {
            UpdateDataGridView(booksDataGridView, library, new[] { "Title", "Author", "Year", "Code", "IssueDate", "ReceiptDate", "HallName", "Copies" });
            UpdateDataGridView(readersDataGridView, readers, new[] { "FIO", "PhoneNumber", "RegistrationDate", "TicketNumber", "DateOfBirth", "Education", "HallName" });
            UpdateHallsDataGridView();
            UpdateDataGridView(issueBooksDataGridView, issuedBooks, new[] { "BookTitle", "ReaderFIO", "IssueDate" });
        }

        private void UpdateHallsDataGridView()
        {
            hallsDataGridView.SuspendLayout();
            hallsDataGridView.Rows.Clear();

            foreach (var hall in halls)
            {
                int availableSeats = hall.Capacity - hall.OccupiedSeats;
                hallsDataGridView.Rows.Add(
                    hall.Name,
                    hall.LibraryName,
                    hall.Specialization,
                    hall.Capacity,
                    hall.OccupiedSeats,
                    availableSeats
                );
            }

            hallsDataGridView.ResumeLayout();
        }

        private void UpdateDataGridView<T>(DataGridView dataGridView, IEnumerable<T> data, string[] columns)
        {
            dataGridView.SuspendLayout();
            dataGridView.Rows.Clear();

            foreach (var item in data)
            {
                var row = new List<object>();

                foreach (var column in columns)
                {
                    var value = item.GetType().GetProperty(column)?.GetValue(item, null)?.ToString() ?? string.Empty;
                    row.Add(value);
                }

                dataGridView.Rows.Add(row.ToArray());
            }

            dataGridView.ResumeLayout();
        }

        private void PopulateComboBoxes()
        {
            PopulateComboBox(hallsComboBoxForReaders, halls.Select(h => h.Name));
            PopulateComboBox(booksComboBox, library.Select(b => b.Title));
            PopulateComboBox(readersComboBox, readers.Select(r => r.FIO));
            PopulateComboBox(booksComboBoxForSearch, library.Select(b => b.Title));
            PopulateComboBox(authorsComboBoxForSearch, library.Select(b => b.Author));
            PopulateComboBox(hallsComboBoxForSearch, halls.Select(h => h.Name));
            PopulateComboBox(readersComboBoxForSearch, readers.Select(r => r.FIO));
        }

        private void PopulateComboBox<T>(ComboBox comboBox, IEnumerable<T> data)
        {
            comboBox.Items.Clear();
            foreach (var item in data)
            {
                comboBox.Items.Add(item);
            }
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            using (AddBookForm addBookForm = new AddBookForm(library, halls))
            {
                if (addBookForm.ShowDialog() == DialogResult.OK)
                {
                    UpdateDataGridViews();
                    PopulateComboBoxes();
                }
            }
        }

        private void DisplaySearchResults<T>(IEnumerable<T> items, string title, Func<T, string> formatter)
        {
            try
            {
                if (items.Any())
                {
                    string result = "Результаты поиска:\n" +
                                    string.Join("\n-----------------------------\n", items.Select(formatter));
                    MessageBox.Show(result, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Результаты поиска не найдены.", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при отображении результатов поиска: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addReaderButton_Click(object sender, EventArgs e)
        {
            using (AddReaderForm addReaderForm = new AddReaderForm(readers, halls))
            {
                if (addReaderForm.ShowDialog() == DialogResult.OK)
                {
                    UpdateDataGridViews();
                    PopulateComboBoxes();
                }
            }
        }

        private void addHallButton_Click(object sender, EventArgs e)
        {
            using (AddHallForm addHallForm = new AddHallForm(halls))
            {
                if (addHallForm.ShowDialog() == DialogResult.OK)
                {
                    PopulateComboBoxes();
                    UpdateDataGridViews();
                }
            }
        }

        private void deleteBookButton_Click(object sender, EventArgs e)
        {
            if (booksDataGridView.SelectedRows.Count > 0)
            {
                string title = booksDataGridView.SelectedRows[0].Cells["Title"].Value.ToString();
                Book bookToDelete = library.FirstOrDefault(b => b.Title == title);

                if (bookToDelete != null)
                {
                    var readersWithBook = readers.Where(r => r.BorrowedBooks.Any(b => b.Title == bookToDelete.Title)).ToList();
                    if (readersWithBook.Any())
                    {
                        MessageBox.Show("Невозможно удалить книгу, так как она выдана читателям.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    library.Remove(bookToDelete);
                    SerializeData();
                    UpdateDataGridViews();
                    PopulateComboBoxes();

                    MessageBox.Show("Книга успешно удалена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Книга не найдена!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите книгу для удаления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SerializeHalls()
        {
            string json = JsonConvert.SerializeObject(halls, Formatting.Indented);
            File.WriteAllText("halls.json", json);
        }

        private void SerializeReaders()
        {
            string json = JsonConvert.SerializeObject(readers, Formatting.Indented);
            File.WriteAllText("readers.json", json);
        }

        private void deleteReaderButton_Click(object sender, EventArgs e)
        {
            if (readersDataGridView.SelectedRows.Count > 0)
            {
                string fio = readersDataGridView.SelectedRows[0].Cells["FIO"].Value.ToString();
                Reader readerToDelete = readers.FirstOrDefault(r => r.FIO == fio);

                if (readerToDelete != null)
                {
                    if (readerToDelete.BorrowedBooks.Any())
                    {
                        MessageBox.Show("Невозможно удалить читателя, так как у него есть книги на руках.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    readers.Remove(readerToDelete);

                    foreach (var hall in halls)
                    {
                        int removed = hall.Readers.RemoveAll(r => r.TicketNumber == readerToDelete.TicketNumber);

                        if (removed > 0)
                        {
                            hall.OccupiedSeats--;
                        }
                    }

                    SerializeReaders();
                    SerializeHalls();

                    UpdateDataGridViews();

                    MessageBox.Show("Читатель успешно удалён!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Читатель не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите читателя для удаления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void viewHallButton_Click(object sender, EventArgs e)
        {
            if (hallsDataGridView.SelectedRows.Count > 0)
            {
                string hallName = hallsDataGridView.SelectedRows[0].Cells["Name"]?.Value?.ToString();
                Hall hall = halls.Find(h => h.Name == hallName);

                if (hall != null)
                {
                    string hallContent = $"Читатели в зале {hall.Name} ({hall.Capacity} мест):\n";
                    foreach (var reader in hall.Readers)
                    {
                        hallContent += $"Читатель: {reader.FIO}. Номер {reader.TicketNumber}\n";
                    }
                    MessageBox.Show(hallContent, "Содержимое зала", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Зал не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите зал из списка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteHallButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (hallsDataGridView.SelectedRows.Count > 0)
                {
                    string hallName = hallsDataGridView.SelectedRows[0].Cells["Name"]?.Value?.ToString();

                    if (!string.IsNullOrEmpty(hallName))
                    {
                        Hall hallToDelete = halls.FirstOrDefault(h => h.Name == hallName);

                        if (hallToDelete != null)
                        {
                            if (hallToDelete.Readers.Any())
                            {
                                MessageBox.Show("Невозможно удалить зал, так как в нем находятся читатели.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                halls.Remove(hallToDelete);
                                SerializeData();
                                UpdateDataGridViews();
                                PopulateComboBoxes();

                                MessageBox.Show("Зал успешно удален!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Logger.Log("Удаление зала", $"Зал {hallToDelete.Name} удалён.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Зал не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Не удалось определить имя зала.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Выберите зал для удаления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchBooksButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (booksComboBoxForSearch.SelectedItem != null)
                {
                    string searchText = booksComboBoxForSearch.SelectedItem.ToString();
                    var filteredBooks = library.Where(b => b.Title.Contains(searchText) || b.Author.Contains(searchText)).ToList();
                    DisplaySearchResults(filteredBooks, "Результаты поиска книг", book =>
                        $"Название: {book.Title}\nАвтор: {book.Author}\nГод: {book.Year}\nШифр: {book.Code}\nДата выдачи: {book.IssueDate:dd.MM.yyyy}\nДата поступления: {book.ReceiptDate:dd.MM.yyyy}\nЗал: {book.HallName}\nКоличество экземпляров: {book.Copies}");
                }
                else
                {
                    MessageBox.Show("Выберите книгу для поиска!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при поиске книг: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchReadersButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (readersComboBox.SelectedItem != null)
                {
                    string searchText = readersComboBox.SelectedItem.ToString();
                    var filteredReaders = readers.Where(r => r.FIO.Contains(searchText) || r.TicketNumber.Contains(searchText)).ToList();
                    DisplaySearchResults(filteredReaders, "Результаты поиска читателей", reader =>
                        $"ФИО: {reader.FIO}\nТелефон: {reader.PhoneNumber}\nДата регистрации: {reader.RegistrationDate:dd.MM.yyyy}\nНомер билета: {reader.TicketNumber}\nДата рождения: {reader.DateOfBirth:dd.MM.yyyy}\nОбразование: {reader.Education}\nЗал: {reader.HallName}");
                }
                else
                {
                    MessageBox.Show("Выберите читателя для поиска!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при поиске читателей: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void booksByAuthorButton_Click(object sender, EventArgs e)
        {
            if (authorsComboBoxForSearch.SelectedItem != null)
            {
                string authorName = authorsComboBoxForSearch.SelectedItem.ToString();
                var booksByAuthor = library.Where(b => b.Author.Contains(authorName)).ToList();
                DisplaySearchResults(booksByAuthor, "Книги автора", book =>
                    $"Название: {book.Title}\nАвтор: {book.Author}\nГод: {book.Year}\nШифр: {book.Code}\nДата выдачи: {book.IssueDate:dd.MM.yyyy}\nДата поступления: {book.ReceiptDate:dd.MM.yyyy}\nЗал: {book.HallName}\nКоличество экземпляров: {book.Copies}");
            }
            else
            {
                MessageBox.Show("Выберите автора для поиска!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void topRatedBooksButton_Click(object sender, EventArgs e)
        {
            try
            {
                var topRatedBooks = library.OrderByDescending(b => b.TimesBorrowed).Take(10).ToList();
                DisplaySearchResults(topRatedBooks, "Топ книги", book =>
                    $"Название: {book.Title}\nАвтор: {book.Author}\nГод: {book.Year}\nШифр: {book.Code}\nДата выдачи: {book.IssueDate:dd.MM.yyyy}\nДата поступления: {book.ReceiptDate:dd.MM.yyyy}\nЗал: {book.HallName}\nКоличество экземпляров: {book.Copies}\nКоличество выдач: {book.TimesBorrowed}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при поиске топ книг: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void booksInHallButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (hallsComboBoxForSearch.SelectedItem != null)
                {
                    string hallName = hallsComboBoxForSearch.SelectedItem.ToString();
                    Hall hall = halls.Find(h => h.Name == hallName);

                    if (hall != null)
                    {
                        var booksInHall = library.Where(b => b.HallName == hallName).ToList();
                        DisplaySearchResults(booksInHall, "Книги в зале", book =>
                            $"Название: {book.Title}\nГод: {book.Year}\nШифр: {book.Code}\nДата выдачи: {book.IssueDate:dd.MM.yyyy}\nДата поступления: {book.ReceiptDate:dd.MM.yyyy}\nЗал: {book.HallName}\nКоличество экземпляров: {book.Copies}");
                    }
                    else
                    {
                        MessageBox.Show("Зал не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Выберите зал из списка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при поиске книг в зале: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void booksByReaderButton_Click(object sender, EventArgs e)
        {
            if (readersComboBoxForSearch.SelectedItem != null)
            {
                string readerFIO = readersComboBoxForSearch.SelectedItem.ToString();
                Reader selectedReader = readers.FirstOrDefault(r => r.FIO == readerFIO);

                if (selectedReader != null)
                {
                    var booksByReader = selectedReader.BorrowedBooks.ToList();
                    DisplaySearchResults(booksByReader, "Книги у читателя", book =>
                        $"Название: {book.Title}\nАвтор: {book.Author}\nГод: {book.Year}\nШифр: {book.Code}\nДата выдачи: {book.IssueDate:dd.MM.yyyy}\nДата поступления: {book.ReceiptDate:dd.MM.yyyy}\nЗал: {book.HallName}\nКоличество экземпляров: {book.Copies}");
                }
                else
                {
                    MessageBox.Show("Читатель не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите читателя для поиска!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void readersWithBookButton_Click(object sender, EventArgs e)
        {
            if (booksComboBoxForSearch.SelectedItem != null)
            {
                string bookTitle = booksComboBoxForSearch.SelectedItem.ToString();
                var readersWithBook = readers.Where(r => r.BorrowedBooks.Any(b => b.Title.Contains(bookTitle))).ToList();
                string readerInfo = "Читатели с книгой \"" + bookTitle + "\":\n";
                foreach (var reader in readersWithBook)
                {
                    readerInfo += $"ФИО: {reader.FIO}, Телефон: {reader.PhoneNumber}, Номер билета: {reader.TicketNumber}\n";
                }
                MessageBox.Show(readerInfo, "Читатели с книгой", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Выберите книгу.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void singleCopyBooksButton_Click(object sender, EventArgs e)
        {
            try
            {
                var singleCopyBooks = library.Where(b => b.IsSingleCopy).ToList();
                if (singleCopyBooks.Any())
                {
                    string result = "Книги в единственном экземпляре и читатели, взявшие их:\n";
                    foreach (var book in singleCopyBooks)
                    {
                        result += $"\n-----------------------------\n" +
                                  $"Название: {book.Title}\n" +
                                  $"Автор: {book.Author}\n";

                        var readersWithBook = readers.Where(r => r.BorrowedBooks.Any(b => b.Title == book.Title)).ToList();
                        if (readersWithBook.Any())
                        {
                            result += "Читатель:\n";
                            foreach (var reader in readersWithBook)
                            {
                                result += $"ФИО: {reader.FIO}, Номер билета: {reader.TicketNumber}\n";
                            }
                        }
                        else
                        {
                            result += "Книга находится в библиотеке.\n";
                        }
                    }
                    MessageBox.Show(result, "Книги в единственном экземпляре", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Книг в единственном экземпляре не найдено.", "Книги в единственном экземпляре", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при поиске книг в единственном экземпляре: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void availableSeatsButton_Click(object sender, EventArgs e)
        {
            string hallContent = "Свободные места в залах:\n";
            foreach (var hall in halls)
            {
                int availableSeats = hall.Capacity - hall.OccupiedSeats;
                hallContent += $"Зал {hall.Name}: {availableSeats} из {hall.Capacity}\n";
            }
            MessageBox.Show(hallContent, "Свободные места в залах", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void issueBookButton_Click(object sender, EventArgs e)
        {
            if (booksComboBox.SelectedItem != null && readersComboBox.SelectedItem != null)
            {
                string bookTitle = booksComboBox.SelectedItem.ToString();
                string readerFIO = readersComboBox.SelectedItem.ToString();
                Book selectedBook = library.FirstOrDefault(b => b.Title == bookTitle);
                Reader selectedReader = readers.FirstOrDefault(r => r.FIO == readerFIO);

                if (selectedBook != null && selectedReader != null)
                {
                    IssueBook(selectedBook, selectedReader);
                }
                else
                {
                    MessageBox.Show("Выберите книгу и читателя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите книгу и читателя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void returnBookButton_Click(object sender, EventArgs e)
        {
            if (issueBooksDataGridView.SelectedRows.Count > 0)
            {
                string bookTitle = issueBooksDataGridView.SelectedRows[0].Cells["BookTitle"].Value.ToString();
                string readerFIO = issueBooksDataGridView.SelectedRows[0].Cells["ReaderFIO"].Value.ToString();
                Book selectedBook = library.FirstOrDefault(b => b.Title == bookTitle);
                Reader selectedReader = readers.FirstOrDefault(r => r.FIO == readerFIO);

                if (selectedBook != null && selectedReader != null)
                {
                    ReturnBook(selectedBook, selectedReader);
                }
                else
                {
                    MessageBox.Show("Выберите книгу и читателя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите книгу и читателя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<IssuedBook> GetOverdueBooks()
        {
            DateTime currentDate = DateTime.Now;
            return issuedBooks
                .Where(ib => ib.DueDate < currentDate && !library.Any(b => b.Title == ib.BookTitle && b.Copies > 0))
                .ToList();
        }

        private void showOverdueBooksButton_Click(object sender, EventArgs e)
        {
            var overdueBooks = GetOverdueBooks();
            if (overdueBooks.Any())
            {
                string result = "Просроченные книги:\n";
                foreach (var overdueBook in overdueBooks)
                {
                    result += $"Книга: {overdueBook.BookTitle}, Читатель: {overdueBook.ReaderFIO}, Дата возврата: {overdueBook.DueDate:dd.MM.yyyy}\n";
                }
                MessageBox.Show(result, "Просроченные книги", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Просроченных книг нет.", "Просроченные книги", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void IssueBook(Book book, Reader reader)
        {
            if (book.Copies > 0)
            {
                Hall hall = halls.FirstOrDefault(h => h.Name == reader.HallName);
                if (hall != null && hall.OccupiedSeats < hall.Capacity)
                {
                    book.Copies--;
                    book.TimesBorrowed++;
                    book.IssueDate = DateTime.Now;
                    reader.BorrowedBooks.Add(book);
                    issuedBooks.Add(new IssuedBook
                    {
                        BookTitle = book.Title,
                        ReaderFIO = reader.FIO,
                        IssueDate = DateTime.Now,
                        DueDate = DateTime.Now.AddDays(7)
                    });
                    hall.AddReader(reader);
                    SerializeData();
                    UpdateDataGridViews();
                    Logger.Log("Выдача книги", $"Книга {book.Title}, {book.Code} выдана читателю {reader.FIO}, {reader.TicketNumber}");
                    MessageBox.Show($"Книга {book.Code} успешно выдана!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("В зале нет свободных мест.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Нет доступных экземпляров этой книги.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReturnBook(Book book, Reader reader)
        {
            reader.BorrowedBooks.RemoveAll(b => b.Title == book.Title && b.Code == book.Code);
            book.Copies++;
            var issuedBook = issuedBooks.FirstOrDefault(ib => ib.BookTitle == book.Title && ib.ReaderFIO == reader.FIO);
            if (issuedBook != null)
            {
                issuedBooks.Remove(issuedBook);
            }

            Hall hall = halls.FirstOrDefault(h => h.Name == reader.HallName);
            if (hall != null)
            {
                hall.RemoveReader(reader);
            }

            SerializeData();
            UpdateDataGridViews();

            Logger.Log("Возвращение книги", $"Книга {book.Title}, {book.Code} возвращена читателем {reader.FIO}, {reader.TicketNumber}");

            MessageBox.Show($"Книга {book.Code} успешно возвращена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            DeserializeData();
            UpdateDataGridViews();
            PopulateComboBoxes();
            MessageBox.Show("Данные успешно обновлены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
