namespace WinFormsApp1
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
            txtAge = new TextBox();
            txtEmail = new TextBox();
            btnAdd = new Button();
            dgvStudents = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(152, 111);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 0;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(152, 202);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(125, 27);
            txtAge.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(152, 294);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(355, 392);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(355, 53);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.Size = new Size(418, 293);
            dgvStudents.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 117);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 5;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 209);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 6;
            label2.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 297);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 7;
            label3.Text = "Email";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 512);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvStudents);
            Controls.Add(btnAdd);
            Controls.Add(txtEmail);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtAge;
        private TextBox txtEmail;
        private Button btnAdd;
        private DataGridView dgvStudents;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
