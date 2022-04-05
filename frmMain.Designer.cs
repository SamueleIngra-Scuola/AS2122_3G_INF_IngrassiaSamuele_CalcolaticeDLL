
namespace AS2122_3G_INF_IngrassiaSamuele_CalcolaticeDLL
{
    partial class frmMain
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
            this.lblOperando1 = new System.Windows.Forms.Label();
            this.lblOperando2 = new System.Windows.Forms.Label();
            this.lblOperatore = new System.Windows.Forms.Label();
            this.txtOperando1 = new System.Windows.Forms.TextBox();
            this.txtOperando2 = new System.Windows.Forms.TextBox();
            this.cmbOperatore = new System.Windows.Forms.ComboBox();
            this.lblVisualRisultato = new System.Windows.Forms.Label();
            this.lblRisultato = new System.Windows.Forms.Label();
            this.btnCalcola = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOperando1
            // 
            this.lblOperando1.AutoSize = true;
            this.lblOperando1.Location = new System.Drawing.Point(51, 55);
            this.lblOperando1.Name = "lblOperando1";
            this.lblOperando1.Size = new System.Drawing.Size(72, 15);
            this.lblOperando1.TabIndex = 0;
            this.lblOperando1.Text = "Operando 1:";
            // 
            // lblOperando2
            // 
            this.lblOperando2.AutoSize = true;
            this.lblOperando2.Location = new System.Drawing.Point(51, 101);
            this.lblOperando2.Name = "lblOperando2";
            this.lblOperando2.Size = new System.Drawing.Size(72, 15);
            this.lblOperando2.TabIndex = 1;
            this.lblOperando2.Text = "Operando 2:";
            // 
            // lblOperatore
            // 
            this.lblOperatore.AutoSize = true;
            this.lblOperatore.Location = new System.Drawing.Point(51, 167);
            this.lblOperatore.Name = "lblOperatore";
            this.lblOperatore.Size = new System.Drawing.Size(66, 15);
            this.lblOperatore.TabIndex = 2;
            this.lblOperatore.Text = "Operatore: ";
            // 
            // txtOperando1
            // 
            this.txtOperando1.Location = new System.Drawing.Point(139, 52);
            this.txtOperando1.Name = "txtOperando1";
            this.txtOperando1.Size = new System.Drawing.Size(145, 23);
            this.txtOperando1.TabIndex = 3;
            // 
            // txtOperando2
            // 
            this.txtOperando2.Location = new System.Drawing.Point(139, 98);
            this.txtOperando2.Name = "txtOperando2";
            this.txtOperando2.Size = new System.Drawing.Size(145, 23);
            this.txtOperando2.TabIndex = 4;
            // 
            // cmbOperatore
            // 
            this.cmbOperatore.FormattingEnabled = true;
            this.cmbOperatore.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cmbOperatore.Location = new System.Drawing.Point(139, 164);
            this.cmbOperatore.Name = "cmbOperatore";
            this.cmbOperatore.Size = new System.Drawing.Size(57, 23);
            this.cmbOperatore.TabIndex = 5;
            this.cmbOperatore.Text = "+";
            // 
            // lblVisualRisultato
            // 
            this.lblVisualRisultato.AutoSize = true;
            this.lblVisualRisultato.Location = new System.Drawing.Point(203, 287);
            this.lblVisualRisultato.Name = "lblVisualRisultato";
            this.lblVisualRisultato.Size = new System.Drawing.Size(59, 15);
            this.lblVisualRisultato.TabIndex = 6;
            this.lblVisualRisultato.Text = "Risultato: ";
            // 
            // lblRisultato
            // 
            this.lblRisultato.AutoSize = true;
            this.lblRisultato.Location = new System.Drawing.Point(291, 287);
            this.lblRisultato.Name = "lblRisultato";
            this.lblRisultato.Size = new System.Drawing.Size(0, 15);
            this.lblRisultato.TabIndex = 7;
            // 
            // btnCalcola
            // 
            this.btnCalcola.Location = new System.Drawing.Point(51, 229);
            this.btnCalcola.Name = "btnCalcola";
            this.btnCalcola.Size = new System.Drawing.Size(94, 73);
            this.btnCalcola.TabIndex = 8;
            this.btnCalcola.Text = "Calcola";
            this.btnCalcola.UseVisualStyleBackColor = true;
            this.btnCalcola.Click += new System.EventHandler(this.btnCalcola_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 332);
            this.Controls.Add(this.btnCalcola);
            this.Controls.Add(this.lblRisultato);
            this.Controls.Add(this.lblVisualRisultato);
            this.Controls.Add(this.cmbOperatore);
            this.Controls.Add(this.txtOperando2);
            this.Controls.Add(this.txtOperando1);
            this.Controls.Add(this.lblOperatore);
            this.Controls.Add(this.lblOperando2);
            this.Controls.Add(this.lblOperando1);
            this.Name = "frmMain";
            this.Text = "Ingrassia Samuele | Lab 2.3 | 3G | INF ! 30/03/2022 | Calcolatore con logica su D" +
    "LL separato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOperando1;
        private System.Windows.Forms.Label lblOperando2;
        private System.Windows.Forms.Label lblOperatore;
        private System.Windows.Forms.TextBox txtOperando1;
        private System.Windows.Forms.TextBox txtOperando2;
        private System.Windows.Forms.ComboBox cmbOperatore;
        private System.Windows.Forms.Label lblVisualRisultato;
        private System.Windows.Forms.Label lblRisultato;
        private System.Windows.Forms.Button btnCalcola;
    }
}

