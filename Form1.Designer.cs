namespace Blackboard_Application
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.login_succesful_logo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_succesful_logo
            // 
            this.login_succesful_logo.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_succesful_logo.Location = new System.Drawing.Point(254, 315);
            this.login_succesful_logo.Name = "login_succesful_logo";
            this.login_succesful_logo.Size = new System.Drawing.Size(765, 217);
            this.login_succesful_logo.TabIndex = 0;
            this.login_succesful_logo.Text = "Login Successful";
            this.login_succesful_logo.Click += new System.EventHandler(this.label1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 847);
            this.Controls.Add(this.login_succesful_logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login | Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label login_succesful_logo;
    }
}

