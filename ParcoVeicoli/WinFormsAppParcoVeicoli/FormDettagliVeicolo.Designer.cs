namespace WinFormsAppParcoVeicoli
{
    partial class FormDettagliVeicolo
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
            labelDettagli = new Label();
            labelCosto = new Label();
            SuspendLayout();
            //
            // labelDettagli
            //
            labelDettagli.Location = new Point(14, 20);
            labelDettagli.Name = "labelDettagli";
            labelDettagli.Size = new Size(472, 60);
            labelDettagli.TabIndex = 0;
            labelDettagli.Text = "Dettagli";
            //
            // labelCosto
            //
            labelCosto.AutoSize = true;
            labelCosto.Location = new Point(14, 95);
            labelCosto.Name = "labelCosto";
            labelCosto.Size = new Size(144, 20);
            labelCosto.TabIndex = 1;
            labelCosto.Text = "Costo manutenzione";
            //
            // FormDettagliVeicolo
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 140);
            Controls.Add(labelCosto);
            Controls.Add(labelDettagli);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormDettagliVeicolo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormDettagliVeicolo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDettagli;
        private Label labelCosto;
    }
}
