using AS2122_3G_INF_IngraSamuele_CalcolatriceDLL.Library;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace AS2122_3G_INF_IngrassiaSamuele_CalcolaticeDLL
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCalcola_Click(object sender, EventArgs e)
        {
            Operazioni o = new Operazioni();
            {
                int risultato = 0;
                switch (cmbOperatore.Text)
                {
                    case "+":
                        risultato = o.Somma(Convert.ToInt32(txtOperando1.Text), Convert.ToInt32(txtOperando2.Text));
                        break;
                    case "-":
                        risultato = o.Differenza(Convert.ToInt32(txtOperando1.Text), Convert.ToInt32(txtOperando2.Text));
                        break;
                    case "*":
                        risultato = o.Moltiplicazione(Convert.ToInt32(txtOperando1.Text), Convert.ToInt32(txtOperando2.Text));
                        break;
                    case "/":
                        if (String.IsNullOrEmpty(txtOperando1.Text) || String.IsNullOrEmpty(txtOperando2.Text))
                            MessageBox.Show("Riempi tutti i campi!");
                        else
                            risultato = o.Divisione(Convert.ToInt32(txtOperando1.Text), Convert.ToInt32(txtOperando2.Text));
                        break;
                    case "!":
                        risultato = o.Fattoriale(Convert.ToInt32(txtOperando1.Text));
                        break;
                }

                if (risultato < 0)
                    lblRisultato.ForeColor = Color.Red;
                else
                    lblRisultato.ForeColor = Color.LightGreen;

                lblRisultato.Text = risultato.ToString();
            }
        }
    }
}
