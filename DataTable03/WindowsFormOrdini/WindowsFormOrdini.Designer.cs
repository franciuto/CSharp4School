namespace WindowsFormOrdini
{
    partial class WindowsFormOrdini
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
            GridViewOrdini = new DataGridView();
            label = new Label();
            btnVisualizzaArticoli = new Button();
            ((System.ComponentModel.ISupportInitialize)GridViewOrdini).BeginInit();
            SuspendLayout();
            // 
            // GridViewOrdini
            // 
            GridViewOrdini.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridViewOrdini.Location = new Point(20, 86);
            GridViewOrdini.Margin = new Padding(2);
            GridViewOrdini.Name = "GridViewOrdini";
            GridViewOrdini.RowHeadersWidth = 82;
            GridViewOrdini.Size = new Size(418, 462);
            GridViewOrdini.TabIndex = 0;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label.Location = new Point(20, 29);
            label.Name = "label";
            label.Size = new Size(78, 31);
            label.TabIndex = 1;
            label.Text = "Ordini";
            label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnVisualizzaArticoli
            // 
            btnVisualizzaArticoli.Location = new Point(20, 571);
            btnVisualizzaArticoli.Name = "btnVisualizzaArticoli";
            btnVisualizzaArticoli.Size = new Size(418, 29);
            btnVisualizzaArticoli.TabIndex = 2;
            btnVisualizzaArticoli.Text = "Visualizza articoli dell'ordine";
            btnVisualizzaArticoli.UseVisualStyleBackColor = true;
            btnVisualizzaArticoli.Click += btnVisualizzaArticoli_Click;
            // 
            // WindowsFormOrdini
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 612);
            Controls.Add(btnVisualizzaArticoli);
            Controls.Add(label);
            Controls.Add(GridViewOrdini);
            Margin = new Padding(2);
            Name = "WindowsFormOrdini";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)GridViewOrdini).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GridViewOrdini;
        private Label label;
        private Button btnVisualizzaArticoli;
    }
}
