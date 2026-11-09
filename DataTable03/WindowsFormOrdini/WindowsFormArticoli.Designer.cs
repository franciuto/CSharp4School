namespace DataForm03_WindowsForm
{
    partial class WindowsFormArticoli
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
            label1 = new Label();
            ArticoliGridView = new DataGridView();
            btnSomma = new Button();
            btnMedia = new Button();
            ((System.ComponentModel.ISupportInitialize)ArticoliGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(21, 25);
            label1.Name = "label1";
            label1.Size = new Size(110, 41);
            label1.TabIndex = 0;
            label1.Text = "Articoli";
            // 
            // ArticoliGridView
            // 
            ArticoliGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ArticoliGridView.Location = new Point(21, 86);
            ArticoliGridView.Name = "ArticoliGridView";
            ArticoliGridView.RowHeadersWidth = 51;
            ArticoliGridView.Size = new Size(393, 340);
            ArticoliGridView.TabIndex = 1;
            // 
            // btnSomma
            // 
            btnSomma.Location = new Point(21, 455);
            btnSomma.Name = "btnSomma";
            btnSomma.Size = new Size(191, 29);
            btnSomma.TabIndex = 2;
            btnSomma.Text = "Calcola Somma";
            btnSomma.UseVisualStyleBackColor = true;
            btnSomma.Click += btnSomma_Click;
            // 
            // btnMedia
            // 
            btnMedia.Location = new Point(218, 455);
            btnMedia.Name = "btnMedia";
            btnMedia.Size = new Size(191, 29);
            btnMedia.TabIndex = 3;
            btnMedia.Text = "Calcola Media";
            btnMedia.UseVisualStyleBackColor = true;
            btnMedia.Click += btnMedia_Click;
            // 
            // WindowsFormArticoli
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 508);
            Controls.Add(btnMedia);
            Controls.Add(btnSomma);
            Controls.Add(ArticoliGridView);
            Controls.Add(label1);
            Name = "WindowsFormArticoli";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)ArticoliGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView ArticoliGridView;
        private Button btnSomma;
        private Button btnMedia;
    }
}