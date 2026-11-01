namespace WinFormsAppUtenti
{
    partial class FormLogin
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
            labelUser = new Label();
            textBoxUser = new TextBox();
            labelPassword = new Label();
            textBoxPassword = new TextBox();
            buttonAccedi = new Button();
            labelNome = new Label();
            labelCognome = new Label();
            labelEmail = new Label();
            SuspendLayout();
            //
            // labelUser
            //
            labelUser.AutoSize = true;
            labelUser.Location = new Point(20, 24);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(33, 15);
            labelUser.TabIndex = 0;
            labelUser.Text = "User:";
            //
            // textBoxUser
            //
            textBoxUser.Location = new Point(100, 20);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(210, 23);
            textBoxUser.TabIndex = 1;
            //
            // labelPassword
            //
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(20, 59);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(60, 15);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Password:";
            //
            // textBoxPassword
            //
            textBoxPassword.Location = new Point(100, 55);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(210, 23);
            textBoxPassword.TabIndex = 3;
            textBoxPassword.UseSystemPasswordChar = true;
            //
            // buttonAccedi
            //
            buttonAccedi.Location = new Point(100, 90);
            buttonAccedi.Name = "buttonAccedi";
            buttonAccedi.Size = new Size(100, 30);
            buttonAccedi.TabIndex = 4;
            buttonAccedi.Text = "Accedi";
            buttonAccedi.UseVisualStyleBackColor = true;
            buttonAccedi.Click += buttonAccedi_Click;
            //
            // labelNome
            //
            labelNome.AutoSize = true;
            labelNome.Location = new Point(20, 140);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(55, 15);
            labelNome.TabIndex = 5;
            labelNome.Text = "Nome: —";
            //
            // labelCognome
            //
            labelCognome.AutoSize = true;
            labelCognome.Location = new Point(20, 165);
            labelCognome.Name = "labelCognome";
            labelCognome.Size = new Size(76, 15);
            labelCognome.TabIndex = 6;
            labelCognome.Text = "Cognome: —";
            //
            // labelEmail
            //
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(20, 190);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(53, 15);
            labelEmail.TabIndex = 7;
            labelEmail.Text = "Email: —";
            //
            // FormLogin
            //
            AcceptButton = buttonAccedi;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 220);
            Controls.Add(labelEmail);
            Controls.Add(labelCognome);
            Controls.Add(labelNome);
            Controls.Add(buttonAccedi);
            Controls.Add(textBoxPassword);
            Controls.Add(labelPassword);
            Controls.Add(textBoxUser);
            Controls.Add(labelUser);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUser;
        private TextBox textBoxUser;
        private Label labelPassword;
        private TextBox textBoxPassword;
        private Button buttonAccedi;
        private Label labelNome;
        private Label labelCognome;
        private Label labelEmail;
    }
}
