namespace WindowsFormsApplication1
{
    partial class loginWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginWindow));
            this.loginButton = new System.Windows.Forms.Button();
            this.UserButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginBoxLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(472, 318);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(108, 38);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // UserButton
            // 
            this.UserButton.Location = new System.Drawing.Point(472, 362);
            this.UserButton.Name = "UserButton";
            this.UserButton.Size = new System.Drawing.Size(108, 38);
            this.UserButton.TabIndex = 3;
            this.UserButton.Text = "Create User";
            this.UserButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F);
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(578, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome to the Weather Event Manager!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(124, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Please login or create a user profile. ";
            // 
            // LoginBoxLabel
            // 
            this.LoginBoxLabel.AutoSize = true;
            this.LoginBoxLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoginBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LoginBoxLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LoginBoxLabel.Location = new System.Drawing.Point(87, 107);
            this.LoginBoxLabel.Name = "LoginBoxLabel";
            this.LoginBoxLabel.Size = new System.Drawing.Size(77, 17);
            this.LoginBoxLabel.TabIndex = 6;
            this.LoginBoxLabel.Text = "Username:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(170, 106);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(261, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // loginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(590, 412);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LoginBoxLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserButton);
            this.Controls.Add(this.loginButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "loginWindow";
            this.Text = "loginWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button UserButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LoginBoxLabel;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}