namespace Blackboard_Application
{
    partial class StudentViewForm
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
            this.school_IDTextBox = new System.Windows.Forms.TextBox();
            this.studentInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentInfoDataSet = new Blackboard_Application.StudentInfoDataSet();
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
            this.logoutButton = new System.Windows.Forms.Button();
            this.studentInformationTableAdapter = new Blackboard_Application.StudentInfoDataSetTableAdapters.StudentInformationTableAdapter();
            this.tableAdapterManager = new Blackboard_Application.StudentInfoDataSetTableAdapters.TableAdapterManager();
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
            this.SuspendLayout();
            // 
            // school_IDLabel
            // 
            school_IDLabel.AutoSize = true;
            school_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            school_IDLabel.Location = new System.Drawing.Point(106, 69);
            school_IDLabel.Name = "school_IDLabel";
            school_IDLabel.Size = new System.Drawing.Size(216, 46);
            school_IDLabel.TabIndex = 1;
            school_IDLabel.Text = "School ID:";
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            first_NameLabel.Location = new System.Drawing.Point(106, 139);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(223, 46);
            first_NameLabel.TabIndex = 3;
            first_NameLabel.Text = "first Name:";
            // 
            // last_NameLabel
            // 
            last_NameLabel.AutoSize = true;
            last_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            last_NameLabel.Location = new System.Drawing.Point(106, 209);
            last_NameLabel.Name = "last_NameLabel";
            last_NameLabel.Size = new System.Drawing.Size(220, 46);
            last_NameLabel.TabIndex = 5;
            last_NameLabel.Text = "last Name:";
            // 
            // course_TakenLabel
            // 
            course_TakenLabel.AutoSize = true;
            course_TakenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            course_TakenLabel.Location = new System.Drawing.Point(106, 279);
            course_TakenLabel.Name = "course_TakenLabel";
            course_TakenLabel.Size = new System.Drawing.Size(294, 46);
            course_TakenLabel.TabIndex = 7;
            course_TakenLabel.Text = "Course Taken:";
            // 
            // class_1_MidtermLabel
            // 
            class_1_MidtermLabel.AutoSize = true;
            class_1_MidtermLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            class_1_MidtermLabel.Location = new System.Drawing.Point(106, 349);
            class_1_MidtermLabel.Name = "class_1_MidtermLabel";
            class_1_MidtermLabel.Size = new System.Drawing.Size(334, 46);
            class_1_MidtermLabel.TabIndex = 9;
            class_1_MidtermLabel.Text = "Class 1 Midterm:";
            // 
            // class_2_MidtermLabel
            // 
            class_2_MidtermLabel.AutoSize = true;
            class_2_MidtermLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            class_2_MidtermLabel.Location = new System.Drawing.Point(106, 419);
            class_2_MidtermLabel.Name = "class_2_MidtermLabel";
            class_2_MidtermLabel.Size = new System.Drawing.Size(334, 46);
            class_2_MidtermLabel.TabIndex = 11;
            class_2_MidtermLabel.Text = "Class 2 Midterm:";
            // 
            // class_3_MidtermLabel
            // 
            class_3_MidtermLabel.AutoSize = true;
            class_3_MidtermLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            class_3_MidtermLabel.Location = new System.Drawing.Point(106, 489);
            class_3_MidtermLabel.Name = "class_3_MidtermLabel";
            class_3_MidtermLabel.Size = new System.Drawing.Size(334, 46);
            class_3_MidtermLabel.TabIndex = 13;
            class_3_MidtermLabel.Text = "Class 3 Midterm:";
            // 
            // class_4_MidtermLabel
            // 
            class_4_MidtermLabel.AutoSize = true;
            class_4_MidtermLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            class_4_MidtermLabel.Location = new System.Drawing.Point(106, 559);
            class_4_MidtermLabel.Name = "class_4_MidtermLabel";
            class_4_MidtermLabel.Size = new System.Drawing.Size(334, 46);
            class_4_MidtermLabel.TabIndex = 15;
            class_4_MidtermLabel.Text = "Class 4 Midterm:";
            // 
            // class_1_FinalsLabel
            // 
            class_1_FinalsLabel.AutoSize = true;
            class_1_FinalsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            class_1_FinalsLabel.Location = new System.Drawing.Point(106, 629);
            class_1_FinalsLabel.Name = "class_1_FinalsLabel";
            class_1_FinalsLabel.Size = new System.Drawing.Size(296, 46);
            class_1_FinalsLabel.TabIndex = 17;
            class_1_FinalsLabel.Text = "Class 1 Finals:";
            // 
            // class_2_FinalsLabel
            // 
            class_2_FinalsLabel.AutoSize = true;
            class_2_FinalsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            class_2_FinalsLabel.Location = new System.Drawing.Point(106, 699);
            class_2_FinalsLabel.Name = "class_2_FinalsLabel";
            class_2_FinalsLabel.Size = new System.Drawing.Size(296, 46);
            class_2_FinalsLabel.TabIndex = 19;
            class_2_FinalsLabel.Text = "Class 2 Finals:";
            // 
            // class_3_FinalsLabel
            // 
            class_3_FinalsLabel.AutoSize = true;
            class_3_FinalsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            class_3_FinalsLabel.Location = new System.Drawing.Point(106, 769);
            class_3_FinalsLabel.Name = "class_3_FinalsLabel";
            class_3_FinalsLabel.Size = new System.Drawing.Size(296, 46);
            class_3_FinalsLabel.TabIndex = 21;
            class_3_FinalsLabel.Text = "Class 3 Finals:";
            // 
            // class_4_FinalsLabel
            // 
            class_4_FinalsLabel.AutoSize = true;
            class_4_FinalsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            class_4_FinalsLabel.Location = new System.Drawing.Point(106, 839);
            class_4_FinalsLabel.Name = "class_4_FinalsLabel";
            class_4_FinalsLabel.Size = new System.Drawing.Size(296, 46);
            class_4_FinalsLabel.TabIndex = 23;
            class_4_FinalsLabel.Text = "Class 4 Finals:";
            // 
            // gPALabel
            // 
            gPALabel.AutoSize = true;
            gPALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gPALabel.Location = new System.Drawing.Point(106, 909);
            gPALabel.Name = "gPALabel";
            gPALabel.Size = new System.Drawing.Size(120, 46);
            gPALabel.TabIndex = 25;
            gPALabel.Text = "GPA:";
            // 
            // school_IDTextBox
            // 
            this.school_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInformationBindingSource, "School ID", true));
            this.school_IDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.school_IDTextBox.Location = new System.Drawing.Point(501, 62);
            this.school_IDTextBox.Name = "school_IDTextBox";
            this.school_IDTextBox.ReadOnly = true;
            this.school_IDTextBox.Size = new System.Drawing.Size(411, 53);
            this.school_IDTextBox.TabIndex = 2;
            this.school_IDTextBox.TextChanged += new System.EventHandler(this.school_IDTextBox_TextChanged);
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
            // first_NameTextBox
            // 
            this.first_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInformationBindingSource, "first_Name", true));
            this.first_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_NameTextBox.Location = new System.Drawing.Point(501, 132);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.ReadOnly = true;
            this.first_NameTextBox.Size = new System.Drawing.Size(411, 53);
            this.first_NameTextBox.TabIndex = 4;
            this.first_NameTextBox.TextChanged += new System.EventHandler(this.first_NameTextBox_TextChanged);
            // 
            // last_NameTextBox
            // 
            this.last_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInformationBindingSource, "last_Name", true));
            this.last_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_NameTextBox.Location = new System.Drawing.Point(501, 202);
            this.last_NameTextBox.Name = "last_NameTextBox";
            this.last_NameTextBox.ReadOnly = true;
            this.last_NameTextBox.Size = new System.Drawing.Size(411, 53);
            this.last_NameTextBox.TabIndex = 6;
            // 
            // course_TakenTextBox
            // 
            this.course_TakenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInformationBindingSource, "Course Taken", true));
            this.course_TakenTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course_TakenTextBox.Location = new System.Drawing.Point(501, 272);
            this.course_TakenTextBox.Name = "course_TakenTextBox";
            this.course_TakenTextBox.ReadOnly = true;
            this.course_TakenTextBox.Size = new System.Drawing.Size(411, 53);
            this.course_TakenTextBox.TabIndex = 8;
            // 
            // class_1_MidtermTextBox
            // 
            this.class_1_MidtermTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInformationBindingSource, "Class 1 Midterm", true));
            this.class_1_MidtermTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_1_MidtermTextBox.Location = new System.Drawing.Point(501, 342);
            this.class_1_MidtermTextBox.Name = "class_1_MidtermTextBox";
            this.class_1_MidtermTextBox.ReadOnly = true;
            this.class_1_MidtermTextBox.Size = new System.Drawing.Size(411, 53);
            this.class_1_MidtermTextBox.TabIndex = 10;
            // 
            // class_2_MidtermTextBox
            // 
            this.class_2_MidtermTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInformationBindingSource, "Class 2 Midterm", true));
            this.class_2_MidtermTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_2_MidtermTextBox.Location = new System.Drawing.Point(501, 412);
            this.class_2_MidtermTextBox.Name = "class_2_MidtermTextBox";
            this.class_2_MidtermTextBox.ReadOnly = true;
            this.class_2_MidtermTextBox.Size = new System.Drawing.Size(411, 53);
            this.class_2_MidtermTextBox.TabIndex = 12;
            // 
            // class_3_MidtermTextBox
            // 
            this.class_3_MidtermTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInformationBindingSource, "Class 3 Midterm", true));
            this.class_3_MidtermTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_3_MidtermTextBox.Location = new System.Drawing.Point(501, 482);
            this.class_3_MidtermTextBox.Name = "class_3_MidtermTextBox";
            this.class_3_MidtermTextBox.ReadOnly = true;
            this.class_3_MidtermTextBox.Size = new System.Drawing.Size(411, 53);
            this.class_3_MidtermTextBox.TabIndex = 14;
            // 
            // class_4_MidtermTextBox
            // 
            this.class_4_MidtermTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInformationBindingSource, "Class 4 Midterm", true));
            this.class_4_MidtermTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_4_MidtermTextBox.Location = new System.Drawing.Point(501, 552);
            this.class_4_MidtermTextBox.Name = "class_4_MidtermTextBox";
            this.class_4_MidtermTextBox.ReadOnly = true;
            this.class_4_MidtermTextBox.Size = new System.Drawing.Size(411, 53);
            this.class_4_MidtermTextBox.TabIndex = 16;
            // 
            // class_1_FinalsTextBox
            // 
            this.class_1_FinalsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInformationBindingSource, "Class 1 Finals", true));
            this.class_1_FinalsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_1_FinalsTextBox.Location = new System.Drawing.Point(501, 622);
            this.class_1_FinalsTextBox.Name = "class_1_FinalsTextBox";
            this.class_1_FinalsTextBox.ReadOnly = true;
            this.class_1_FinalsTextBox.Size = new System.Drawing.Size(411, 53);
            this.class_1_FinalsTextBox.TabIndex = 18;
            // 
            // class_2_FinalsTextBox
            // 
            this.class_2_FinalsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInformationBindingSource, "Class 2 Finals", true));
            this.class_2_FinalsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_2_FinalsTextBox.Location = new System.Drawing.Point(501, 692);
            this.class_2_FinalsTextBox.Name = "class_2_FinalsTextBox";
            this.class_2_FinalsTextBox.ReadOnly = true;
            this.class_2_FinalsTextBox.Size = new System.Drawing.Size(411, 53);
            this.class_2_FinalsTextBox.TabIndex = 20;
            // 
            // class_3_FinalsTextBox
            // 
            this.class_3_FinalsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInformationBindingSource, "Class 3 Finals", true));
            this.class_3_FinalsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_3_FinalsTextBox.Location = new System.Drawing.Point(501, 762);
            this.class_3_FinalsTextBox.Name = "class_3_FinalsTextBox";
            this.class_3_FinalsTextBox.ReadOnly = true;
            this.class_3_FinalsTextBox.Size = new System.Drawing.Size(411, 53);
            this.class_3_FinalsTextBox.TabIndex = 22;
            // 
            // class_4_FinalsTextBox
            // 
            this.class_4_FinalsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInformationBindingSource, "Class 4 Finals", true));
            this.class_4_FinalsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_4_FinalsTextBox.Location = new System.Drawing.Point(501, 832);
            this.class_4_FinalsTextBox.Name = "class_4_FinalsTextBox";
            this.class_4_FinalsTextBox.ReadOnly = true;
            this.class_4_FinalsTextBox.Size = new System.Drawing.Size(411, 53);
            this.class_4_FinalsTextBox.TabIndex = 24;
            // 
            // gPATextBox
            // 
            this.gPATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInformationBindingSource, "GPA", true));
            this.gPATextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gPATextBox.Location = new System.Drawing.Point(501, 902);
            this.gPATextBox.Name = "gPATextBox";
            this.gPATextBox.ReadOnly = true;
            this.gPATextBox.Size = new System.Drawing.Size(411, 53);
            this.gPATextBox.TabIndex = 26;
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(501, 1028);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(411, 81);
            this.logoutButton.TabIndex = 27;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
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
            // StudentViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 1183);
            this.Controls.Add(this.logoutButton);
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
            this.Name = "StudentViewForm";
            this.Text = "Blackboard 3.0 Student Information";
            this.Load += new System.EventHandler(this.StudentViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentInformationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoDataSet)).EndInit();
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
        private System.Windows.Forms.Button logoutButton;
    }
}