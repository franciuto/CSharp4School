namespace WinFormsAppUtenti
{
    partial class FormUtenti
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonLogin = new Button();
            dataGridViewUtenti = new DataGridView();
            labelCognome = new Label();
            textBoxCognome = new TextBox();
            labelNome = new Label();
            textBoxNome = new TextBox();
            labelPassword = new Label();
            textBoxPassword = new TextBox();
            buttonInserisciUtente = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUtenti).BeginInit();
            SuspendLayout();
            //
            // buttonLogin
            //
            buttonLogin.Location = new Point(20, 17);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(145, 30);
            buttonLogin.TabIndex = 0;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            //
            // dataGridViewUtenti
            //
            dataGridViewUtenti.AllowUserToAddRows = false;
            dataGridViewUtenti.AllowUserToDeleteRows = false;
            dataGridViewUtenti.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewUtenti.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUtenti.BackgroundColor = SystemColors.Window;
            dataGridViewUtenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUtenti.Location = new Point(20, 65);
            dataGridViewUtenti.MultiSelect = false;
            dataGridViewUtenti.Name = "dataGridViewUtenti";
            dataGridViewUtenti.ReadOnly = true;
            dataGridViewUtenti.RowHeadersVisible = false;
            dataGridViewUtenti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUtenti.Size = new Size(720, 200);
            dataGridViewUtenti.TabIndex = 1;
            //
            // labelCognome
            //
            labelCognome.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelCognome.AutoSize = true;
            labelCognome.Location = new Point(20, 285);
            labelCognome.Name = "labelCognome";
            labelCognome.Size = new Size(57, 15);
            labelCognome.TabIndex = 2;
            labelCognome.Text = "Cognome";
            //
            // textBoxCognome
            //
            textBoxCognome.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxCognome.Location = new Point(20, 305);
            textBoxCognome.Name = "textBoxCognome";
            textBoxCognome.Size = new Size(150, 23);
            textBoxCognome.TabIndex = 3;
            //
            // labelNome
            //
            labelNome.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelNome.AutoSize = true;
            labelNome.Location = new Point(190, 285);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(36, 15);
            labelNome.TabIndex = 4;
            labelNome.Text = "Nome";
            //
            // textBoxNome
            //
            textBoxNome.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxNome.Location = new Point(190, 305);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(150, 23);
            textBoxNome.TabIndex = 5;
            //
            // labelPassword
            //
            labelPassword.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(360, 285);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(57, 15);
            labelPassword.TabIndex = 6;
            labelPassword.Text = "Password";
            //
            // textBoxPassword
            //
            textBoxPassword.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxPassword.Location = new Point(360, 305);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(150, 23);
            textBoxPassword.TabIndex = 7;
            //
            // buttonInserisciUtente
            //
            buttonInserisciUtente.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonInserisciUtente.Location = new Point(530, 302);
            buttonInserisciUtente.Name = "buttonInserisciUtente";
            buttonInserisciUtente.Size = new Size(145, 30);
            buttonInserisciUtente.TabIndex = 8;
            buttonInserisciUtente.Text = "Inserisci utente";
            buttonInserisciUtente.UseVisualStyleBackColor = true;
            buttonInserisciUtente.Click += buttonInserisciUtente_Click;
            //
            // FormUtenti
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 350);
            Controls.Add(buttonInserisciUtente);
            Controls.Add(textBoxPassword);
            Controls.Add(labelPassword);
            Controls.Add(textBoxNome);
            Controls.Add(labelNome);
            Controls.Add(textBoxCognome);
            Controls.Add(labelCognome);
            Controls.Add(dataGridViewUtenti);
            Controls.Add(buttonLogin);
            MinimumSize = new Size(720, 390);
            Name = "FormUtenti";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Utenti";
            ((System.ComponentModel.ISupportInitialize)dataGridViewUtenti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogin;
        private DataGridView dataGridViewUtenti;
        private Label labelCognome;
        private TextBox textBoxCognome;
        private Label labelNome;
        private TextBox textBoxNome;
        private Label labelPassword;
        private TextBox textBoxPassword;
        private Button buttonInserisciUtente;
    }
}
