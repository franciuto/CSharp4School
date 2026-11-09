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
            ((System.ComponentModel.ISupportInitialize)GridViewOrdini).BeginInit();
            SuspendLayout();
            // 
            // GridViewOrdini
            // 
            GridViewOrdini.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridViewOrdini.Location = new Point(32, 42);
            GridViewOrdini.Name = "GridViewOrdini";
            GridViewOrdini.RowHeadersWidth = 82;
            GridViewOrdini.Size = new Size(680, 836);
            GridViewOrdini.TabIndex = 0;
            // 
            // WindowsFormOrdini
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 910);
            Controls.Add(GridViewOrdini);
            Name = "WindowsFormOrdini";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)GridViewOrdini).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView GridViewOrdini;



    }
}
