namespace WinFormsAppAlbum
{
    partial class FormAlbum
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
            labelCategoria = new Label();
            comboBoxCategoria = new ComboBox();
            buttonMostraAlbum = new Button();
            buttonCalcolaStatistiche = new Button();
            dataGridViewAlbum = new DataGridView();
            labelAlbumPiuVecchio = new Label();
            labelMediaDurata = new Label();
            labelBrani = new Label();
            dataGridViewBrani = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlbum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBrani).BeginInit();
            SuspendLayout();
            //
            // labelCategoria
            //
            labelCategoria.AutoSize = true;
            labelCategoria.Location = new Point(20, 24);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(61, 15);
            labelCategoria.TabIndex = 0;
            labelCategoria.Text = "Categoria:";
            //
            // comboBoxCategoria
            //
            comboBoxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategoria.FormattingEnabled = true;
            comboBoxCategoria.Items.AddRange(new object[] { "rock", "classica", "jazz", "pop" });
            comboBoxCategoria.Location = new Point(100, 20);
            comboBoxCategoria.Name = "comboBoxCategoria";
            comboBoxCategoria.Size = new Size(150, 23);
            comboBoxCategoria.TabIndex = 1;
            //
            // buttonMostraAlbum
            //
            buttonMostraAlbum.Location = new Point(270, 17);
            buttonMostraAlbum.Name = "buttonMostraAlbum";
            buttonMostraAlbum.Size = new Size(145, 30);
            buttonMostraAlbum.TabIndex = 2;
            buttonMostraAlbum.Text = "Mostra album";
            buttonMostraAlbum.UseVisualStyleBackColor = true;
            buttonMostraAlbum.Click += buttonMostraAlbum_Click;
            //
            // buttonCalcolaStatistiche
            //
            buttonCalcolaStatistiche.Enabled = false;
            buttonCalcolaStatistiche.Location = new Point(435, 17);
            buttonCalcolaStatistiche.Name = "buttonCalcolaStatistiche";
            buttonCalcolaStatistiche.Size = new Size(165, 30);
            buttonCalcolaStatistiche.TabIndex = 4;
            buttonCalcolaStatistiche.Text = "Calcola statistiche";
            buttonCalcolaStatistiche.UseVisualStyleBackColor = true;
            buttonCalcolaStatistiche.Click += buttonCalcolaStatistiche_Click;
            //
            // dataGridViewAlbum
            //
            dataGridViewAlbum.AllowUserToAddRows = false;
            dataGridViewAlbum.AllowUserToDeleteRows = false;
            dataGridViewAlbum.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewAlbum.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAlbum.BackgroundColor = SystemColors.Window;
            dataGridViewAlbum.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAlbum.Location = new Point(20, 65);
            dataGridViewAlbum.MultiSelect = false;
            dataGridViewAlbum.Name = "dataGridViewAlbum";
            dataGridViewAlbum.ReadOnly = true;
            dataGridViewAlbum.RowHeadersVisible = false;
            dataGridViewAlbum.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAlbum.Size = new Size(920, 240);
            dataGridViewAlbum.TabIndex = 3;
            dataGridViewAlbum.SelectionChanged += dataGridViewAlbum_SelectionChanged;
            //
            // labelAlbumPiuVecchio
            //
            labelAlbumPiuVecchio.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelAlbumPiuVecchio.AutoEllipsis = true;
            labelAlbumPiuVecchio.Location = new Point(20, 320);
            labelAlbumPiuVecchio.Name = "labelAlbumPiuVecchio";
            labelAlbumPiuVecchio.Size = new Size(920, 25);
            labelAlbumPiuVecchio.TabIndex = 5;
            labelAlbumPiuVecchio.Text = "Album più vecchio: —";
            //
            // labelMediaDurata
            //
            labelMediaDurata.AutoSize = true;
            labelMediaDurata.Location = new Point(20, 350);
            labelMediaDurata.Name = "labelMediaDurata";
            labelMediaDurata.Size = new Size(95, 15);
            labelMediaDurata.TabIndex = 6;
            labelMediaDurata.Text = "Durata media: —";
            //
            // labelBrani
            //
            labelBrani.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelBrani.AutoEllipsis = true;
            labelBrani.Location = new Point(20, 395);
            labelBrani.Name = "labelBrani";
            labelBrani.Size = new Size(920, 25);
            labelBrani.TabIndex = 7;
            labelBrani.Text = "Brani: seleziona un album nella griglia";
            //
            // dataGridViewBrani
            //
            dataGridViewBrani.AllowUserToAddRows = false;
            dataGridViewBrani.AllowUserToDeleteRows = false;
            dataGridViewBrani.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewBrani.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBrani.BackgroundColor = SystemColors.Window;
            dataGridViewBrani.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBrani.Location = new Point(20, 425);
            dataGridViewBrani.MultiSelect = false;
            dataGridViewBrani.Name = "dataGridViewBrani";
            dataGridViewBrani.ReadOnly = true;
            dataGridViewBrani.RowHeadersVisible = false;
            dataGridViewBrani.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBrani.Size = new Size(920, 185);
            dataGridViewBrani.TabIndex = 8;
            //
            // FormAlbum
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 630);
            Controls.Add(dataGridViewBrani);
            Controls.Add(labelBrani);
            Controls.Add(labelMediaDurata);
            Controls.Add(labelAlbumPiuVecchio);
            Controls.Add(dataGridViewAlbum);
            Controls.Add(buttonCalcolaStatistiche);
            Controls.Add(buttonMostraAlbum);
            Controls.Add(comboBoxCategoria);
            Controls.Add(labelCategoria);
            MinimumSize = new Size(800, 650);
            Name = "FormAlbum";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Album musicali";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlbum).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBrani).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCategoria;
        private ComboBox comboBoxCategoria;
        private Button buttonMostraAlbum;
        private Button buttonCalcolaStatistiche;
        private DataGridView dataGridViewAlbum;
        private Label labelAlbumPiuVecchio;
        private Label labelMediaDurata;
        private Label labelBrani;
        private DataGridView dataGridViewBrani;
    }
}
