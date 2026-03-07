namespace WinFormsAppDemo
{
    partial class Form2
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
            lblEmpId = new Label();
            lblEmpName = new Label();
            lblDesig = new Label();
            lblDOJ = new Label();
            lblEmpSal = new Label();
            lblDeptNo = new Label();
            txtEmpId = new TextBox();
            txtEmpName = new TextBox();
            txtDesig = new TextBox();
            txtDOJ = new TextBox();
            txtEmpSal = new TextBox();
            txtDeptNo = new TextBox();
            btnInsert = new Button();
            btnFind = new Button();
            btnClear = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            btnUdateDB = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblEmpId
            // 
            lblEmpId.AutoSize = true;
            lblEmpId.Location = new Point(175, 40);
            lblEmpId.Name = "lblEmpId";
            lblEmpId.Size = new Size(71, 15);
            lblEmpId.TabIndex = 0;
            lblEmpId.Text = "Enter EmpId";
            // 
            // lblEmpName
            // 
            lblEmpName.AutoSize = true;
            lblEmpName.Location = new Point(175, 67);
            lblEmpName.Name = "lblEmpName";
            lblEmpName.Size = new Size(93, 15);
            lblEmpName.TabIndex = 1;
            lblEmpName.Text = "Enter EmpName";
            // 
            // lblDesig
            // 
            lblDesig.AutoSize = true;
            lblDesig.Location = new Point(175, 94);
            lblDesig.Name = "lblDesig";
            lblDesig.Size = new Size(100, 15);
            lblDesig.TabIndex = 2;
            lblDesig.Text = "Enter Designation";
            // 
            // lblDOJ
            // 
            lblDOJ.AutoSize = true;
            lblDOJ.Location = new Point(175, 121);
            lblDOJ.Name = "lblDOJ";
            lblDOJ.Size = new Size(58, 15);
            lblDOJ.TabIndex = 3;
            lblDOJ.Text = "Enter DOJ";
            // 
            // lblEmpSal
            // 
            lblEmpSal.AutoSize = true;
            lblEmpSal.Location = new Point(175, 149);
            lblEmpSal.Name = "lblEmpSal";
            lblEmpSal.Size = new Size(92, 15);
            lblEmpSal.TabIndex = 4;
            lblEmpSal.Text = "Enter EmpSalary";
            // 
            // lblDeptNo
            // 
            lblDeptNo.AutoSize = true;
            lblDeptNo.Location = new Point(175, 177);
            lblDeptNo.Name = "lblDeptNo";
            lblDeptNo.Size = new Size(81, 15);
            lblDeptNo.TabIndex = 5;
            lblDeptNo.Text = "Enter Dept No";
            // 
            // txtEmpId
            // 
            txtEmpId.Location = new Point(313, 32);
            txtEmpId.Name = "txtEmpId";
            txtEmpId.Size = new Size(100, 23);
            txtEmpId.TabIndex = 6;
            // 
            // txtEmpName
            // 
            txtEmpName.Location = new Point(313, 59);
            txtEmpName.Name = "txtEmpName";
            txtEmpName.Size = new Size(100, 23);
            txtEmpName.TabIndex = 7;
            // 
            // txtDesig
            // 
            txtDesig.Location = new Point(313, 86);
            txtDesig.Name = "txtDesig";
            txtDesig.Size = new Size(100, 23);
            txtDesig.TabIndex = 8;
            // 
            // txtDOJ
            // 
            txtDOJ.Location = new Point(313, 113);
            txtDOJ.Name = "txtDOJ";
            txtDOJ.Size = new Size(100, 23);
            txtDOJ.TabIndex = 9;
            // 
            // txtEmpSal
            // 
            txtEmpSal.Location = new Point(313, 141);
            txtEmpSal.Name = "txtEmpSal";
            txtEmpSal.Size = new Size(100, 23);
            txtEmpSal.TabIndex = 10;
            // 
            // txtDeptNo
            // 
            txtDeptNo.Location = new Point(313, 169);
            txtDeptNo.Name = "txtDeptNo";
            txtDeptNo.Size = new Size(100, 23);
            txtDeptNo.TabIndex = 11;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(150, 220);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 12;
            btnInsert.Text = "INSERT";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(255, 220);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(75, 23);
            btnFind.TabIndex = 13;
            btnFind.Text = "FIND";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(364, 220);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 14;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(150, 267);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(255, 267);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(364, 267);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 17;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnUdateDB
            // 
            btnUdateDB.Location = new Point(518, 267);
            btnUdateDB.Name = "btnUdateDB";
            btnUdateDB.Size = new Size(167, 23);
            btnUdateDB.TabIndex = 18;
            btnUdateDB.Text = "Update Into Database";
            btnUdateDB.UseVisualStyleBackColor = true;
            btnUdateDB.Click += btnUdateDB_Click;
  


            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(501, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;

            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnUdateDB);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnClear);
            Controls.Add(btnFind);
            Controls.Add(btnInsert);
            Controls.Add(txtDeptNo);
            Controls.Add(txtEmpSal);
            Controls.Add(txtDOJ);
            Controls.Add(txtDesig);
            Controls.Add(txtEmpName);
            Controls.Add(txtEmpId);
            Controls.Add(lblDeptNo);
            Controls.Add(lblEmpSal);
            Controls.Add(lblDOJ);
            Controls.Add(lblDesig);
            Controls.Add(lblEmpName);
            Controls.Add(lblEmpId);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmpId;
        private Label lblEmpName;
        private Label lblDesig;
        private Label lblDOJ;
        private Label lblEmpSal;
        private Label lblDeptNo;
        private TextBox txtEmpId;
        private TextBox txtEmpName;
        private TextBox txtDesig;
        private TextBox txtDOJ;
        private TextBox txtEmpSal;
        private TextBox txtDeptNo;
        private Button btnInsert;
        private Button btnFind;
        private Button btnClear;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClose;
        private Button btnUdateDB;
        private DataGridView dataGridView1;
    }
}