namespace Blackboard_Application
{
    partial class AdminPageForm
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
            this.StudentButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.deleteStudentButton = new System.Windows.Forms.Button();
            this.updateStudentButton = new System.Windows.Forms.Button();
            this.addStudentData = new System.Windows.Forms.Button();
            this.defaultGridView = new System.Windows.Forms.DataGridView();
            this.viewStudentGrid = new System.Windows.Forms.DataGridView();
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
            this.blackboardDatabaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentInformationTableAdapter = new Blackboard_Application.BlackboardDatabaseTableAdapters.StudentInformationTableAdapter();
            this.blackboardDatabaseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter = new Blackboard_Application.BlackboardDatabaseTableAdapters.CourseTableAdapter();
            this.gradeBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gradeBookTableAdapter = new Blackboard_Application.BlackboardDatabaseTableAdapters.GradeBookTableAdapter();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new Blackboard_Application.BlackboardDatabaseTableAdapters.UsersTableAdapter();
            this.blackboardDatabaseBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.blackboardDatabaseBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defaultGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewStudentGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInformationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackboardDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackboardDatabaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackboardDatabaseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeBookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackboardDatabaseBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackboardDatabaseBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.StudentButton);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.deleteStudentButton);
            this.panel1.Controls.Add(this.updateStudentButton);
            this.panel1.Controls.Add(this.addStudentData);
            this.panel1.Controls.Add(this.defaultGridView);
            this.panel1.Controls.Add(this.viewStudentGrid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2309, 1157);
            this.panel1.TabIndex = 0;
            // 
            // StudentButton
            // 
            this.StudentButton.Location = new System.Drawing.Point(72, 85);
            this.StudentButton.Name = "StudentButton";
            this.StudentButton.Size = new System.Drawing.Size(409, 80);
            this.StudentButton.TabIndex = 4;
            this.StudentButton.Text = "Student Information";
            this.StudentButton.UseVisualStyleBackColor = true;
            this.StudentButton.Click += new System.EventHandler(this.Button5_Click);
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
            // deleteStudentButton
            // 
            this.deleteStudentButton.Location = new System.Drawing.Point(72, 478);
            this.deleteStudentButton.Name = "deleteStudentButton";
            this.deleteStudentButton.Size = new System.Drawing.Size(409, 80);
            this.deleteStudentButton.TabIndex = 2;
            this.deleteStudentButton.Text = "Delete Student Data";
            this.deleteStudentButton.UseVisualStyleBackColor = true;
            this.deleteStudentButton.Visible = false;
            this.deleteStudentButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // updateStudentButton
            // 
            this.updateStudentButton.Location = new System.Drawing.Point(72, 347);
            this.updateStudentButton.Name = "updateStudentButton";
            this.updateStudentButton.Size = new System.Drawing.Size(409, 80);
            this.updateStudentButton.TabIndex = 1;
            this.updateStudentButton.Text = "Update Student Data";
            this.updateStudentButton.UseVisualStyleBackColor = true;
            this.updateStudentButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // addStudentData
            // 
            this.addStudentData.Location = new System.Drawing.Point(72, 216);
            this.addStudentData.Name = "addStudentData";
            this.addStudentData.Size = new System.Drawing.Size(409, 80);
            this.addStudentData.TabIndex = 0;
            this.addStudentData.Text = "User Information";
            this.addStudentData.UseVisualStyleBackColor = true;
            this.addStudentData.Click += new System.EventHandler(this.addStudentData_Click);
            // 
            // defaultGridView
            // 
            this.defaultGridView.AllowUserToOrderColumns = true;
            this.defaultGridView.AutoGenerateColumns = false;
            this.defaultGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.defaultGridView.DataSource = this.blackboardDatabaseBindingSource3;
            this.defaultGridView.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.defaultGridView.Location = new System.Drawing.Point(553, 85);
            this.defaultGridView.Name = "defaultGridView";
            this.defaultGridView.RowHeadersWidth = 102;
            this.defaultGridView.RowTemplate.Height = 40;
            this.defaultGridView.Size = new System.Drawing.Size(1688, 986);
            this.defaultGridView.TabIndex = 5;
            this.defaultGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.defaultGridView_CellContentClick);
            // 
            // viewStudentGrid
            // 
            this.viewStudentGrid.AllowUserToOrderColumns = true;
            this.viewStudentGrid.AutoGenerateColumns = false;
            this.viewStudentGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewStudentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewStudentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.viewStudentGrid.DataSource = this.studentInformationBindingSource;
            this.viewStudentGrid.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.viewStudentGrid.Location = new System.Drawing.Point(553, 85);
            this.viewStudentGrid.Name = "viewStudentGrid";
            this.viewStudentGrid.RowHeadersWidth = 102;
            this.viewStudentGrid.RowTemplate.Height = 40;
            this.viewStudentGrid.Size = new System.Drawing.Size(1688, 986);
            this.viewStudentGrid.TabIndex = 1;
            this.viewStudentGrid.Visible = false;
            this.viewStudentGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
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
            // blackboardDatabaseBindingSource
            // 
            this.blackboardDatabaseBindingSource.DataSource = this.blackboardDatabase;
            this.blackboardDatabaseBindingSource.Position = 0;
            // 
            // studentInformationTableAdapter
            // 
            this.studentInformationTableAdapter.ClearBeforeFill = true;
            // 
            // blackboardDatabaseBindingSource1
            // 
            this.blackboardDatabaseBindingSource1.DataSource = this.blackboardDatabase;
            this.blackboardDatabaseBindingSource1.Position = 0;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.blackboardDatabaseBindingSource1;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // gradeBookBindingSource
            // 
            this.gradeBookBindingSource.DataMember = "GradeBook";
            this.gradeBookBindingSource.DataSource = this.blackboardDatabaseBindingSource1;
            // 
            // gradeBookTableAdapter
            // 
            this.gradeBookTableAdapter.ClearBeforeFill = true;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.blackboardDatabaseBindingSource1;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // blackboardDatabaseBindingSource2
            // 
            this.blackboardDatabaseBindingSource2.DataSource = this.blackboardDatabase;
            this.blackboardDatabaseBindingSource2.Position = 0;
            // 
            // blackboardDatabaseBindingSource3
            // 
            this.blackboardDatabaseBindingSource3.DataSource = this.blackboardDatabase;
            this.blackboardDatabaseBindingSource3.Position = 0;
            // 
            // AdminPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2309, 1157);
            this.Controls.Add(this.panel1);
            this.Name = "AdminPageForm";
            this.Text = "Blackboard 3.0 Administrator Mode";
            this.Load += new System.EventHandler(this.MainPageForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.defaultGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewStudentGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInformationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackboardDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackboardDatabaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackboardDatabaseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeBookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackboardDatabaseBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackboardDatabaseBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button StudentButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button deleteStudentButton;
        private System.Windows.Forms.Button updateStudentButton;
        private System.Windows.Forms.Button addStudentData;
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
        public System.Windows.Forms.DataGridView viewStudentGrid;
        private System.Windows.Forms.DataGridView defaultGridView;
        private System.Windows.Forms.BindingSource blackboardDatabaseBindingSource1;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private BlackboardDatabaseTableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.BindingSource gradeBookBindingSource;
        private BlackboardDatabaseTableAdapters.GradeBookTableAdapter gradeBookTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private BlackboardDatabaseTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource blackboardDatabaseBindingSource3;
        private System.Windows.Forms.BindingSource blackboardDatabaseBindingSource2;
    }
}