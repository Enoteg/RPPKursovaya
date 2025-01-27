// ViewRoomsForm.Designer.cs
namespace LibraryManagement
{
    partial class ViewRoomsForm
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
            this.roomsListView = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSpecialization = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCapacity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // roomsListView
            this.roomsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnSpecialization,
            this.columnCapacity});
            this.roomsListView.FullRowSelect = true;
            this.roomsListView.GridLines = true;
            this.roomsListView.HideSelection = false;
            this.roomsListView.Location = new System.Drawing.Point(12, 12);
            this.roomsListView.Name = "roomsListView";
            this.roomsListView.Size = new System.Drawing.Size(460, 300);
            this.roomsListView.TabIndex = 0;
            this.roomsListView.UseCompatibleStateImageBehavior = false;
            this.roomsListView.View = System.Windows.Forms.View.Details;

            // columnName
            this.columnName.Text = "Название";
            this.columnName.Width = 150;

            // columnSpecialization
            this.columnSpecialization.Text = "Специализация";
            this.columnSpecialization.Width = 200;

            // columnCapacity
            this.columnCapacity.Text = "Вместимость";
            this.columnCapacity.Width = 100;

            // btnClose
            this.btnClose.Location = new System.Drawing.Point(397, 320);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // ViewRoomsForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.roomsListView);
            this.Name = "ViewRoomsForm";
            this.Text = "Просмотр залов";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ListView roomsListView;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnSpecialization;
        private System.Windows.Forms.ColumnHeader columnCapacity;
        private System.Windows.Forms.Button btnClose;
    }
}
