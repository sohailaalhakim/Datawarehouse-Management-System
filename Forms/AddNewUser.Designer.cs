namespace Project.Forms
{
    partial class AddNewUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.confirmPasswordTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveUserBTN = new System.Windows.Forms.Button();
            this.NewUserImage = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NewUserImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(232, 128);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(194, 22);
            this.passwordTxt.TabIndex = 3;
            this.passwordTxt.UseSystemPasswordChar = true;
            // 
            // userNameTxt
            // 
            this.userNameTxt.Location = new System.Drawing.Point(232, 79);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(194, 22);
            this.userNameTxt.TabIndex = 4;
            // 
            // confirmPasswordTxt
            // 
            this.confirmPasswordTxt.Location = new System.Drawing.Point(232, 177);
            this.confirmPasswordTxt.Name = "confirmPasswordTxt";
            this.confirmPasswordTxt.Size = new System.Drawing.Size(194, 22);
            this.confirmPasswordTxt.TabIndex = 5;
            this.confirmPasswordTxt.UseSystemPasswordChar = true;
            this.confirmPasswordTxt.TextChanged += new System.EventHandler(this.confirmPasswordTxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confirm Password";
            // 
            // SaveUserBTN
            // 
            this.SaveUserBTN.BackColor = System.Drawing.Color.LightGray;
            this.SaveUserBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveUserBTN.Location = new System.Drawing.Point(227, 337);
            this.SaveUserBTN.Name = "SaveUserBTN";
            this.SaveUserBTN.Size = new System.Drawing.Size(75, 38);
            this.SaveUserBTN.TabIndex = 7;
            this.SaveUserBTN.Text = "Save";
            this.SaveUserBTN.UseVisualStyleBackColor = false;
            this.SaveUserBTN.Click += new System.EventHandler(this.LoginBTN_Click);
            // 
            // NewUserImage
            // 
            this.NewUserImage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NewUserImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NewUserImage.Location = new System.Drawing.Point(227, 229);
            this.NewUserImage.Name = "NewUserImage";
            this.NewUserImage.Size = new System.Drawing.Size(199, 85);
            this.NewUserImage.TabIndex = 8;
            this.NewUserImage.TabStop = false;
            this.NewUserImage.Click += new System.EventHandler(this.NewUserImage_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Image";
            // 
            // AddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(576, 414);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NewUserImage);
            this.Controls.Add(this.SaveUserBTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.confirmPasswordTxt);
            this.Controls.Add(this.userNameTxt);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddNewUser";
            this.Text = "AddNewUser";
            this.Load += new System.EventHandler(this.AddNewUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NewUserImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.TextBox userNameTxt;
        private System.Windows.Forms.TextBox confirmPasswordTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveUserBTN;
        private System.Windows.Forms.PictureBox NewUserImage;
        private System.Windows.Forms.Label label4;
    }
}