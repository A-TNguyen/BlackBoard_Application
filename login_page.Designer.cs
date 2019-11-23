namespace Blackboard_Application
{
    partial class login_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_page));
            this.login_input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // login_input
            // 
            this.login_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_input.Location = new System.Drawing.Point(255, 193);
            this.login_input.MaxLength = 20;
            this.login_input.Name = "login_input";
            this.login_input.Size = new System.Drawing.Size(469, 83);
            this.login_input.TabIndex = 0;
            this.login_input.TextChanged += new System.EventHandler(this.login_input_TextChanged);
            // 
            // login_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 912);
            this.Controls.Add(this.login_input);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login_page";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login_input;
    }
}