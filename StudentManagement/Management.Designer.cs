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
            labelMes = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).BeginInit();
            SuspendLayout();
            // 
            // dgvStudent
            // 
            dgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudent.Location = new Point(34, 16);
            dgvStudent.Margin = new Padding(3, 4, 3, 4);
            dgvStudent.Name = "dgvStudent";
            dgvStudent.RowHeadersWidth = 51;
            dgvStudent.RowTemplate.Height = 25;
            dgvStudent.Size = new Size(846, 264);
            dgvStudent.TabIndex = 0;
            dgvStudent.CellDoubleClick += dgvStudent_CellDoubleClick;
            dgvStudent.EditingControlShowing += dgvStudent_EditingControlShowing;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 329);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 1;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 367);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 2;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 401);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 3;
            label3.Text = "Age:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 439);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 4;
            label4.Text = "Description:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 476);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 5;
            label5.Text = "Phone:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 511);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 6;
            label6.Text = "Email:";
            // 
            // txtId
            // 
            txtId.Location = new Point(101, 325);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.MaxLength = 50;
            txtId.Name = "txtId";
            txtId.Size = new Size(195, 27);
            txtId.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(101, 363);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.MaxLength = 100;
            txtName.Name = "txtName";
            txtName.Size = new Size(195, 27);
            txtName.TabIndex = 8;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(101, 397);
            txtAge.Margin = new Padding(3, 4, 3, 4);
            txtAge.MaxLength = 10;
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(195, 27);
            txtAge.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(101, 507);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(195, 27);
            txtEmail.TabIndex = 12;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(101, 472);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.MaxLength = 50;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(195, 27);
            txtPhone.TabIndex = 11;
            // 
            // txtDes
            // 
            txtDes.Location = new Point(101, 435);
            txtDes.Margin = new Padding(3, 4, 3, 4);
            txtDes.MaxLength = 500;
            txtDes.Name = "txtDes";
            txtDes.Size = new Size(195, 27);
            txtDes.TabIndex = 10;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(210, 555);
            btnCreate.Margin = new Padding(3, 4, 3, 4);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(86, 31);
            btnCreate.TabIndex = 13;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(346, 324);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 31);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(346, 367);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 31);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRules
            // 
            btnRules.Location = new Point(794, 555);
            btnRules.Margin = new Padding(3, 4, 3, 4);
            btnRules.Name = "btnRules";
            btnRules.Size = new Size(86, 31);
            btnRules.TabIndex = 16;
            btnRules.Text = "Rules";
            btnRules.UseVisualStyleBackColor = true;
            btnRules.Click += btnRules_Click;
            // 
            // labelMes
            // 
            labelMes.AutoSize = true;
            labelMes.Location = new Point(346, 435);
            labelMes.Name = "labelMes";
            labelMes.Size = new Size(70, 20);
            labelMes.TabIndex = 17;
            labelMes.Text = "Message:";
            // 
            // Management
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 601);
            Controls.Add(labelMes);
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
            Margin = new Padding(3, 4, 3, 4);
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
        private Label labelMes;
    }
}