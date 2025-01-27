using System;
using System.Windows.Forms;

namespace LibApp
{
    public partial class AddBookForm : Form
    {
        private TextBox titleTextBox;
        private TextBox authorTextBox;
        private TextBox yearTextBox;
        private TextBox copiesTextBox;
        private ComboBox hallsComboBox;
        private Button saveBookButton;
        private Label titleLabel;
        private Label authorLabel;
        private Label yearLabel;
        private Label copiesLabel;
        private Label hallsLabel;

        private void InitializeComponent()
        {
            this.titleLabel = new Label();
            this.authorLabel = new Label();
            this.yearLabel = new Label();
            this.copiesLabel = new Label();
            this.hallsLabel = new Label();

            this.titleTextBox = new TextBox();
            this.authorTextBox = new TextBox();
            this.yearTextBox = new TextBox();
            this.copiesTextBox = new TextBox();
            this.hallsComboBox = new ComboBox();
            this.saveBookButton = new Button();

            this.SuspendLayout();

            // titleLabel
            this.titleLabel.Location = new System.Drawing.Point(10, 10);
            this.titleLabel.Size = new System.Drawing.Size(100, 20);
            this.titleLabel.Text = "Название книги:";

            // authorLabel
            this.authorLabel.Location = new System.Drawing.Point(10, 40);
            this.authorLabel.Size = new System.Drawing.Size(100, 20);
            this.authorLabel.Text = "Автор:";

            // yearLabel
            this.yearLabel.Location = new System.Drawing.Point(10, 70);
            this.yearLabel.Size = new System.Drawing.Size(100, 20);
            this.yearLabel.Text = "Год издания:";

            // copiesLabel
            this.copiesLabel.Location = new System.Drawing.Point(10, 100);
            this.copiesLabel.Size = new System.Drawing.Size(100, 20);
            this.copiesLabel.Text = "Количество экземпляров:";

            // hallsLabel
            this.hallsLabel.Location = new System.Drawing.Point(10, 130);
            this.hallsLabel.Size = new System.Drawing.Size(100, 20);
            this.hallsLabel.Text = "Выберите зал:";

            // titleTextBox
            this.titleTextBox.Location = new System.Drawing.Point(120, 10);
            this.titleTextBox.Size = new System.Drawing.Size(200, 20);

            // authorTextBox
            this.authorTextBox.Location = new System.Drawing.Point(120, 40);
            this.authorTextBox.Size = new System.Drawing.Size(200, 20);

            // yearTextBox
            this.yearTextBox.Location = new System.Drawing.Point(120, 70);
            this.yearTextBox.Size = new System.Drawing.Size(200, 20);

            // copiesTextBox
            this.copiesTextBox.Location = new System.Drawing.Point(120, 100);
            this.copiesTextBox.Size = new System.Drawing.Size(200, 20);

            // hallsComboBox
            this.hallsComboBox.Location = new System.Drawing.Point(120, 130);
            this.hallsComboBox.Size = new System.Drawing.Size(200, 20);

            // saveBookButton
            this.saveBookButton.Location = new System.Drawing.Point(120, 160);
            this.saveBookButton.Size = new System.Drawing.Size(200, 30);
            this.saveBookButton.Text = "Сохранить";
            this.saveBookButton.Click += new System.EventHandler(this.saveBookButton_Click);

            // Add controls to the form
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.copiesLabel);
            this.Controls.Add(this.hallsLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.copiesTextBox);
            this.Controls.Add(this.hallsComboBox);
            this.Controls.Add(this.saveBookButton);

            this.ClientSize = new System.Drawing.Size(340, 200);
            this.Text = "Добавить книгу";
            this.ResumeLayout(false);
        }
    }
}
