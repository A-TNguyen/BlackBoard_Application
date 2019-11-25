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
            this.StudentGrid = new System.Windows.Forms.DataGridView();
            this.update8DataBase = new Blackboard_Application.Update8DataBase();
            this.update8DataBaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentInformationTableAdapter = new Blackboard_Application.Update8DataBaseTableAdapters.StudentInformationTableAdapter();
            this.schoolIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseTakenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class1MidtermDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class2MidtermDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class3MidtermDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class4MidtermDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class1FinalsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class2FinalsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class3FinalsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class4FinalsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defaultGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.update8DataBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.update8DataBaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInformationBindingSource)).BeginInit();
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
            this.panel1.Controls.Add(this.StudentGrid);
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
            this.defaultGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.defaultGridView.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.defaultGridView.Location = new System.Drawing.Point(553, 685);
            this.defaultGridView.Name = "defaultGridView";
            this.defaultGridView.RowHeadersWidth = 102;
            this.defaultGridView.RowTemplate.Height = 40;
            this.defaultGridView.Size = new System.Drawing.Size(1688, 386);
            this.defaultGridView.TabIndex = 5;
            this.defaultGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.defaultGridView_CellContentClick);
            // 
            // StudentGrid
            // 
            this.StudentGrid.AllowUserToOrderColumns = true;
            this.StudentGrid.AutoGenerateColumns = false;
            this.StudentGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.StudentGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.StudentGrid.ColumnHeadersHeight = 70;
            this.StudentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.schoolIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.courseTakenDataGridViewTextBoxColumn,
            this.class1MidtermDataGridViewTextBoxColumn,
            this.class2MidtermDataGridViewTextBoxColumn,
            this.class3MidtermDataGridViewTextBoxColumn,
            this.class4MidtermDataGridViewTextBoxColumn,
            this.class1FinalsDataGridViewTextBoxColumn,
            this.class2FinalsDataGridViewTextBoxColumn,
            this.class3FinalsDataGridViewTextBoxColumn,
            this.class4FinalsDataGridViewTextBoxColumn,
            this.gPADataGridViewTextBoxColumn});
            this.StudentGrid.DataSource = this.studentInformationBindingSource;
            this.StudentGrid.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.StudentGrid.Location = new System.Drawing.Point(553, 85);
            this.StudentGrid.Name = "StudentGrid";
            this.StudentGrid.RowHeadersWidth = 102;
            this.StudentGrid.RowTemplate.Height = 40;
            this.StudentGrid.Size = new System.Drawing.Size(1688, 986);
            this.StudentGrid.TabIndex = 1;
            this.StudentGrid.Visible = false;
            this.StudentGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // update8DataBase
            // 
            this.update8DataBase.DataSetName = "Update8DataBase";
            this.update8DataBase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // update8DataBaseBindingSource
            // 
            this.update8DataBaseBindingSource.DataSource = this.update8DataBase;
            this.update8DataBaseBindingSource.Position = 0;
            // 
            // studentInformationBindingSource
            // 
            this.studentInformationBindingSource.DataMember = "StudentInformation";
            this.studentInformationBindingSource.DataSource = this.update8DataBaseBindingSource;
            // 
            // studentInformationTableAdapter
            // 
            this.studentInformationTableAdapter.ClearBeforeFill = true;
            // 
            // schoolIDDataGridViewTextBoxColumn
            // 
            this.schoolIDDataGridViewTextBoxColumn.DataPropertyName = "School ID";
            this.schoolIDDataGridViewTextBoxColumn.HeaderText = "School ID";
            this.schoolIDDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.schoolIDDataGridViewTextBoxColumn.Name = "schoolIDDataGridViewTextBoxColumn";
            this.schoolIDDataGridViewTextBoxColumn.Width = 177;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "first_Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "first_Name";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 205;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "last_Name";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "last_Name";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 204;
            // 
            // courseTakenDataGridViewTextBoxColumn
            // 
            this.courseTakenDataGridViewTextBoxColumn.DataPropertyName = "Course Taken";
            this.courseTakenDataGridViewTextBoxColumn.HeaderText = "Course Taken";
            this.courseTakenDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.courseTakenDataGridViewTextBoxColumn.Name = "courseTakenDataGridViewTextBoxColumn";
            this.courseTakenDataGridViewTextBoxColumn.Width = 226;
            // 
            // class1MidtermDataGridViewTextBoxColumn
            // 
            this.class1MidtermDataGridViewTextBoxColumn.DataPropertyName = "Class 1 Midterm";
            this.class1MidtermDataGridViewTextBoxColumn.HeaderText = "Class 1 Midterm";
            this.class1MidtermDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.class1MidtermDataGridViewTextBoxColumn.Name = "class1MidtermDataGridViewTextBoxColumn";
            this.class1MidtermDataGridViewTextBoxColumn.Width = 250;
            // 
            // class2MidtermDataGridViewTextBoxColumn
            // 
            this.class2MidtermDataGridViewTextBoxColumn.DataPropertyName = "Class 2 Midterm";
            this.class2MidtermDataGridViewTextBoxColumn.HeaderText = "Class 2 Midterm";
            this.class2MidtermDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.class2MidtermDataGridViewTextBoxColumn.Name = "class2MidtermDataGridViewTextBoxColumn";
            this.class2MidtermDataGridViewTextBoxColumn.Width = 250;
            // 
            // class3MidtermDataGridViewTextBoxColumn
            // 
            this.class3MidtermDataGridViewTextBoxColumn.DataPropertyName = "Class 3 Midterm";
            this.class3MidtermDataGridViewTextBoxColumn.HeaderText = "Class 3 Midterm";
            this.class3MidtermDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.class3MidtermDataGridViewTextBoxColumn.Name = "class3MidtermDataGridViewTextBoxColumn";
            this.class3MidtermDataGridViewTextBoxColumn.Width = 250;
            // 
            // class4MidtermDataGridViewTextBoxColumn
            // 
            this.class4MidtermDataGridViewTextBoxColumn.DataPropertyName = "Class 4 Midterm";
            this.class4MidtermDataGridViewTextBoxColumn.HeaderText = "Class 4 Midterm";
            this.class4MidtermDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.class4MidtermDataGridViewTextBoxColumn.Name = "class4MidtermDataGridViewTextBoxColumn";
            this.class4MidtermDataGridViewTextBoxColumn.Width = 250;
            // 
            // class1FinalsDataGridViewTextBoxColumn
            // 
            this.class1FinalsDataGridViewTextBoxColumn.DataPropertyName = "Class 1 Finals";
            this.class1FinalsDataGridViewTextBoxColumn.HeaderText = "Class 1 Finals";
            this.class1FinalsDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.class1FinalsDataGridViewTextBoxColumn.Name = "class1FinalsDataGridViewTextBoxColumn";
            this.class1FinalsDataGridViewTextBoxColumn.Width = 227;
            // 
            // class2FinalsDataGridViewTextBoxColumn
            // 
            this.class2FinalsDataGridViewTextBoxColumn.DataPropertyName = "Class 2 Finals";
            this.class2FinalsDataGridViewTextBoxColumn.HeaderText = "Class 2 Finals";
            this.class2FinalsDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.class2FinalsDataGridViewTextBoxColumn.Name = "class2FinalsDataGridViewTextBoxColumn";
            this.class2FinalsDataGridViewTextBoxColumn.Width = 227;
            // 
            // class3FinalsDataGridViewTextBoxColumn
            // 
            this.class3FinalsDataGridViewTextBoxColumn.DataPropertyName = "Class 3 Finals";
            this.class3FinalsDataGridViewTextBoxColumn.HeaderText = "Class 3 Finals";
            this.class3FinalsDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.class3FinalsDataGridViewTextBoxColumn.Name = "class3FinalsDataGridViewTextBoxColumn";
            this.class3FinalsDataGridViewTextBoxColumn.Width = 227;
            // 
            // class4FinalsDataGridViewTextBoxColumn
            // 
            this.class4FinalsDataGridViewTextBoxColumn.DataPropertyName = "Class 4 Finals";
            this.class4FinalsDataGridViewTextBoxColumn.HeaderText = "Class 4 Finals";
            this.class4FinalsDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.class4FinalsDataGridViewTextBoxColumn.Name = "class4FinalsDataGridViewTextBoxColumn";
            this.class4FinalsDataGridViewTextBoxColumn.Width = 227;
            // 
            // gPADataGridViewTextBoxColumn
            // 
            this.gPADataGridViewTextBoxColumn.DataPropertyName = "GPA";
            this.gPADataGridViewTextBoxColumn.HeaderText = "GPA";
            this.gPADataGridViewTextBoxColumn.MinimumWidth = 12;
            this.gPADataGridViewTextBoxColumn.Name = "gPADataGridViewTextBoxColumn";
            this.gPADataGridViewTextBoxColumn.Width = 129;
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
            ((System.ComponentModel.ISupportInitialize)(this.StudentGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.update8DataBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.update8DataBaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInformationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button StudentButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button deleteStudentButton;
        private System.Windows.Forms.Button updateStudentButton;
        private System.Windows.Forms.Button addStudentData;
        public System.Windows.Forms.DataGridView StudentGrid;
        private System.Windows.Forms.DataGridView defaultGridView;
        private System.Windows.Forms.BindingSource update8DataBaseBindingSource;
        private Update8DataBase update8DataBase;
        private System.Windows.Forms.BindingSource studentInformationBindingSource;
        private Update8DataBaseTableAdapters.StudentInformationTableAdapter studentInformationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseTakenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn class1MidtermDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn class2MidtermDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn class3MidtermDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn class4MidtermDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn class1FinalsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn class2FinalsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn class3FinalsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn class4FinalsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gPADataGridViewTextBoxColumn;
    }
}