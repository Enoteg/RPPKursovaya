// AddReaderForm.Designer.cs
namespace LibraryManagement
{
    partial class AddReaderForm
    {
        private System.ComponentModel.IContainer components = null;

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
            this.txtName = new System.Windows.Forms.TextBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtEducation = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // txtName
            this.txtName.Location = new System.Drawing.Point(12, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(260, 20);
            this.txtName.TabIndex = 0;

            // dtpBirthDate
            this.dtpBirthDate.Location = new System.Drawing.Point(12, 38);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(260, 20);
            this.dtpBirthDate.TabIndex = 1;

            // txtPhoneNumber
            this.txtPhoneNumber.Location = new System.Drawing.Point(12, 64);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(260, 20);
            this.txtPhoneNumber.TabIndex = 2;

            // txtEducation
            this.txtEducation.Location = new System.Drawing.Point(12, 90);
            this.txtEducation.Name = "txtEducation";
            this.txtEducation.Size = new System.Drawing.Size(260, 20);
            this.txtEducation.TabIndex = 3;

            // btnSave
            this.btnSave.Location = new System.Drawing.Point(197, 116);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // AddReaderForm
            this.ClientSize = new System.Drawing.Size(284, 151);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtEducation);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.txtName);
            this.Name = "AddReaderForm";
            this.Text = "Добавить читателя";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtEducation;
        private System.Windows.Forms.Button btnSave;
    }
}
