namespace LibApp
{
    partial class AddHallForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox libraryNameTextBox;
        private System.Windows.Forms.TextBox specializationTextBox;
        private System.Windows.Forms.TextBox capacityTextBox;
        private System.Windows.Forms.Button saveHallButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.libraryNameTextBox = new System.Windows.Forms.TextBox();
            this.specializationTextBox = new System.Windows.Forms.TextBox();
            this.capacityTextBox = new System.Windows.Forms.TextBox();
            this.saveHallButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // nameTextBox
            //
            this.nameTextBox.Location = new System.Drawing.Point(12, 31);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox.TabIndex = 0;
            //
            // libraryNameTextBox
            //
            this.libraryNameTextBox.Location = new System.Drawing.Point(12, 75);
            this.libraryNameTextBox.Name = "libraryNameTextBox";
            this.libraryNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.libraryNameTextBox.TabIndex = 1;
            //
            // specializationTextBox
            //
            this.specializationTextBox.Location = new System.Drawing.Point(12, 119);
            this.specializationTextBox.Name = "specializationTextBox";
            this.specializationTextBox.Size = new System.Drawing.Size(200, 20);
            this.specializationTextBox.TabIndex = 2;
            //
            // capacityTextBox
            //
            this.capacityTextBox.Location = new System.Drawing.Point(12, 163);
            this.capacityTextBox.Name = "capacityTextBox";
            this.capacityTextBox.Size = new System.Drawing.Size(200, 20);
            this.capacityTextBox.TabIndex = 3;
            //
            // saveHallButton
            //
            this.saveHallButton.Location = new System.Drawing.Point(12, 207);
            this.saveHallButton.Name = "saveHallButton";
            this.saveHallButton.Size = new System.Drawing.Size(200, 23);
            this.saveHallButton.TabIndex = 4;
            this.saveHallButton.Text = "Сохранить зал";
            this.saveHallButton.UseVisualStyleBackColor = true;
            this.saveHallButton.Click += new System.EventHandler(this.saveHallButton_Click);
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название";
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Название библиотеки";
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Специализация";
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Количество мест";
            //
            // AddHallForm
            //
            this.ClientSize = new System.Drawing.Size(284, 246);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveHallButton);
            this.Controls.Add(this.capacityTextBox);
            this.Controls.Add(this.specializationTextBox);
            this.Controls.Add(this.libraryNameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Name = "AddHallForm";
            this.Text = "Добавить зал";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
