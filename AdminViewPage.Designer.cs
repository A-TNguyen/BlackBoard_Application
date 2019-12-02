namespace Blackboard_Application
{
    partial class AdminViewForm
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
            System.Windows.Forms.Label school_IDLabel;
            System.Windows.Forms.Label first_NameLabel;
            System.Windows.Forms.Label last_NameLabel;
            System.Windows.Forms.Label course_TakenLabel;
            System.Windows.Forms.Label class_1_MidtermLabel;
            System.Windows.Forms.Label class_2_MidtermLabel;
            System.Windows.Forms.Label class_3_MidtermLabel;
            System.Windows.Forms.Label class_4_MidtermLabel;
            System.Windows.Forms.Label class_1_FinalsLabel;
            System.Windows.Forms.Label class_2_FinalsLabel;
            System.Windows.Forms.Label class_3_FinalsLabel;
            System.Windows.Forms.Label class_4_FinalsLabel;
            System.Windows.Forms.Label gPALabel;
            this.studentInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentInfoDataSet = new Blackboard_Application.StudentInfoDataSet();
            this.school_IDTextBox = new System.Windows.Forms.TextBox();
            this.first_NameTextBox = new System.Windows.Forms.TextBox();
            this.last_NameTextBox = new System.Windows.Forms.TextBox();
            this.course_TakenTextBox = new System.Windows.Forms.TextBox();
            this.class_1_MidtermTextBox = new System.Windows.Forms.TextBox();
            this.class_2_MidtermTextBox = new System.Windows.Forms.TextBox();
            this.class_3_MidtermTextBox = new System.Windows.Forms.TextBox();
            this.class_4_MidtermTextBox = new System.Windows.Forms.TextBox();
            this.class_1_FinalsTextBox = new System.Windows.Forms.TextBox();
            this.class_2_FinalsTextBox = new System.Windows.Forms.TextBox();
            this.class_3_FinalsTextBox = new System.Windows.Forms.TextBox();
            this.class_4_FinalsTextBox = new System.Windows.Forms.TextBox();
            this.gPATextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.studentInformationTableAdapter = new Blackboard_Application.StudentInfoDataSetTableAdapters.StudentInformationTableAdapter();
            this.tableAdapterManager = new Blackboard_Application.StudentInfoDataSetTableAdapters.TableAdapterManager();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.studentInformationDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            school_IDLabel = new System.Windows.Forms.Label();
            first_NameLabel = new System.Windows.Forms.Label();
            last_NameLabel = new System.Windows.Forms.Label();
            course_TakenLabel = new System.Windows.Forms.Label();
            class_1_MidtermLabel = new System.Windows.Forms.Label();
            class_2_MidtermLabel = new System.Windows.Forms.Label();
            class_3_MidtermLabel = new System.Windows.Forms.Label();
            class_4_MidtermLabel = new System.Windows.Forms.Label();
            class_1_FinalsLabel = new System.Windows.Forms.Label();
            class_2_FinalsLabel = new System.Windows.Forms.Label();
            class_3_FinalsLabel = new System.Windows.Forms.Label();
            class_4_FinalsLabel = new System.Windows.Forms.Label();
            gPALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentInformationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInformationDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // school_IDLabel
            // 
            school_IDLabel.AutoSize = true;
            school_IDLabel.Location = new System.Drawing.Point(28, 114);
            school_IDLabel.Name = "school_IDLabel";
            school_IDLabel.Size = new System.Drawing.Size(145, 32);
            school_IDLabel.TabIndex = 2;
            school_IDLabel.Text = "School ID:";
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.Location = new System.Drawing.Point(28, 190);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(151, 32);
            first_NameLabel.TabIndex = 4;
            first_NameLabel.Text = "first Name:";
            // 
            // last_NameLabel
            // 
            last_NameLabel.AutoSize = true;
            last_NameLabel.Location = new System.Drawing.Point(28, 266);
            last_NameLabel.Name = "last_NameLabel";
            last_NameLabel.Size = new System.Drawing.Size(150, 32);
            last_NameLabel.TabIndex = 6;
            last_NameLabel.Text = "last Name:";
            // 
            // course_TakenLabel
            // 
            course_TakenLabel.AutoSize = true;
            course_TakenLabel.Location = new System.Drawing.Point(28, 342);
            course_TakenLabel.Name = "course_TakenLabel";
            course_TakenLabel.Size = new System.Drawing.Size(200, 32);
            course_TakenLabel.TabIndex = 8;
            course_TakenLabel.Text = "Course Taken:";
            // 
            // class_1_MidtermLabel
            // 
            class_1_MidtermLabel.AutoSize = true;
            class_1_MidtermLabel.Location = new System.Drawing.Point(28, 418);
            class_1_MidtermLabel.Name = "class_1_MidtermLabel";
            class_1_MidtermLabel.Size = new System.Drawing.Size(226, 32);
            class_1_MidtermLabel.TabIndex = 10;
            class_1_MidtermLabel.Text = "Class 1 Midterm:";
            // 
            // class_2_MidtermLabel
            // 
            class_2_MidtermLabel.AutoSize = true;
            class_2_MidtermLabel.Location = new System.Drawing.Point(28, 494);
            class_2_MidtermLabel.Name = "class_2_MidtermLabel";
            class_2_MidtermLabel.Size = new System.Drawing.Size(226, 32);
            class_2_MidtermLabel.TabIndex = 12;
            class_2_MidtermLabel.Text = "Class 2 Midterm:";
            // 
            // class_3_MidtermLabel
            // 
            class_3_MidtermLabel.AutoSize = true;
            class_3_MidtermLabel.Location = new System.Drawing.Point(28, 570);
            class_3_MidtermLabel.Name = "class_3_MidtermLabel";
            class_3_MidtermLabel.Size = new System.Drawing.Size(226, 32);
            class_3_MidtermLabel.TabIndex = 14;
            class_3_MidtermLabel.Text = "Class 3 Midterm:";
            // 
            // class_4_MidtermLabel
            // 
            class_4_MidtermLabel.AutoSize = true;
            class_4_MidtermLabel.Location = new System.Drawing.Point(28, 646);
            class_4_MidtermLabel.Name = "class_4_MidtermLabel";
            class_4_MidtermLabel.Size = new System.Drawing.Size(226, 32);
            class_4_MidtermLabel.TabIndex = 16;
            class_4_MidtermLabel.Text = "Class 4 Midterm:";
            // 
            // class_1_FinalsLabel
            // 
            class_1_FinalsLabel.AutoSize = true;
            class_1_FinalsLabel.Location = new System.Drawing.Point(28, 722);
            class_1_FinalsLabel.Name = "class_1_FinalsLabel";
            class_1_FinalsLabel.Size = new System.Drawing.Size(201, 32);
            class_1_FinalsLabel.TabIndex = 18;
            class_1_FinalsLabel.Text = "Class 1 Finals:";
            // 
            // class_2_FinalsLabel
            // 
            class_2_FinalsLabel.AutoSize = true;
            class_2_FinalsLabel.Location = new System.Drawing.Point(28, 798);
            class_2_FinalsLabel.Name = "class_2_FinalsLabel";
            class_2_FinalsLabel.Size = new System.Drawing.Size(201, 32);
            class_2_FinalsLabel.TabIndex = 20;
            class_2_FinalsLabel.Text = "Class 2 Finals:";
            // 
            // class_3_FinalsLabel
            // 
            class_3_FinalsLabel.AutoSize = true;
            class_3_FinalsLabel.Location = new System.Drawing.Point(28, 874);
            class_3_FinalsLabel.Name = "class_3_FinalsLabel";
            class_3_FinalsLabel.Size = new System.Drawing.Size(201, 32);
            class_3_FinalsLabel.TabIndex = 22;
            class_3_FinalsLabel.Text = "Class 3 Finals:";
            // 
            // class_4_FinalsLabel
            // 
            class_4_FinalsLabel.AutoSize = true;
            class_4_FinalsLabel.Location = new System.Drawing.Point(28, 950);
            class_4_FinalsLabel.Name = "class_4_FinalsLabel";
            class_4_FinalsLabel.Size = new System.Drawing.Size(201, 32);
            class_4_FinalsLabel.TabIndex = 24;
            class_4_FinalsLabel.Text = "Class 4 Finals:";
            // 
            // gPALabel
            // 
            gPALabel.AutoSize = true;
            gPALabel.Location = new System.Drawing.Point(28, 1026);
            gPALabel.Name = "gPALabel";
            gPALabel.Size = new System.Drawing.Size(83, 32);
            gPALabel.TabIndex = 26;
            gPALabel.Text = "GPA:";
            // 
            // studentInformationBindingSource
            // 
            this.studentInformationBindingSource.DataMember = "StudentInformation";
            this.studentInformationBindingSource.DataSource = this.studentInfoDataSet;
            // 
            // studentInfoDataSet
            // 
            this.studentInfoDataSet.DataSetName = "StudentInfoDataSet";
            this.studentInfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // school_IDTextBox
            // 
            this.school_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInformationBindingSource, "School ID", true));
            this.school_IDTextBox.Location = new System.Drawing.Point(296, 114);
            this.school_IDTextBox.Name = "school_IDTextBox";
            this.school_IDTextBox.Size = new System.Drawing.Size(216, 38);
            this.school_IDTextBox.TabIndex = 3;
            this.school_IDTextBox.TextChanged += new System.EventHandler(this.school_IDTextBox_TextChanged);
            // 
            // first_NameTextBox
            // 
            this.first_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInformationBindingSource, "first_Name", true));
            this.first_NameTextBox.Location = new System.Drawing.Point(296, 190);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.Size = new System.Drawing.Size(216, 38);
            this.first_NameTextBox.TabIndex = 5;
            // 
            // last_NameTextBox
            // 
            this.last_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInformationBindingSource, "last_Name", true));
            this.last_NameTextBox.Location = new System.Drawing.Point(296, 266);
            this.last_NameTextBox.Name = "last_NameTextBox";
            this.last_NameTextBox.Size = new System.Drawing.Size(216, 38);
            this.last_NameTextBox.TabIndex = 7;
            // 
            // course_TakenTextBox
            // 
            this.course_TakenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInformationBindingSource, "Course Taken", true));
            this.course_TakenTextBox.Location = new System.Drawing.Point(296, 342);
            this.course_TakenTextBox.Name = "course_TakenTextBox";
            this.course_TakenTextBox.Size = new System.Drawing.Size(216, 38);
            this.course_TakenTextBox.TabIndex = 9;
            // 
            // class_1_MidtermTextBox
            // 
            this.class_1_MidtermTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInformationBindingSource, "Class 1 Midterm", true));
            this.class_1_MidtermTextBox.Location = new System.Drawing.Point(296, 418);
            this.class_1_MidtermTextBox.Name = "class_1_MidtermTextBox";
            this.class_1_MidtermTextBox.Size = new System.Drawing.Size(216, 38);
            this.class_1_MidtermTextBox.TabIndex = 11;
            // 
            // class_2_MidtermTextBox
            // 
            this.class_2_MidtermTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInformationBindingSource, "Class 2 Midterm", true));
            this.class_2_MidtermTextBox.Location = new System.Drawing.Point(296, 494);
            this.class_2_MidtermTextBox.Name = "class_2_MidtermTextBox";
            this.class_2_MidtermTextBox.Size = new System.Drawing.Size(216, 38);
            this.class_2_MidtermTextBox.TabIndex = 13;
            // 
            // class_3_MidtermTextBox
            // 
            this.class_3_MidtermTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInformationBindingSource, "Class 3 Midterm", true));
            this.class_3_MidtermTextBox.Location = new System.Drawing.Point(296, 570);
            this.class_3_MidtermTextBox.Name = "class_3_MidtermTextBox";
            this.class_3_MidtermTextBox.Size = new System.Drawing.Size(216, 38);
            this.class_3_MidtermTextBox.TabIndex = 15;
            // 
            // class_4_MidtermTextBox
            // 
            this.class_4_MidtermTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInformationBindingSource, "Class 4 Midterm", true));
            this.class_4_MidtermTextBox.Location = new System.Drawing.Point(296, 646);
            this.class_4_MidtermTextBox.Name = "class_4_MidtermTextBox";
            this.class_4_MidtermTextBox.Size = new System.Drawing.Size(216, 38);
            this.class_4_MidtermTextBox.TabIndex = 17;
            // 
            // class_1_FinalsTextBox
            // 
            this.class_1_FinalsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInformationBindingSource, "Class 1 Finals", true));
            this.class_1_FinalsTextBox.Location = new System.Drawing.Point(296, 722);
            this.class_1_FinalsTextBox.Name = "class_1_FinalsTextBox";
            this.class_1_FinalsTextBox.Size = new System.Drawing.Size(216, 38);
            this.class_1_FinalsTextBox.TabIndex = 19;
            // 
            // class_2_FinalsTextBox
            // 
            this.class_2_FinalsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInformationBindingSource, "Class 2 Finals", true));
            this.class_2_FinalsTextBox.Location = new System.Drawing.Point(296, 798);
            this.class_2_FinalsTextBox.Name = "class_2_FinalsTextBox";
            this.class_2_FinalsTextBox.Size = new System.Drawing.Size(216, 38);
            this.class_2_FinalsTextBox.TabIndex = 21;
            // 
            // class_3_FinalsTextBox
            // 
            this.class_3_FinalsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInformationBindingSource, "Class 3 Finals", true));
            this.class_3_FinalsTextBox.Location = new System.Drawing.Point(296, 874);
            this.class_3_FinalsTextBox.Name = "class_3_FinalsTextBox";
            this.class_3_FinalsTextBox.Size = new System.Drawing.Size(216, 38);
            this.class_3_FinalsTextBox.TabIndex = 23;
            // 
            // class_4_FinalsTextBox
            // 
            this.class_4_FinalsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInformationBindingSource, "Class 4 Finals", true));
            this.class_4_FinalsTextBox.Location = new System.Drawing.Point(296, 950);
            this.class_4_FinalsTextBox.Name = "class_4_FinalsTextBox";
            this.class_4_FinalsTextBox.Size = new System.Drawing.Size(216, 38);
            this.class_4_FinalsTextBox.TabIndex = 25;
            // 
            // gPATextBox
            // 
            this.gPATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInformationBindingSource, "GPA", true));
            this.gPATextBox.Location = new System.Drawing.Point(296, 1026);
            this.gPATextBox.Name = "gPATextBox";
            this.gPATextBox.Size = new System.Drawing.Size(216, 38);
            this.gPATextBox.TabIndex = 27;
            this.gPATextBox.TextChanged += new System.EventHandler(this.gPATextBox_TextChanged);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(296, 1116);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(216, 58);
            this.AddButton.TabIndex = 28;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(296, 1195);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(216, 58);
            this.SaveButton.TabIndex = 29;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(296, 1274);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(216, 58);
            this.DeleteButton.TabIndex = 30;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // studentInformationTableAdapter
            // 
            this.studentInformationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StudentInformationTableAdapter = this.studentInformationTableAdapter;
            this.tableAdapterManager.UpdateOrder = Blackboard_Application.StudentInfoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(296, 1353);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(216, 58);
            this.LogoutButton.TabIndex = 31;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // studentInformationDataGridView
            // 
            this.studentInformationDataGridView.AutoGenerateColumns = false;
            this.studentInformationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentInformationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.studentInformationDataGridView.DataSource = this.studentInformationBindingSource;
            this.studentInformationDataGridView.Location = new System.Drawing.Point(579, 114);
            this.studentInformationDataGridView.Name = "studentInformationDataGridView";
            this.studentInformationDataGridView.RowHeadersWidth = 102;
            this.studentInformationDataGridView.RowTemplate.Height = 40;
            this.studentInformationDataGridView.Size = new System.Drawing.Size(1697, 1297);
            this.studentInformationDataGridView.TabIndex = 31;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "School ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "School ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 250;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "first_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "first_Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "last_Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "last_Name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 250;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Course Taken";
            this.dataGridViewTextBoxColumn4.HeaderText = "Course Taken";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 250;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Class 1 Midterm";
            this.dataGridViewTextBoxColumn5.HeaderText = "Class 1 Midterm";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 250;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Class 2 Midterm";
            this.dataGridViewTextBoxColumn6.HeaderText = "Class 2 Midterm";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 250;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Class 3 Midterm";
            this.dataGridViewTextBoxColumn7.HeaderText = "Class 3 Midterm";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 250;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Class 4 Midterm";
            this.dataGridViewTextBoxColumn8.HeaderText = "Class 4 Midterm";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 250;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Class 1 Finals";
            this.dataGridViewTextBoxColumn9.HeaderText = "Class 1 Finals";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 250;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Class 2 Finals";
            this.dataGridViewTextBoxColumn10.HeaderText = "Class 2 Finals";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 250;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Class 3 Finals";
            this.dataGridViewTextBoxColumn11.HeaderText = "Class 3 Finals";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 250;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Class 4 Finals";
            this.dataGridViewTextBoxColumn12.HeaderText = "Class 4 Finals";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 250;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "GPA";
            this.dataGridViewTextBoxColumn13.HeaderText = "GPA";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 250;
            // 
            // AdminViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2345, 1458);
            this.Controls.Add(this.studentInformationDataGridView);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(school_IDLabel);
            this.Controls.Add(this.school_IDTextBox);
            this.Controls.Add(first_NameLabel);
            this.Controls.Add(this.first_NameTextBox);
            this.Controls.Add(last_NameLabel);
            this.Controls.Add(this.last_NameTextBox);
            this.Controls.Add(course_TakenLabel);
            this.Controls.Add(this.course_TakenTextBox);
            this.Controls.Add(class_1_MidtermLabel);
            this.Controls.Add(this.class_1_MidtermTextBox);
            this.Controls.Add(class_2_MidtermLabel);
            this.Controls.Add(this.class_2_MidtermTextBox);
            this.Controls.Add(class_3_MidtermLabel);
            this.Controls.Add(this.class_3_MidtermTextBox);
            this.Controls.Add(class_4_MidtermLabel);
            this.Controls.Add(this.class_4_MidtermTextBox);
            this.Controls.Add(class_1_FinalsLabel);
            this.Controls.Add(this.class_1_FinalsTextBox);
            this.Controls.Add(class_2_FinalsLabel);
            this.Controls.Add(this.class_2_FinalsTextBox);
            this.Controls.Add(class_3_FinalsLabel);
            this.Controls.Add(this.class_3_FinalsTextBox);
            this.Controls.Add(class_4_FinalsLabel);
            this.Controls.Add(this.class_4_FinalsTextBox);
            this.Controls.Add(gPALabel);
            this.Controls.Add(this.gPATextBox);
            this.Name = "AdminViewForm";
            this.Text = "Blackboard 3.0 Admin View";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentInformationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInformationDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StudentInfoDataSet studentInfoDataSet;
        private System.Windows.Forms.BindingSource studentInformationBindingSource;
        private StudentInfoDataSetTableAdapters.StudentInformationTableAdapter studentInformationTableAdapter;
        private StudentInfoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox school_IDTextBox;
        private System.Windows.Forms.TextBox first_NameTextBox;
        private System.Windows.Forms.TextBox last_NameTextBox;
        private System.Windows.Forms.TextBox course_TakenTextBox;
        private System.Windows.Forms.TextBox class_1_MidtermTextBox;
        private System.Windows.Forms.TextBox class_2_MidtermTextBox;
        private System.Windows.Forms.TextBox class_3_MidtermTextBox;
        private System.Windows.Forms.TextBox class_4_MidtermTextBox;
        private System.Windows.Forms.TextBox class_1_FinalsTextBox;
        private System.Windows.Forms.TextBox class_2_FinalsTextBox;
        private System.Windows.Forms.TextBox class_3_FinalsTextBox;
        private System.Windows.Forms.TextBox class_4_FinalsTextBox;
        private System.Windows.Forms.TextBox gPATextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.DataGridView studentInformationDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
    }
}