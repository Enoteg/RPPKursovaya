namespace LibApp
{
    partial class AddReaderForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox fioTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox registrationDateTextBox;
        private System.Windows.Forms.TextBox dateOfBirthTextBox;
        private System.Windows.Forms.TextBox educationTextBox;
        private System.Windows.Forms.ComboBox hallsComboBox;
        private System.Windows.Forms.Button saveReaderButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;

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
            this.fioTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.registrationDateTextBox = new System.Windows.Forms.TextBox();
            this.dateOfBirthTextBox = new System.Windows.Forms.TextBox();
            this.educationTextBox = new System.Windows.Forms.TextBox();
            this.hallsComboBox = new System.Windows.Forms.ComboBox();
            this.saveReaderButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fioTextBox
            // 
            this.fioTextBox.Location = new System.Drawing.Point(122, 10);
            this.fioTextBox.Name = "fioTextBox";
            this.fioTextBox.Size = new System.Drawing.Size(200, 20);
            this.fioTextBox.TabIndex = 0;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(122, 37);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(200, 20);
            this.phoneNumberTextBox.TabIndex = 1;
            // 
            // registrationDateTextBox
            // 
            this.registrationDateTextBox.Location = new System.Drawing.Point(122, 64);
            this.registrationDateTextBox.Name = "registrationDateTextBox";
            this.registrationDateTextBox.Size = new System.Drawing.Size(200, 20);
            this.registrationDateTextBox.TabIndex = 2;
            // 
            // dateOfBirthTextBox
            // 
            this.dateOfBirthTextBox.Location = new System.Drawing.Point(122, 91);
            this.dateOfBirthTextBox.Name = "dateOfBirthTextBox";
            this.dateOfBirthTextBox.Size = new System.Drawing.Size(200, 20);
            this.dateOfBirthTextBox.TabIndex = 3;
            // 
            // educationTextBox
            // 
            this.educationTextBox.Location = new System.Drawing.Point(122, 118);
            this.educationTextBox.Name = "educationTextBox";
            this.educationTextBox.Size = new System.Drawing.Size(200, 20);
            this.educationTextBox.TabIndex = 4;
            // 
            // hallsComboBox
            // 
            this.hallsComboBox.FormattingEnabled = true;
            this.hallsComboBox.Location = new System.Drawing.Point(122, 145);
            this.hallsComboBox.Name = "hallsComboBox";
            this.hallsComboBox.Size = new System.Drawing.Size(200, 21);
            this.hallsComboBox.TabIndex = 5;
            // 
            // saveReaderButton
            // 
            this.saveReaderButton.Location = new System.Drawing.Point(122, 172);
            this.saveReaderButton.Name = "saveReaderButton";
            this.saveReaderButton.Size = new System.Drawing.Size(200, 23);
            this.saveReaderButton.TabIndex = 6;
            this.saveReaderButton.Text = "Добавить читателя";
            this.saveReaderButton.UseVisualStyleBackColor = true;
            this.saveReaderButton.Click += new System.EventHandler(this.saveReaderButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ФИО:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Номер телефона:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Дата регистрации:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Дата рождения:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Образование:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Зал:";
            // 
            // AddReaderForm
            // 
            this.ClientSize = new System.Drawing.Size(411, 220);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveReaderButton);
            this.Controls.Add(this.hallsComboBox);
            this.Controls.Add(this.educationTextBox);
            this.Controls.Add(this.dateOfBirthTextBox);
            this.Controls.Add(this.registrationDateTextBox);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.fioTextBox);
            this.Name = "AddReaderForm";
            this.Text = "Добавить читателя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
