namespace WinFormsAppParcoVeicoli
{
    partial class FormFlotta
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
            buttonVisualizzaFlotta = new Button();
            buttonRimuoviVeicolo = new Button();
            buttonCostoTotale = new Button();
            dataGridViewVeicoli = new DataGridView();
            Dettagli = new DataGridViewButtonColumn();
            labelTarga = new Label();
            textBoxTarga = new TextBox();
            labelMarca = new Label();
            textBoxMarca = new TextBox();
            labelModello = new Label();
            textBoxModello = new TextBox();
            labelChilometri = new Label();
            textBoxChilometri = new TextBox();
            labelNumeroPorte = new Label();
            textBoxNumeroPorte = new TextBox();
            buttonInserisciAuto = new Button();
            labelCapacitaCarico = new Label();
            textBoxCapacitaCarico = new TextBox();
            buttonInserisciCamion = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVeicoli).BeginInit();
            SuspendLayout();
            // 
            // buttonVisualizzaFlotta
            // 
            buttonVisualizzaFlotta.Location = new Point(12, 23);
            buttonVisualizzaFlotta.Name = "buttonVisualizzaFlotta";
            buttonVisualizzaFlotta.Size = new Size(176, 23);
            buttonVisualizzaFlotta.TabIndex = 0;
            buttonVisualizzaFlotta.Text = "Visualizza flotta";
            buttonVisualizzaFlotta.UseVisualStyleBackColor = true;
            buttonVisualizzaFlotta.Click += buttonVisualizzaFlotta_Click;
            // 
            // buttonRimuoviVeicolo
            // 
            buttonRimuoviVeicolo.Location = new Point(12, 63);
            buttonRimuoviVeicolo.Name = "buttonRimuoviVeicolo";
            buttonRimuoviVeicolo.Size = new Size(176, 23);
            buttonRimuoviVeicolo.TabIndex = 1;
            buttonRimuoviVeicolo.Text = "Rimuovi veicolo";
            buttonRimuoviVeicolo.UseVisualStyleBackColor = true;
            buttonRimuoviVeicolo.Click += buttonRimuoviVeicolo_Click;
            // 
            // buttonCostoTotale
            // 
            buttonCostoTotale.Location = new Point(12, 103);
            buttonCostoTotale.Name = "buttonCostoTotale";
            buttonCostoTotale.Size = new Size(176, 23);
            buttonCostoTotale.TabIndex = 2;
            buttonCostoTotale.Text = "Costo totale manutenzione";
            buttonCostoTotale.UseVisualStyleBackColor = true;
            buttonCostoTotale.Click += buttonCostoTotale_Click;
            // 
            // dataGridViewVeicoli
            // 
            dataGridViewVeicoli.AllowUserToAddRows = false;
            dataGridViewVeicoli.AllowUserToDeleteRows = false;
            dataGridViewVeicoli.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewVeicoli.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVeicoli.Columns.AddRange(new DataGridViewColumn[] { Dettagli });
            dataGridViewVeicoli.Location = new Point(194, 23);
            dataGridViewVeicoli.MultiSelect = false;
            dataGridViewVeicoli.Name = "dataGridViewVeicoli";
            dataGridViewVeicoli.ReadOnly = true;
            dataGridViewVeicoli.RowHeadersVisible = false;
            dataGridViewVeicoli.RowHeadersWidth = 51;
            dataGridViewVeicoli.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewVeicoli.Size = new Size(593, 195);
            dataGridViewVeicoli.TabIndex = 3;
            dataGridViewVeicoli.CellContentClick += dataGridViewVeicoli_CellContentClick;
            // 
            // Dettagli
            // 
            Dettagli.FillWeight = 60F;
            Dettagli.HeaderText = "Dettagli";
            Dettagli.MinimumWidth = 6;
            Dettagli.Name = "Dettagli";
            Dettagli.ReadOnly = true;
            Dettagli.Text = "Apri";
            Dettagli.UseColumnTextForButtonValue = true;
            // 
            // labelTarga
            // 
            labelTarga.AutoSize = true;
            labelTarga.Location = new Point(12, 240);
            labelTarga.Name = "labelTarga";
            labelTarga.Size = new Size(36, 15);
            labelTarga.TabIndex = 4;
            labelTarga.Text = "Targa";
            // 
            // textBoxTarga
            // 
            textBoxTarga.Location = new Point(12, 259);
            textBoxTarga.Margin = new Padding(3, 2, 3, 2);
            textBoxTarga.Name = "textBoxTarga";
            textBoxTarga.Size = new Size(110, 23);
            textBoxTarga.TabIndex = 5;
            // 
            // labelMarca
            // 
            labelMarca.AutoSize = true;
            labelMarca.Location = new Point(140, 240);
            labelMarca.Name = "labelMarca";
            labelMarca.Size = new Size(40, 15);
            labelMarca.TabIndex = 6;
            labelMarca.Text = "Marca";
            // 
            // textBoxMarca
            // 
            textBoxMarca.Location = new Point(140, 259);
            textBoxMarca.Margin = new Padding(3, 2, 3, 2);
            textBoxMarca.Name = "textBoxMarca";
            textBoxMarca.Size = new Size(110, 23);
            textBoxMarca.TabIndex = 7;
            // 
            // labelModello
            // 
            labelModello.AutoSize = true;
            labelModello.Location = new Point(268, 240);
            labelModello.Name = "labelModello";
            labelModello.Size = new Size(51, 15);
            labelModello.TabIndex = 8;
            labelModello.Text = "Modello";
            // 
            // textBoxModello
            // 
            textBoxModello.Location = new Point(268, 259);
            textBoxModello.Margin = new Padding(3, 2, 3, 2);
            textBoxModello.Name = "textBoxModello";
            textBoxModello.Size = new Size(110, 23);
            textBoxModello.TabIndex = 9;
            // 
            // labelChilometri
            // 
            labelChilometri.AutoSize = true;
            labelChilometri.Location = new Point(396, 240);
            labelChilometri.Name = "labelChilometri";
            labelChilometri.Size = new Size(63, 15);
            labelChilometri.TabIndex = 10;
            labelChilometri.Text = "Chilometri";
            // 
            // textBoxChilometri
            // 
            textBoxChilometri.Location = new Point(396, 259);
            textBoxChilometri.Margin = new Padding(3, 2, 3, 2);
            textBoxChilometri.Name = "textBoxChilometri";
            textBoxChilometri.Size = new Size(110, 23);
            textBoxChilometri.TabIndex = 11;
            // 
            // labelNumeroPorte
            // 
            labelNumeroPorte.AutoSize = true;
            labelNumeroPorte.Location = new Point(12, 300);
            labelNumeroPorte.Name = "labelNumeroPorte";
            labelNumeroPorte.Size = new Size(82, 15);
            labelNumeroPorte.TabIndex = 12;
            labelNumeroPorte.Text = "Numero porte";
            // 
            // textBoxNumeroPorte
            // 
            textBoxNumeroPorte.Location = new Point(12, 319);
            textBoxNumeroPorte.Margin = new Padding(3, 2, 3, 2);
            textBoxNumeroPorte.Name = "textBoxNumeroPorte";
            textBoxNumeroPorte.Size = new Size(110, 23);
            textBoxNumeroPorte.TabIndex = 13;
            // 
            // buttonInserisciAuto
            // 
            buttonInserisciAuto.Location = new Point(140, 318);
            buttonInserisciAuto.Margin = new Padding(3, 2, 3, 2);
            buttonInserisciAuto.Name = "buttonInserisciAuto";
            buttonInserisciAuto.Size = new Size(122, 22);
            buttonInserisciAuto.TabIndex = 14;
            buttonInserisciAuto.Text = "Inserisci Auto";
            buttonInserisciAuto.UseVisualStyleBackColor = true;
            buttonInserisciAuto.Click += buttonInserisciAuto_Click;
            // 
            // labelCapacitaCarico
            // 
            labelCapacitaCarico.AutoSize = true;
            labelCapacitaCarico.Location = new Point(396, 300);
            labelCapacitaCarico.Name = "labelCapacitaCarico";
            labelCapacitaCarico.Size = new Size(116, 15);
            labelCapacitaCarico.TabIndex = 15;
            labelCapacitaCarico.Text = "Capacità di carico (t)";
            // 
            // textBoxCapacitaCarico
            // 
            textBoxCapacitaCarico.Location = new Point(396, 319);
            textBoxCapacitaCarico.Margin = new Padding(3, 2, 3, 2);
            textBoxCapacitaCarico.Name = "textBoxCapacitaCarico";
            textBoxCapacitaCarico.Size = new Size(110, 23);
            textBoxCapacitaCarico.TabIndex = 16;
            // 
            // buttonInserisciCamion
            // 
            buttonInserisciCamion.Location = new Point(523, 318);
            buttonInserisciCamion.Margin = new Padding(3, 2, 3, 2);
            buttonInserisciCamion.Name = "buttonInserisciCamion";
            buttonInserisciCamion.Size = new Size(122, 22);
            buttonInserisciCamion.TabIndex = 17;
            buttonInserisciCamion.Text = "Inserisci Camion";
            buttonInserisciCamion.UseVisualStyleBackColor = true;
            buttonInserisciCamion.Click += buttonInserisciCamion_Click;
            // 
            // FormFlotta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 360);
            Controls.Add(buttonInserisciCamion);
            Controls.Add(textBoxCapacitaCarico);
            Controls.Add(labelCapacitaCarico);
            Controls.Add(buttonInserisciAuto);
            Controls.Add(textBoxNumeroPorte);
            Controls.Add(labelNumeroPorte);
            Controls.Add(textBoxChilometri);
            Controls.Add(labelChilometri);
            Controls.Add(textBoxModello);
            Controls.Add(labelModello);
            Controls.Add(textBoxMarca);
            Controls.Add(labelMarca);
            Controls.Add(textBoxTarga);
            Controls.Add(labelTarga);
            Controls.Add(dataGridViewVeicoli);
            Controls.Add(buttonCostoTotale);
            Controls.Add(buttonRimuoviVeicolo);
            Controls.Add(buttonVisualizzaFlotta);
            Name = "FormFlotta";
            Text = "Parco veicoli";
            ((System.ComponentModel.ISupportInitialize)dataGridViewVeicoli).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonVisualizzaFlotta;
        private Button buttonRimuoviVeicolo;
        private Button buttonCostoTotale;
        private DataGridView dataGridViewVeicoli;
        private DataGridViewButtonColumn Dettagli;
        private Label labelTarga;
        private TextBox textBoxTarga;
        private Label labelMarca;
        private TextBox textBoxMarca;
        private Label labelModello;
        private TextBox textBoxModello;
        private Label labelChilometri;
        private TextBox textBoxChilometri;
        private Label labelNumeroPorte;
        private TextBox textBoxNumeroPorte;
        private Button buttonInserisciAuto;
        private Label labelCapacitaCarico;
        private TextBox textBoxCapacitaCarico;
        private Button buttonInserisciCamion;
    }
}
