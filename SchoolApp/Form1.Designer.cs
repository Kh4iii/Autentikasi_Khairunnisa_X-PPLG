namespace SchoolApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new TextBox();
            btnSave = new Button();
            label1 = new Label();
            label2 = new Label();
            dgvData = new DataGridView();
            txtInstitution = new TextBox();
            label3 = new Label();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 10F);
            txtName.Location = new Point(303, 118);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Input Your Visitor Name...";
            txtName.Size = new Size(463, 34);
            txtName.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(825, 119);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bell MT", 15F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            label1.Location = new Point(89, 118);
            label1.Name = "label1";
            label1.Size = new Size(190, 34);
            label1.TabIndex = 2;
            label1.Text = "Visitor Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bell MT", 15F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(89, 202);
            label2.Name = "label2";
            label2.Size = new Size(157, 34);
            label2.TabIndex = 3;
            label2.Text = "Institution";
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(89, 296);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 62;
            dgvData.Size = new Size(848, 225);
            dgvData.TabIndex = 4;
            dgvData.CellClick += dgvData_CellClick;
            // 
            // txtInstitution
            // 
            txtInstitution.Font = new Font("Segoe UI", 10F);
            txtInstitution.Location = new Point(303, 202);
            txtInstitution.Name = "txtInstitution";
            txtInstitution.PlaceholderText = "Input Your Institution...";
            txtInstitution.Size = new Size(463, 34);
            txtInstitution.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bernard MT Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(362, 37);
            label3.Name = "label3";
            label3.Size = new Size(329, 36);
            label3.TabIndex = 6;
            label3.Text = "Visitor App PPLG PI SCHOOL";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(825, 159);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(825, 203);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1073, 657);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(label3);
            Controls.Add(txtInstitution);
            Controls.Add(dgvData);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(txtName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Button btnSave;
        private Label label1;
        private Label label2;
        private DataGridView dgvData;
        private TextBox txtInstitution;
        private Label label3;
        private Button btnUpdate;
        private Button btnDelete;
    }
}
