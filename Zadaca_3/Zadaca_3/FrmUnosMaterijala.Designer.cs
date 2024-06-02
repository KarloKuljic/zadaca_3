namespace Zadaca_3
{
    partial class FrmUnosMaterijala
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
            this.btnBack = new System.Windows.Forms.Button();
            this.cmbOdabirMaterijala = new System.Windows.Forms.ComboBox();
            this.txtOdabirMaterijala = new System.Windows.Forms.Label();
            this.numKolicina = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 415);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Nazad";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmbOdabirMaterijala
            // 
            this.cmbOdabirMaterijala.FormattingEnabled = true;
            this.cmbOdabirMaterijala.Location = new System.Drawing.Point(352, 174);
            this.cmbOdabirMaterijala.Name = "cmbOdabirMaterijala";
            this.cmbOdabirMaterijala.Size = new System.Drawing.Size(121, 21);
            this.cmbOdabirMaterijala.TabIndex = 1;
            // 
            // txtOdabirMaterijala
            // 
            this.txtOdabirMaterijala.AutoSize = true;
            this.txtOdabirMaterijala.Location = new System.Drawing.Point(249, 182);
            this.txtOdabirMaterijala.Name = "txtOdabirMaterijala";
            this.txtOdabirMaterijala.Size = new System.Drawing.Size(97, 13);
            this.txtOdabirMaterijala.TabIndex = 2;
            this.txtOdabirMaterijala.Text = "Odaberite materijal:";
            // 
            // numKolicina
            // 
            this.numKolicina.Location = new System.Drawing.Point(352, 230);
            this.numKolicina.Name = "numKolicina";
            this.numKolicina.Size = new System.Drawing.Size(120, 20);
            this.numKolicina.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Odaberite količinu:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(329, 304);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(104, 50);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Unesi";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // FrmUnosMaterijala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numKolicina);
            this.Controls.Add(this.txtOdabirMaterijala);
            this.Controls.Add(this.cmbOdabirMaterijala);
            this.Controls.Add(this.btnBack);
            this.Name = "FrmUnosMaterijala";
            this.Text = "FrmUnosMaterijala";
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cmbOdabirMaterijala;
        private System.Windows.Forms.Label txtOdabirMaterijala;
        private System.Windows.Forms.NumericUpDown numKolicina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubmit;
    }
}