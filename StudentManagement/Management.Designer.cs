namespace StudentManagement
{
    partial class Management
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvStudent = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            txtAge = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtDes = new TextBox();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnRules = new Button();
            lableMes = new Label();
            labelMes = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).BeginInit();
            SuspendLayout();
            // 
            // dgvStudent
            // 
            dgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudent.Location = new Point(30, 12);
            dgvStudent.Name = "dgvStudent";
            dgvStudent.RowTemplate.Height = 25;
            dgvStudent.Size = new Size(740, 198);
            dgvStudent.TabIndex = 0;
            dgvStudent.CellDoubleClick += dgvStudent_CellDoubleClick;
            dgvStudent.EditingControlShowing += dgvStudent_EditingControlShowing;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 247);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 1;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 275);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 2;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 301);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 3;
            label3.Text = "Age:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 329);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 4;
            label4.Text = "Description:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 357);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 5;
            label5.Text = "Phone:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 383);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 6;
            label6.Text = "Email:";
            // 
            // txtId
            // 
            txtId.Location = new Point(88, 244);
            txtId.Name = "txtId";
            txtId.Size = new Size(171, 23);
            txtId.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(88, 272);
            txtName.Name = "txtName";
            txtName.Size = new Size(171, 23);
            txtName.TabIndex = 8;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(88, 298);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(171, 23);
            txtAge.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(88, 380);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(171, 23);
            txtEmail.TabIndex = 12;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(88, 354);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(171, 23);
            txtPhone.TabIndex = 11;
            // 
            // txtDes
            // 
            txtDes.Location = new Point(88, 326);
            txtDes.Name = "txtDes";
            txtDes.Size = new Size(171, 23);
            txtDes.TabIndex = 10;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(184, 416);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 13;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(303, 243);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(303, 275);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRules
            // 
            btnRules.Location = new Point(695, 416);
            btnRules.Name = "btnRules";
            btnRules.Size = new Size(75, 23);
            btnRules.TabIndex = 16;
            btnRules.Text = "Rules";
            btnRules.UseVisualStyleBackColor = true;
            btnRules.Click += btnRules_Click;
            // 
            // lableMes
            // 
            lableMes.AutoSize = true;
            lableMes.Location = new Point(283, 420);
            lableMes.Name = "lableMes";
            lableMes.Size = new Size(0, 15);
            lableMes.TabIndex = 17;
            // 
            // labelMes
            // 
            labelMes.AutoSize = true;
            labelMes.Location = new Point(303, 420);
            labelMes.Name = "labelMes";
            labelMes.Size = new Size(0, 15);
            labelMes.TabIndex = 18;
            // 
            // Management
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 451);
            Controls.Add(labelMes);
            Controls.Add(lableMes);
            Controls.Add(btnRules);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtDes);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvStudent);
            Name = "Management";
            Text = "Management";
            ((System.ComponentModel.ISupportInitialize)dgvStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private DataGridView dgvStudent;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtAge;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtDes;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnRules;
        private Label lableMes;
        private Label labelMes;
    }
}