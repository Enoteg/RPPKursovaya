namespace LibApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageBooks;
        private System.Windows.Forms.TabPage tabPageReaders;
        private System.Windows.Forms.TabPage tabPageHalls;
        private System.Windows.Forms.TabPage tabPageSearchBooks;
        private System.Windows.Forms.TabPage tabPageIssueBooks;
        private System.Windows.Forms.DataGridView readersDataGridView;
        private System.Windows.Forms.DataGridView hallsDataGridView;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.Button addReaderButton;
        private System.Windows.Forms.Button searchBooksButton;
        private System.Windows.Forms.Button searchReadersButton;
        private System.Windows.Forms.Button availableSeatsButton;
        private System.Windows.Forms.Button issueBookButton;
        private System.Windows.Forms.Button returnBookButton;
        private System.Windows.Forms.Button booksByAuthorButton;
        private System.Windows.Forms.Button readersWithBookButton;
        private System.Windows.Forms.Button topRatedBooksButton;
        private System.Windows.Forms.ComboBox booksComboBoxForSearch;
        private System.Windows.Forms.ComboBox authorsComboBoxForSearch;
        private System.Windows.Forms.Button deleteBookButton;
        private System.Windows.Forms.Button deleteReaderButton;
        private System.Windows.Forms.ComboBox hallsComboBoxForReaders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addHallButton;
        private System.Windows.Forms.DataGridView issueBooksDataGridView;
        private System.Windows.Forms.ComboBox booksComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox readersComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button booksInHallButton;
        private System.Windows.Forms.Button booksByReaderButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageBooks = new System.Windows.Forms.TabPage();
            this.booksDataGridView = new System.Windows.Forms.DataGridView();
            this.addBookButton = new System.Windows.Forms.Button();
            this.deleteBookButton = new System.Windows.Forms.Button();
            this.tabPageReaders = new System.Windows.Forms.TabPage();
            this.readersDataGridView = new System.Windows.Forms.DataGridView();
            this.addReaderButton = new System.Windows.Forms.Button();
            this.deleteReaderButton = new System.Windows.Forms.Button();
            this.tabPageHalls = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.deleteHallButton = new System.Windows.Forms.Button();
            this.hallsDataGridView = new System.Windows.Forms.DataGridView();
            this.availableSeatsButton = new System.Windows.Forms.Button();
            this.addHallButton = new System.Windows.Forms.Button();
            this.tabPageSearchBooks = new System.Windows.Forms.TabPage();
            this.readersComboBoxForSearch = new System.Windows.Forms.ComboBox();
            this.hallsComboBoxForSearch = new System.Windows.Forms.ComboBox();
            this.singleCopyBooksButton = new System.Windows.Forms.Button();
            this.searchBooksButton = new System.Windows.Forms.Button();
            this.booksByAuthorButton = new System.Windows.Forms.Button();
            this.readersWithBookButton = new System.Windows.Forms.Button();
            this.topRatedBooksButton = new System.Windows.Forms.Button();
            this.booksComboBoxForSearch = new System.Windows.Forms.ComboBox();
            this.authorsComboBoxForSearch = new System.Windows.Forms.ComboBox();
            this.booksInHallButton = new System.Windows.Forms.Button();
            this.booksByReaderButton = new System.Windows.Forms.Button();
            this.tabPageIssueBooks = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.issueBooksDataGridView = new System.Windows.Forms.DataGridView();
            this.issueBookButton = new System.Windows.Forms.Button();
            this.returnBookButton = new System.Windows.Forms.Button();
            this.booksComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.readersComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.searchReadersButton = new System.Windows.Forms.Button();
            this.hallsComboBoxForReaders = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bookForSearch = new System.Windows.Forms.Label();
            this.authorForSearch = new System.Windows.Forms.Label();
            this.hallForSearch = new System.Windows.Forms.Label();
            this.readerForSearch = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPageBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).BeginInit();
            this.tabPageReaders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.readersDataGridView)).BeginInit();
            this.tabPageHalls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hallsDataGridView)).BeginInit();
            this.tabPageSearchBooks.SuspendLayout();
            this.tabPageIssueBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.issueBooksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageBooks);
            this.tabControl.Controls.Add(this.tabPageReaders);
            this.tabControl.Controls.Add(this.tabPageHalls);
            this.tabControl.Controls.Add(this.tabPageSearchBooks);
            this.tabControl.Controls.Add(this.tabPageIssueBooks);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(776, 426);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageBooks
            // 
            this.tabPageBooks.Controls.Add(this.booksDataGridView);
            this.tabPageBooks.Controls.Add(this.addBookButton);
            this.tabPageBooks.Controls.Add(this.deleteBookButton);
            this.tabPageBooks.Location = new System.Drawing.Point(4, 22);
            this.tabPageBooks.Name = "tabPageBooks";
            this.tabPageBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBooks.Size = new System.Drawing.Size(768, 400);
            this.tabPageBooks.TabIndex = 0;
            this.tabPageBooks.Text = "Книги";
            this.tabPageBooks.UseVisualStyleBackColor = true;
            // 
            // booksDataGridView
            // 
            this.booksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDataGridView.Location = new System.Drawing.Point(6, 41);
            this.booksDataGridView.Name = "booksDataGridView";
            this.booksDataGridView.Size = new System.Drawing.Size(756, 344);
            this.booksDataGridView.TabIndex = 0;
            // 
            // addBookButton
            // 
            this.addBookButton.Location = new System.Drawing.Point(6, 6);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(150, 29);
            this.addBookButton.TabIndex = 1;
            this.addBookButton.Text = "Добавить книгу";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // deleteBookButton
            // 
            this.deleteBookButton.Location = new System.Drawing.Point(162, 6);
            this.deleteBookButton.Name = "deleteBookButton";
            this.deleteBookButton.Size = new System.Drawing.Size(150, 29);
            this.deleteBookButton.TabIndex = 17;
            this.deleteBookButton.Text = "Удалить книгу";
            this.deleteBookButton.UseVisualStyleBackColor = true;
            this.deleteBookButton.Click += new System.EventHandler(this.deleteBookButton_Click);
            // 
            // tabPageReaders
            // 
            this.tabPageReaders.Controls.Add(this.readersDataGridView);
            this.tabPageReaders.Controls.Add(this.addReaderButton);
            this.tabPageReaders.Controls.Add(this.deleteReaderButton);
            this.tabPageReaders.Location = new System.Drawing.Point(4, 22);
            this.tabPageReaders.Name = "tabPageReaders";
            this.tabPageReaders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReaders.Size = new System.Drawing.Size(768, 400);
            this.tabPageReaders.TabIndex = 1;
            this.tabPageReaders.Text = "Читатели";
            this.tabPageReaders.UseVisualStyleBackColor = true;
            // 
            // readersDataGridView
            // 
            this.readersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.readersDataGridView.Location = new System.Drawing.Point(6, 41);
            this.readersDataGridView.Name = "readersDataGridView";
            this.readersDataGridView.Size = new System.Drawing.Size(756, 344);
            this.readersDataGridView.TabIndex = 1;
            // 
            // addReaderButton
            // 
            this.addReaderButton.Location = new System.Drawing.Point(6, 6);
            this.addReaderButton.Name = "addReaderButton";
            this.addReaderButton.Size = new System.Drawing.Size(150, 29);
            this.addReaderButton.TabIndex = 2;
            this.addReaderButton.Text = "Добавить читателя";
            this.addReaderButton.UseVisualStyleBackColor = true;
            this.addReaderButton.Click += new System.EventHandler(this.addReaderButton_Click);
            // 
            // deleteReaderButton
            // 
            this.deleteReaderButton.Location = new System.Drawing.Point(162, 6);
            this.deleteReaderButton.Name = "deleteReaderButton";
            this.deleteReaderButton.Size = new System.Drawing.Size(150, 29);
            this.deleteReaderButton.TabIndex = 18;
            this.deleteReaderButton.Text = "Удалить читателя";
            this.deleteReaderButton.UseVisualStyleBackColor = true;
            this.deleteReaderButton.Click += new System.EventHandler(this.deleteReaderButton_Click);
            // 
            // tabPageHalls
            // 
            this.tabPageHalls.Controls.Add(this.button1);
            this.tabPageHalls.Controls.Add(this.refreshButton);
            this.tabPageHalls.Controls.Add(this.deleteHallButton);
            this.tabPageHalls.Controls.Add(this.hallsDataGridView);
            this.tabPageHalls.Controls.Add(this.availableSeatsButton);
            this.tabPageHalls.Controls.Add(this.addHallButton);
            this.tabPageHalls.Location = new System.Drawing.Point(4, 22);
            this.tabPageHalls.Name = "tabPageHalls";
            this.tabPageHalls.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHalls.Size = new System.Drawing.Size(768, 400);
            this.tabPageHalls.TabIndex = 2;
            this.tabPageHalls.Text = "Залы";
            this.tabPageHalls.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 29);
            this.button1.TabIndex = 23;
            this.button1.Text = "Просмотреть зал";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.viewHallButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(6, 6);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(150, 29);
            this.refreshButton.TabIndex = 22;
            this.refreshButton.Text = "Обновить";
            this.refreshButton.UseVisualStyleBackColor = true;
            // 
            // deleteHallButton
            // 
            this.deleteHallButton.Location = new System.Drawing.Point(388, 41);
            this.deleteHallButton.Name = "deleteHallButton";
            this.deleteHallButton.Size = new System.Drawing.Size(150, 29);
            this.deleteHallButton.TabIndex = 0;
            this.deleteHallButton.Text = "Удалить зал";
            this.deleteHallButton.Click += new System.EventHandler(this.deleteHallButton_Click);
            // 
            // hallsDataGridView
            // 
            this.hallsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hallsDataGridView.Location = new System.Drawing.Point(6, 81);
            this.hallsDataGridView.Name = "hallsDataGridView";
            this.hallsDataGridView.Size = new System.Drawing.Size(756, 304);
            this.hallsDataGridView.TabIndex = 2;
            // 
            // availableSeatsButton
            // 
            this.availableSeatsButton.Location = new System.Drawing.Point(226, 41);
            this.availableSeatsButton.Name = "availableSeatsButton";
            this.availableSeatsButton.Size = new System.Drawing.Size(150, 29);
            this.availableSeatsButton.TabIndex = 8;
            this.availableSeatsButton.Text = "Свободные места";
            this.availableSeatsButton.UseVisualStyleBackColor = true;
            this.availableSeatsButton.Click += new System.EventHandler(this.availableSeatsButton_Click);
            // 
            // addHallButton
            // 
            this.addHallButton.Location = new System.Drawing.Point(388, 6);
            this.addHallButton.Name = "addHallButton";
            this.addHallButton.Size = new System.Drawing.Size(150, 29);
            this.addHallButton.TabIndex = 21;
            this.addHallButton.Text = "Добавить зал";
            this.addHallButton.UseVisualStyleBackColor = true;
            this.addHallButton.Click += new System.EventHandler(this.addHallButton_Click);
            // 
            // tabPageSearchBooks
            // 
            this.tabPageSearchBooks.Controls.Add(this.readerForSearch);
            this.tabPageSearchBooks.Controls.Add(this.hallForSearch);
            this.tabPageSearchBooks.Controls.Add(this.authorForSearch);
            this.tabPageSearchBooks.Controls.Add(this.bookForSearch);
            this.tabPageSearchBooks.Controls.Add(this.readersComboBoxForSearch);
            this.tabPageSearchBooks.Controls.Add(this.hallsComboBoxForSearch);
            this.tabPageSearchBooks.Controls.Add(this.singleCopyBooksButton);
            this.tabPageSearchBooks.Controls.Add(this.searchBooksButton);
            this.tabPageSearchBooks.Controls.Add(this.booksByAuthorButton);
            this.tabPageSearchBooks.Controls.Add(this.readersWithBookButton);
            this.tabPageSearchBooks.Controls.Add(this.topRatedBooksButton);
            this.tabPageSearchBooks.Controls.Add(this.booksComboBoxForSearch);
            this.tabPageSearchBooks.Controls.Add(this.authorsComboBoxForSearch);
            this.tabPageSearchBooks.Controls.Add(this.booksInHallButton);
            this.tabPageSearchBooks.Controls.Add(this.booksByReaderButton);
            this.tabPageSearchBooks.Location = new System.Drawing.Point(4, 22);
            this.tabPageSearchBooks.Name = "tabPageSearchBooks";
            this.tabPageSearchBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchBooks.Size = new System.Drawing.Size(768, 400);
            this.tabPageSearchBooks.TabIndex = 3;
            this.tabPageSearchBooks.Text = "Поиск книг";
            this.tabPageSearchBooks.UseVisualStyleBackColor = true;
            // 
            // readersComboBoxForSearch
            // 
            this.readersComboBoxForSearch.FormattingEnabled = true;
            this.readersComboBoxForSearch.Location = new System.Drawing.Point(591, 18);
            this.readersComboBoxForSearch.Name = "readersComboBoxForSearch";
            this.readersComboBoxForSearch.Size = new System.Drawing.Size(138, 21);
            this.readersComboBoxForSearch.TabIndex = 30;
            // 
            // hallsComboBoxForSearch
            // 
            this.hallsComboBoxForSearch.FormattingEnabled = true;
            this.hallsComboBoxForSearch.Location = new System.Drawing.Point(447, 18);
            this.hallsComboBoxForSearch.Name = "hallsComboBoxForSearch";
            this.hallsComboBoxForSearch.Size = new System.Drawing.Size(138, 21);
            this.hallsComboBoxForSearch.TabIndex = 29;
            // 
            // singleCopyBooksButton
            // 
            this.singleCopyBooksButton.Location = new System.Drawing.Point(3, 193);
            this.singleCopyBooksButton.Name = "singleCopyBooksButton";
            this.singleCopyBooksButton.Size = new System.Drawing.Size(150, 38);
            this.singleCopyBooksButton.TabIndex = 28;
            this.singleCopyBooksButton.Text = "Книги в одиночном экземпляре";
            this.singleCopyBooksButton.UseVisualStyleBackColor = true;
            // 
            // searchBooksButton
            // 
            this.searchBooksButton.Location = new System.Drawing.Point(3, 18);
            this.searchBooksButton.Name = "searchBooksButton";
            this.searchBooksButton.Size = new System.Drawing.Size(150, 29);
            this.searchBooksButton.TabIndex = 6;
            this.searchBooksButton.Text = "Поиск книг";
            this.searchBooksButton.UseVisualStyleBackColor = true;
            this.searchBooksButton.Click += new System.EventHandler(this.searchBooksButton_Click);
            // 
            // booksByAuthorButton
            // 
            this.booksByAuthorButton.Location = new System.Drawing.Point(3, 53);
            this.booksByAuthorButton.Name = "booksByAuthorButton";
            this.booksByAuthorButton.Size = new System.Drawing.Size(150, 29);
            this.booksByAuthorButton.TabIndex = 11;
            this.booksByAuthorButton.Text = "Книги по автору";
            this.booksByAuthorButton.UseVisualStyleBackColor = true;
            this.booksByAuthorButton.Click += new System.EventHandler(this.booksByAuthorButton_Click);
            // 
            // readersWithBookButton
            // 
            this.readersWithBookButton.Location = new System.Drawing.Point(3, 123);
            this.readersWithBookButton.Name = "readersWithBookButton";
            this.readersWithBookButton.Size = new System.Drawing.Size(150, 29);
            this.readersWithBookButton.TabIndex = 12;
            this.readersWithBookButton.Text = "Читатели с книгой";
            this.readersWithBookButton.UseVisualStyleBackColor = true;
            this.readersWithBookButton.Click += new System.EventHandler(this.readersWithBookButton_Click);
            // 
            // topRatedBooksButton
            // 
            this.topRatedBooksButton.Location = new System.Drawing.Point(3, 237);
            this.topRatedBooksButton.Name = "topRatedBooksButton";
            this.topRatedBooksButton.Size = new System.Drawing.Size(150, 29);
            this.topRatedBooksButton.TabIndex = 13;
            this.topRatedBooksButton.Text = "Топ книг";
            this.topRatedBooksButton.UseVisualStyleBackColor = true;
            this.topRatedBooksButton.Click += new System.EventHandler(this.topRatedBooksButton_Click);
            // 
            // booksComboBoxForSearch
            // 
            this.booksComboBoxForSearch.FormattingEnabled = true;
            this.booksComboBoxForSearch.Location = new System.Drawing.Point(159, 18);
            this.booksComboBoxForSearch.Name = "booksComboBoxForSearch";
            this.booksComboBoxForSearch.Size = new System.Drawing.Size(138, 21);
            this.booksComboBoxForSearch.TabIndex = 14;
            // 
            // authorsComboBoxForSearch
            // 
            this.authorsComboBoxForSearch.FormattingEnabled = true;
            this.authorsComboBoxForSearch.Location = new System.Drawing.Point(303, 18);
            this.authorsComboBoxForSearch.Name = "authorsComboBoxForSearch";
            this.authorsComboBoxForSearch.Size = new System.Drawing.Size(138, 21);
            this.authorsComboBoxForSearch.TabIndex = 15;
            // 
            // booksInHallButton
            // 
            this.booksInHallButton.Location = new System.Drawing.Point(3, 88);
            this.booksInHallButton.Name = "booksInHallButton";
            this.booksInHallButton.Size = new System.Drawing.Size(150, 29);
            this.booksInHallButton.TabIndex = 26;
            this.booksInHallButton.Text = "Книги в зале";
            this.booksInHallButton.UseVisualStyleBackColor = true;
            this.booksInHallButton.Click += new System.EventHandler(this.booksInHallButton_Click);
            // 
            // booksByReaderButton
            // 
            this.booksByReaderButton.Location = new System.Drawing.Point(3, 158);
            this.booksByReaderButton.Name = "booksByReaderButton";
            this.booksByReaderButton.Size = new System.Drawing.Size(150, 29);
            this.booksByReaderButton.TabIndex = 27;
            this.booksByReaderButton.Text = "Книги у читателя";
            this.booksByReaderButton.UseVisualStyleBackColor = true;
            this.booksByReaderButton.Click += new System.EventHandler(this.booksByReaderButton_Click);
            // 
            // tabPageIssueBooks
            // 
            this.tabPageIssueBooks.Controls.Add(this.button2);
            this.tabPageIssueBooks.Controls.Add(this.issueBooksDataGridView);
            this.tabPageIssueBooks.Controls.Add(this.issueBookButton);
            this.tabPageIssueBooks.Controls.Add(this.returnBookButton);
            this.tabPageIssueBooks.Controls.Add(this.booksComboBox);
            this.tabPageIssueBooks.Controls.Add(this.label3);
            this.tabPageIssueBooks.Controls.Add(this.readersComboBox);
            this.tabPageIssueBooks.Controls.Add(this.label4);
            this.tabPageIssueBooks.Location = new System.Drawing.Point(4, 22);
            this.tabPageIssueBooks.Name = "tabPageIssueBooks";
            this.tabPageIssueBooks.Size = new System.Drawing.Size(768, 400);
            this.tabPageIssueBooks.TabIndex = 4;
            this.tabPageIssueBooks.Text = "Выдача книг";
            this.tabPageIssueBooks.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(589, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 29);
            this.button2.TabIndex = 26;
            this.button2.Text = "Просроченные книги";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.showOverdueBooksButton_Click);
            // 
            // issueBooksDataGridView
            // 
            this.issueBooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.issueBooksDataGridView.Location = new System.Drawing.Point(6, 81);
            this.issueBooksDataGridView.Name = "issueBooksDataGridView";
            this.issueBooksDataGridView.Size = new System.Drawing.Size(756, 304);
            this.issueBooksDataGridView.TabIndex = 0;
            // 
            // issueBookButton
            // 
            this.issueBookButton.Location = new System.Drawing.Point(433, 46);
            this.issueBookButton.Name = "issueBookButton";
            this.issueBookButton.Size = new System.Drawing.Size(150, 29);
            this.issueBookButton.TabIndex = 9;
            this.issueBookButton.Text = "Выдать книгу";
            this.issueBookButton.UseVisualStyleBackColor = true;
            this.issueBookButton.Click += new System.EventHandler(this.issueBookButton_Click);
            // 
            // returnBookButton
            // 
            this.returnBookButton.Location = new System.Drawing.Point(433, 7);
            this.returnBookButton.Name = "returnBookButton";
            this.returnBookButton.Size = new System.Drawing.Size(150, 29);
            this.returnBookButton.TabIndex = 10;
            this.returnBookButton.Text = "Вернуть книгу";
            this.returnBookButton.UseVisualStyleBackColor = true;
            this.returnBookButton.Click += new System.EventHandler(this.returnBookButton_Click);
            // 
            // booksComboBox
            // 
            this.booksComboBox.FormattingEnabled = true;
            this.booksComboBox.Location = new System.Drawing.Point(11, 12);
            this.booksComboBox.Name = "booksComboBox";
            this.booksComboBox.Size = new System.Drawing.Size(200, 21);
            this.booksComboBox.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Выберите название книги";
            // 
            // readersComboBox
            // 
            this.readersComboBox.FormattingEnabled = true;
            this.readersComboBox.Location = new System.Drawing.Point(227, 12);
            this.readersComboBox.Name = "readersComboBox";
            this.readersComboBox.Size = new System.Drawing.Size(200, 21);
            this.readersComboBox.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Выберите читателя";
            // 
            // searchReadersButton
            // 
            this.searchReadersButton.Location = new System.Drawing.Point(6, 41);
            this.searchReadersButton.Name = "searchReadersButton";
            this.searchReadersButton.Size = new System.Drawing.Size(150, 29);
            this.searchReadersButton.TabIndex = 7;
            this.searchReadersButton.Text = "Поиск читателей";
            this.searchReadersButton.UseVisualStyleBackColor = true;
            this.searchReadersButton.Click += new System.EventHandler(this.searchReadersButton_Click);
            // 
            // hallsComboBoxForReaders
            // 
            this.hallsComboBoxForReaders.FormattingEnabled = true;
            this.hallsComboBoxForReaders.Location = new System.Drawing.Point(162, 6);
            this.hallsComboBoxForReaders.Name = "hallsComboBoxForReaders";
            this.hallsComboBoxForReaders.Size = new System.Drawing.Size(200, 21);
            this.hallsComboBoxForReaders.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Выберите название зала";
            // 
            // bookForSearch
            // 
            this.bookForSearch.AutoSize = true;
            this.bookForSearch.Location = new System.Drawing.Point(194, 42);
            this.bookForSearch.Name = "bookForSearch";
            this.bookForSearch.Size = new System.Drawing.Size(72, 13);
            this.bookForSearch.TabIndex = 31;
            this.bookForSearch.Text = "Выбор книги";
            // 
            // authorForSearch
            // 
            this.authorForSearch.AutoSize = true;
            this.authorForSearch.Location = new System.Drawing.Point(335, 42);
            this.authorForSearch.Name = "authorForSearch";
            this.authorForSearch.Size = new System.Drawing.Size(78, 13);
            this.authorForSearch.TabIndex = 32;
            this.authorForSearch.Text = "Выбор автора";
            // 
            // hallForSearch
            // 
            this.hallForSearch.AutoSize = true;
            this.hallForSearch.Location = new System.Drawing.Point(484, 42);
            this.hallForSearch.Name = "hallForSearch";
            this.hallForSearch.Size = new System.Drawing.Size(67, 13);
            this.hallForSearch.TabIndex = 33;
            this.hallForSearch.Text = "Выбор зала";
            // 
            // readerForSearch
            // 
            this.readerForSearch.AutoSize = true;
            this.readerForSearch.Location = new System.Drawing.Point(621, 42);
            this.readerForSearch.Name = "readerForSearch";
            this.readerForSearch.Size = new System.Drawing.Size(88, 13);
            this.readerForSearch.TabIndex = 34;
            this.readerForSearch.Text = "Выбор читателя";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Управление библиотекой";
            this.tabControl.ResumeLayout(false);
            this.tabPageBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).EndInit();
            this.tabPageReaders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.readersDataGridView)).EndInit();
            this.tabPageHalls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hallsDataGridView)).EndInit();
            this.tabPageSearchBooks.ResumeLayout(false);
            this.tabPageSearchBooks.PerformLayout();
            this.tabPageIssueBooks.ResumeLayout(false);
            this.tabPageIssueBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.issueBooksDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridView booksDataGridView;
        private System.Windows.Forms.Button singleCopyBooksButton;
        private System.Windows.Forms.ComboBox hallsComboBoxForSearch;
        private System.Windows.Forms.Button deleteHallButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox readersComboBoxForSearch;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label authorForSearch;
        private System.Windows.Forms.Label bookForSearch;
        private System.Windows.Forms.Label readerForSearch;
        private System.Windows.Forms.Label hallForSearch;
    }
}
