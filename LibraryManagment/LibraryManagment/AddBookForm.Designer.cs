// AddBookForm.Designer.cs
namespace LibraryManagement
{
    partial class AddBookForm
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtCopies = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtCopies)).BeginInit();
            this.SuspendLayout();

            // txtTitle
            this.txtTitle.Location = new System.Drawing.Point(12, 12);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(260, 20);
            this.txtTitle.TabIndex = 0;

            // txtAuthor
            this.txtAuthor.Location = new System.Drawing.Point(12, 38);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(260, 20);
            this.txtAuthor.TabIndex = 1;

            // txtCode
            this.txtCode.Location = new System.Drawing.Point(12, 64);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(260, 20);
            this.txtCode.TabIndex = 2;

            // txtCopies
            this.txtCopies.Location = new System.Drawing.Point(12, 90);
            this.txtCopies.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCopies.Name = "txtCopies";
            this.txtCopies.Size = new System.Drawing.Size(120, 20);
            this.txtCopies.TabIndex = 3;
            this.txtCopies.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});

            // btnSave
            this.btnSave.Location = new System.Drawing.Point(197, 116);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // AddBookForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 151);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCopies);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtTitle);
            this.Name = "AddBookForm";
            this.Text = "Добавить книгу";
            ((System.ComponentModel.ISupportInitialize)(this.txtCopies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.NumericUpDown txtCopies;
        private System.Windows.Forms.Button btnSave;
    }
}
