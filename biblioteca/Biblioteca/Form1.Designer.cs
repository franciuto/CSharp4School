namespace BibliotecaApp
{
    partial class Form1
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
            cmbTipo = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtTitolo = new TextBox();
            label5 = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            textBox2 = new TextBox();
            btnAdd = new Button();
            lblSpecific = new Label();
            txtboxSpecific = new TextBox();
            dataGridView1 = new DataGridView();
            lblIncasso = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cmbTipo
            // 
            cmbTipo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(12, 105);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(121, 23);
            cmbTipo.TabIndex = 0;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(299, 19);
            label1.Name = "label1";
            label1.Size = new Size(165, 25);
            label1.TabIndex = 1;
            label1.Text = "Gestore Biblioteca";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(135, 21);
            label2.TabIndex = 2;
            label2.Text = "Inserisci elemento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8F);
            label3.Location = new Point(12, 89);
            label3.Name = "label3";
            label3.Size = new Size(33, 13);
            label3.TabIndex = 3;
            label3.Text = "Tipo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F);
            label4.Location = new Point(139, 89);
            label4.Name = "label4";
            label4.Size = new Size(40, 13);
            label4.TabIndex = 4;
            label4.Text = "Titolo:";
            // 
            // txtTitolo
            // 
            txtTitolo.Location = new Point(139, 105);
            txtTitolo.Name = "txtTitolo";
            txtTitolo.Size = new Size(100, 23);
            txtTitolo.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8F);
            label5.Location = new Point(243, 89);
            label5.Name = "label5";
            label5.Size = new Size(45, 13);
            label5.TabIndex = 6;
            label5.Text = "Codice:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(245, 105);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(43, 23);
            textBox1.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8F);
            label6.Location = new Point(294, 89);
            label6.Name = "label6";
            label6.Size = new Size(98, 13);
            label6.TabIndex = 8;
            label6.Text = "Giorni di prestito:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(294, 105);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(98, 23);
            textBox2.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(514, 104);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Aggiungi";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblSpecific
            // 
            lblSpecific.AutoSize = true;
            lblSpecific.Font = new Font("Segoe UI", 8F);
            lblSpecific.Location = new Point(398, 89);
            lblSpecific.Name = "lblSpecific";
            lblSpecific.Size = new Size(0, 13);
            lblSpecific.TabIndex = 11;
            // 
            // txtboxSpecific
            // 
            txtboxSpecific.Location = new Point(398, 105);
            txtboxSpecific.Name = "txtboxSpecific";
            txtboxSpecific.Size = new Size(98, 23);
            txtboxSpecific.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 164);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(767, 150);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lblIncasso
            // 
            lblIncasso.AutoSize = true;
            lblIncasso.Font = new Font("Segoe UI", 8F);
            lblIncasso.Location = new Point(12, 341);
            lblIncasso.Name = "lblIncasso";
            lblIncasso.Size = new Size(81, 13);
            lblIncasso.TabIndex = 14;
            lblIncasso.Text = "Incasso totale:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(791, 446);
            Controls.Add(lblIncasso);
            Controls.Add(dataGridView1);
            Controls.Add(txtboxSpecific);
            Controls.Add(lblSpecific);
            Controls.Add(btnAdd);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(txtTitolo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbTipo);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cmbTipo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtTitolo;
        private Label label5;
        private TextBox textBox1;
        private Label label6;
        private TextBox textBox2;
        private Button btnAdd;
        private Label lblSpecific;
        private TextBox txtboxSpecific;
        private DataGridView dataGridView1;
        private Label lblIncasso;
    }
}
