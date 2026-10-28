partial class WindowsFormAlbum
{
    private Label lblCategoria;
    private ComboBox cmbCategoria;
    private Button btnMostraAlbum;
    private Button btnStatistiche;
    private DataGridView dgvAlbum;
    private Label lblAlbumPiuVecchio;
    private Label lblMediaDurata;
    private Label lblBrani;
    private DataGridView dgvBrani;

    private void InitializeComponent()
    {
        lblCategoria = new Label();
        cmbCategoria = new ComboBox();
        btnMostraAlbum = new Button();
        btnStatistiche = new Button();
        dgvAlbum = new DataGridView();
        lblAlbumPiuVecchio = new Label();
        lblMediaDurata = new Label();
        lblBrani = new Label();
        dgvBrani = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dgvAlbum).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgvBrani).BeginInit();
        SuspendLayout();

        lblCategoria.AutoSize = true;
        lblCategoria.Location = new Point(20, 24);
        lblCategoria.Name = "lblCategoria";
        lblCategoria.Text = "Categoria:";

        cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbCategoria.Items.AddRange(new object[] { "rock", "classica", "jazz", "pop" });
        cmbCategoria.Location = new Point(100, 20);
        cmbCategoria.Name = "cmbCategoria";
        cmbCategoria.Size = new Size(150, 23);
        cmbCategoria.TabIndex = 0;

        btnMostraAlbum.Location = new Point(270, 17);
        btnMostraAlbum.Name = "btnMostraAlbum";
        btnMostraAlbum.Size = new Size(145, 30);
        btnMostraAlbum.TabIndex = 1;
        btnMostraAlbum.Text = "Mostra album";
        btnMostraAlbum.UseVisualStyleBackColor = true;
        btnMostraAlbum.Click += btnMostraAlbum_Click;

        btnStatistiche.Enabled = false;
        btnStatistiche.Location = new Point(435, 17);
        btnStatistiche.Name = "btnStatistiche";
        btnStatistiche.Size = new Size(165, 30);
        btnStatistiche.TabIndex = 3;
        btnStatistiche.Text = "Calcola statistiche";
        btnStatistiche.UseVisualStyleBackColor = true;
        btnStatistiche.Click += btnStatistiche_Click;

        dgvAlbum.AllowUserToAddRows = false;
        dgvAlbum.AllowUserToDeleteRows = false;
        dgvAlbum.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        dgvAlbum.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvAlbum.BackgroundColor = SystemColors.Window;
        dgvAlbum.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvAlbum.Location = new Point(20, 65);
        dgvAlbum.MultiSelect = false;
        dgvAlbum.Name = "dgvAlbum";
        dgvAlbum.ReadOnly = true;
        dgvAlbum.RowHeadersVisible = false;
        dgvAlbum.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvAlbum.Size = new Size(920, 240);
        dgvAlbum.TabIndex = 2;
        dgvAlbum.SelectionChanged += dgvAlbum_SelectionChanged;

        lblAlbumPiuVecchio.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblAlbumPiuVecchio.AutoEllipsis = true;
        lblAlbumPiuVecchio.Location = new Point(20, 320);
        lblAlbumPiuVecchio.Name = "lblAlbumPiuVecchio";
        lblAlbumPiuVecchio.Size = new Size(920, 25);
        lblAlbumPiuVecchio.Text = "Album più vecchio: —";

        lblMediaDurata.AutoSize = true;
        lblMediaDurata.Location = new Point(20, 350);
        lblMediaDurata.Name = "lblMediaDurata";
        lblMediaDurata.Text = "Durata media: —";

        lblBrani.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblBrani.AutoEllipsis = true;
        lblBrani.Location = new Point(20, 395);
        lblBrani.Name = "lblBrani";
        lblBrani.Size = new Size(920, 25);
        lblBrani.Text = "Brani: seleziona un album nella griglia";

        dgvBrani.AllowUserToAddRows = false;
        dgvBrani.AllowUserToDeleteRows = false;
        dgvBrani.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvBrani.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvBrani.BackgroundColor = SystemColors.Window;
        dgvBrani.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvBrani.Location = new Point(20, 425);
        dgvBrani.MultiSelect = false;
        dgvBrani.Name = "dgvBrani";
        dgvBrani.ReadOnly = true;
        dgvBrani.RowHeadersVisible = false;
        dgvBrani.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvBrani.Size = new Size(920, 185);
        dgvBrani.TabIndex = 4;

        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(960, 630);
        Controls.Add(lblCategoria);
        Controls.Add(cmbCategoria);
        Controls.Add(btnMostraAlbum);
        Controls.Add(btnStatistiche);
        Controls.Add(dgvAlbum);
        Controls.Add(lblAlbumPiuVecchio);
        Controls.Add(lblMediaDurata);
        Controls.Add(lblBrani);
        Controls.Add(dgvBrani);
        MinimumSize = new Size(800, 650);
        Name = "WindowsFormAlbum";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Album musicali";
        ((System.ComponentModel.ISupportInitialize)dgvAlbum).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgvBrani).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}
