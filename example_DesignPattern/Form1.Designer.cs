
namespace example_FactoryMethodDesignPattern
{
    partial class Form1
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
            this.UserName = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Reg = new System.Windows.Forms.Button();
            this.Reg_User = new System.Windows.Forms.Button();
            this.admin_user = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(294, 64);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(282, 22);
            this.UserName.TabIndex = 0;
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(294, 141);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(282, 22);
            this.Name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(294, 219);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(282, 22);
            this.Password.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // Btn_Reg
            // 
            this.Btn_Reg.Location = new System.Drawing.Point(303, 328);
            this.Btn_Reg.Name = "Btn_Reg";
            this.Btn_Reg.Size = new System.Drawing.Size(208, 49);
            this.Btn_Reg.TabIndex = 6;
            this.Btn_Reg.Text = "New User";
            this.Btn_Reg.UseVisualStyleBackColor = true;
            this.Btn_Reg.Click += new System.EventHandler(this.Btn_Reg_Click);
            // 
            // Reg_User
            // 
            this.Reg_User.Location = new System.Drawing.Point(51, 328);
            this.Reg_User.Name = "Reg_User";
            this.Reg_User.Size = new System.Drawing.Size(208, 49);
            this.Reg_User.TabIndex = 7;
            this.Reg_User.Text = "Reg User";
            this.Reg_User.UseVisualStyleBackColor = true;
            this.Reg_User.Click += new System.EventHandler(this.Reg_User_Click);
            // 
            // admin_user
            // 
            this.admin_user.Location = new System.Drawing.Point(549, 328);
            this.admin_user.Name = "admin_user";
            this.admin_user.Size = new System.Drawing.Size(208, 49);
            this.admin_user.TabIndex = 8;
            this.admin_user.Text = "admin";
            this.admin_user.UseVisualStyleBackColor = true;
            this.admin_user.Click += new System.EventHandler(this.admin_user_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.admin_user);
            this.Controls.Add(this.Reg_User);
            this.Controls.Add(this.Btn_Reg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.UserName);

            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Reg;
        private System.Windows.Forms.Button Reg_User;
        private System.Windows.Forms.Button admin_user;
    }
}

