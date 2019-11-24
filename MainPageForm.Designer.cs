namespace Blackboard_Application
{
    partial class MainPageForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.schoolIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class1MidtermDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class2MidtermDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class3MidtermDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class4MidtermDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class1FinalsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class2FinalsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class3FinalsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class4FinalsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.blackboardDatabase = new Blackboard_Application.BlackboardDatabase();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.blackboardDatabaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentInformationTableAdapter = new Blackboard_Application.BlackboardDatabaseTableAdapters.StudentInformationTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInformationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackboardDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackboardDatabaseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2309, 1157);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.schoolIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.class1MidtermDataGridViewTextBoxColumn,
            this.class2MidtermDataGridViewTextBoxColumn,
            this.class3MidtermDataGridViewTextBoxColumn,
            this.class4MidtermDataGridViewTextBoxColumn,
            this.class1FinalsDataGridViewTextBoxColumn,
            this.class2FinalsDataGridViewTextBoxColumn,
            this.class3FinalsDataGridViewTextBoxColumn,
            this.class4FinalsDataGridViewTextBoxColumn,
            this.gPADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentInformationBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(553, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1688, 986);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // schoolIDDataGridViewTextBoxColumn
            // 
            this.schoolIDDataGridViewTextBoxColumn.DataPropertyName = "School ID";
            this.schoolIDDataGridViewTextBoxColumn.HeaderText = "School ID";
            this.schoolIDDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.schoolIDDataGridViewTextBoxColumn.Name = "schoolIDDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "first_Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "first_Name";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "last_Name";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "last_Name";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // class1MidtermDataGridViewTextBoxColumn
            // 
            this.class1MidtermDataGridViewTextBoxColumn.DataPropertyName = "Class 1 Midterm";
            this.class1MidtermDataGridViewTextBoxColumn.HeaderText = "Class 1 Midterm";
            this.class1MidtermDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.class1MidtermDataGridViewTextBoxColumn.Name = "class1MidtermDataGridViewTextBoxColumn";
            // 
            // class2MidtermDataGridViewTextBoxColumn
            // 
            this.class2MidtermDataGridViewTextBoxColumn.DataPropertyName = "Class 2 Midterm";
            this.class2MidtermDataGridViewTextBoxColumn.HeaderText = "Class 2 Midterm";
            this.class2MidtermDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.class2MidtermDataGridViewTextBoxColumn.Name = "class2MidtermDataGridViewTextBoxColumn";
            // 
            // class3MidtermDataGridViewTextBoxColumn
            // 
            this.class3MidtermDataGridViewTextBoxColumn.DataPropertyName = "Class 3 Midterm";
            this.class3MidtermDataGridViewTextBoxColumn.HeaderText = "Class 3 Midterm";
            this.class3MidtermDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.class3MidtermDataGridViewTextBoxColumn.Name = "class3MidtermDataGridViewTextBoxColumn";
            // 
            // class4MidtermDataGridViewTextBoxColumn
            // 
            this.class4MidtermDataGridViewTextBoxColumn.DataPropertyName = "Class 4 Midterm";
            this.class4MidtermDataGridViewTextBoxColumn.HeaderText = "Class 4 Midterm";
            this.class4MidtermDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.class4MidtermDataGridViewTextBoxColumn.Name = "class4MidtermDataGridViewTextBoxColumn";
            // 
            // class1FinalsDataGridViewTextBoxColumn
            // 
            this.class1FinalsDataGridViewTextBoxColumn.DataPropertyName = "Class 1 Finals";
            this.class1FinalsDataGridViewTextBoxColumn.HeaderText = "Class 1 Finals";
            this.class1FinalsDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.class1FinalsDataGridViewTextBoxColumn.Name = "class1FinalsDataGridViewTextBoxColumn";
            // 
            // class2FinalsDataGridViewTextBoxColumn
            // 
            this.class2FinalsDataGridViewTextBoxColumn.DataPropertyName = "Class 2 Finals";
            this.class2FinalsDataGridViewTextBoxColumn.HeaderText = "Class 2 Finals";
            this.class2FinalsDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.class2FinalsDataGridViewTextBoxColumn.Name = "class2FinalsDataGridViewTextBoxColumn";
            // 
            // class3FinalsDataGridViewTextBoxColumn
            // 
            this.class3FinalsDataGridViewTextBoxColumn.DataPropertyName = "Class 3 Finals";
            this.class3FinalsDataGridViewTextBoxColumn.HeaderText = "Class 3 Finals";
            this.class3FinalsDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.class3FinalsDataGridViewTextBoxColumn.Name = "class3FinalsDataGridViewTextBoxColumn";
            // 
            // class4FinalsDataGridViewTextBoxColumn
            // 
            this.class4FinalsDataGridViewTextBoxColumn.DataPropertyName = "Class 4 Finals";
            this.class4FinalsDataGridViewTextBoxColumn.HeaderText = "Class 4 Finals";
            this.class4FinalsDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.class4FinalsDataGridViewTextBoxColumn.Name = "class4FinalsDataGridViewTextBoxColumn";
            // 
            // gPADataGridViewTextBoxColumn
            // 
            this.gPADataGridViewTextBoxColumn.DataPropertyName = "GPA";
            this.gPADataGridViewTextBoxColumn.HeaderText = "GPA";
            this.gPADataGridViewTextBoxColumn.MinimumWidth = 12;
            this.gPADataGridViewTextBoxColumn.Name = "gPADataGridViewTextBoxColumn";
            // 
            // studentInformationBindingSource
            // 
            this.studentInformationBindingSource.DataMember = "StudentInformation";
            this.studentInformationBindingSource.DataSource = this.blackboardDatabase;
            // 
            // blackboardDatabase
            // 
            this.blackboardDatabase.DataSetName = "BlackboardDatabase";
            this.blackboardDatabase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(72, 85);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(409, 80);
            this.button5.TabIndex = 4;
            this.button5.Text = "View Student Information";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(72, 609);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(409, 80);
            this.button4.TabIndex = 3;
            this.button4.Text = "Logout";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(72, 478);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(409, 80);
            this.button3.TabIndex = 2;
            this.button3.Text = "Delete Student Data";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(72, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(409, 80);
            this.button2.TabIndex = 1;
            this.button2.Text = "Update Student Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(409, 80);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add New Student\r\n";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // blackboardDatabaseBindingSource
            // 
            this.blackboardDatabaseBindingSource.DataSource = this.blackboardDatabase;
            this.blackboardDatabaseBindingSource.Position = 0;
            // 
            // studentInformationTableAdapter
            // 
            this.studentInformationTableAdapter.ClearBeforeFill = true;
            // 
            // MainPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2309, 1157);
            this.Controls.Add(this.panel1);
            this.Name = "MainPageForm";
            this.Text = "MainPageForm";
            this.Load += new System.EventHandler(this.MainPageForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInformationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackboardDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackboardDatabaseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource blackboardDatabaseBindingSource;
        private BlackboardDatabase blackboardDatabase;
        private System.Windows.Forms.BindingSource studentInformationBindingSource;
        private BlackboardDatabaseTableAdapters.StudentInformationTableAdapter studentInformationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn class1MidtermDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn class2MidtermDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn class3MidtermDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn class4MidtermDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn class1FinalsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn class2FinalsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn class3FinalsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn class4FinalsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gPADataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}