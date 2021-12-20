using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice_GUI
{
    public partial class frmCalculatrice : Form
    {
        public frmCalculatrice()
        {
            InitializeComponent();
        }

        double memo;
        char op;

        /// <summary>
        /// function permettant d'afficher les nbr selectionne
        /// </summary>
        /// <param name="valeur">valeur</param>
        public void ecrire(string valeur){
            if (txtR.Text == "0" /*|| txtR.Text = "Impossible de diveser par zero"*/)
            {
                txtR.Text = valeur;
            }
            else
            {
                txtR.Text = txtR.Text + valeur;
            }
        }

        public void operation(char p)
        {
            memo = double.Parse(txtR.Text);
            op = p;
            txtR.Text = "0";
        }

        private void frmCalculatrice_Load(object sender, EventArgs e)
        {
            this.Width = pnlStandard.Width; // affiche le panel standar = deffault
            txtR.Width = this.Width - 16;
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = pnlStandard.Width;
            txtR.Width = this.Width - 16;
        }

        private void scientifiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = pnlStandard.Width + pnlScientifique.Width; // affiche le panel scientifique
            txtR.Width = this.Width - 16;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void pnlStandard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMC_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ecrire("1");
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ecrire("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ecrire("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ecrire("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ecrire("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ecrire("6");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            ecrire("9");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ecrire("8");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ecrire("7");
        }

        private void btnPlusMoins_Click(object sender, EventArgs e)
        {
            memo = (double.Parse(txtR.Text)) * (-1);
            txtR.Text = memo.ToString();
        }

        private void btn1surX_Click(object sender, EventArgs e)
        {
            memo = 1 / (double.Parse(txtR.Text)) ;
            txtR.Text = memo.ToString();
        }

        private void btnX2_Click(object sender, EventArgs e)
        {
            memo = Math.Pow((double.Parse(txtR.Text)),2) ;
            txtR.Text = memo.ToString();
        }

        private void btnRacine_Click(object sender, EventArgs e)
        {
            memo = Math.Sqrt((double.Parse(txtR.Text)));
            txtR.Text = memo.ToString();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            operation('+');
        }

        private void btnEgal_Click(object sender, EventArgs e)
        {
            if(op == '+')
            {
                memo = memo + double.Parse(txtR.Text);
                txtR.Text= memo.ToString();
            }
            if (op == '-')
            {
                memo = memo - double.Parse(txtR.Text);
                txtR.Text = memo.ToString();
            }
            if (op == '*')
            {
                memo = memo * double.Parse(txtR.Text);
                txtR.Text = memo.ToString();
            }
            if (op == '(')
            {
                memo = memo * double.Parse(txtR.Text);
                txtR.Text = memo.ToString();
            }
            if (op == ')')
            {
                memo = memo * double.Parse(txtR.Text);
                txtR.Text = memo.ToString();
            }
            if (op == '%')
            {
                memo = memo % double.Parse(txtR.Text);
                txtR.Text = memo.ToString();
            }
            if (op == '/')
            {
                if(txtR.Text == "o")
                {
                    txtR.Text = "Impossible de diveser par zero";
                    Console.Beep();
                }
                else
                {
                    memo = memo / double.Parse(txtR.Text);
                    txtR.Text = memo.ToString();
                }
                
            }
        }

        private void btnMoins_Click(object sender, EventArgs e)
        {
            operation('-');
        }

        private void btnFois_Click(object sender, EventArgs e)
        {
            operation('*');
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operation('/');
        }

        private void btnVirgule_Click(object sender, EventArgs e)
        {   
            if (txtR.Text.Contains(",") == false)
            {
                txtR.Text = txtR.Text + ",";
            }
           
        }

        private void btnPourcentage_Click(object sender, EventArgs e)
        {
            memo = 1 % (double.Parse(txtR.Text));
            txtR.Text = memo.ToString();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            txtR.Text = txtR.Text.Remove(txtR.Text.Length - 1);           

        }

        private void btnPI_Click(object sender, EventArgs e)
        {
            ecrire("3,141592653589793");
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            memo = Math.Log((double.Parse(txtR.Text)));
            txtR.Text = memo.ToString();
        }

        private void btnSinh_Click(object sender, EventArgs e)
        {
            memo = Math.Sinh((double.Parse(txtR.Text)));
            txtR.Text = memo.ToString();
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            memo = Math.Sin((double.Parse(txtR.Text)));
            txtR.Text = memo.ToString();
        }

        private void btnCosh_Click(object sender, EventArgs e)
        {
            memo = Math.Cosh((double.Parse(txtR.Text)));
            txtR.Text = memo.ToString();
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            memo = Math.Cos((double.Parse(txtR.Text)));
            txtR.Text = memo.ToString();
        }

        private void btnBin_Click(object sender, EventArgs e)
        {
            //memo = Math.b((double.Parse(txtR.Text)));
            //txtR.Text = memo.ToString();
        }

        private void btnTanh_Click(object sender, EventArgs e)
        {
            memo = Math.Tanh((double.Parse(txtR.Text)));
            txtR.Text = memo.ToString();
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            memo = Math.Tan((double.Parse(txtR.Text)));
            txtR.Text = memo.ToString();
        }

        private void btnHex_Click(object sender, EventArgs e)
        {
            //memo = Math.H((double.Parse(txtR.Text)));
            //txtR.Text = memo.ToString();
        }

        private void btnOct_Click(object sender, EventArgs e)
        {
            //memo = Math.Oc((double.Parse(txtR.Text)));
            //txtR.Text = memo.ToString();
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            memo = Math.Log10((double.Parse(txtR.Text)));
            txtR.Text = memo.ToString();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            //memo = Math.((double.Parse(txtR.Text)));
            //txtR.Text = memo.ToString();
        }

        private void btnX3_Click(object sender, EventArgs e)
        {
            memo = Math.Pow((double.Parse(txtR.Text)), 3);
            txtR.Text = memo.ToString();
        }

        private void btnLnx_Click(object sender, EventArgs e)
        {
            memo = Math.Log((double.Parse(txtR.Text)));
            txtR.Text = memo.ToString();
        }

        private void btnRand_Click(object sender, EventArgs e)
        {
            memo = Math.Round((double.Parse(txtR.Text)));
            txtR.Text = memo.ToString();
        }

        private void btnCot_Click(object sender, EventArgs e)
        {
            memo = Math.Acos((double.Parse(txtR.Text)));
            txtR.Text = memo.ToString();
        }

        private void btnAbs_Click(object sender, EventArgs e)
        {
            memo = Math.Abs((double.Parse(txtR.Text)));
            txtR.Text = memo.ToString();

            
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            memo = Math.E;
            txtR.Text = memo.ToString();
        }

        private void btnDeg_Click(object sender, EventArgs e)
        {
            //memo = Math.c((double.Parse(txtR.Text)));
            //txtR.Text = memo.ToString();
        }

        private void btnParantheseG_Click(object sender, EventArgs e)
        {
            ecrire("(");
        }

        private void btnParantheseD_Click(object sender, EventArgs e)
        {
            ecrire(")");
        }

        private void btnFactorielle_Click(object sender, EventArgs e)
        {
            //memo = Math.((double.Parse(txtR.Text)));
            //txtR.Text = memo.ToString();

            //int number, factorial = 1;
            //number = Convert.ToInt32(ecrire(""));

            //if(number < 0)
            //{
            //    ecrire("actorial Negative Impossible");
            //}else if(number <= 1)
            //{
            //    txtR.Text = ( "{0}! = {1}", number, factorial);
            //}
            //else
            //{
            //    for( int counter = number; counter >=2; counter--)
            //    {
            //        factorial = factorial * counter;
            //    }
            //}

          
            //int factorial = 1;
            //for ( int x = 0; x < factorial ; x++)
            //{
            //    factorial *= x + 1;
            //}

            //txtR.Text = factorial.ToString();

        }

        private void btnClearScientifique_Click(object sender, EventArgs e)
        {
            txtR.Text = txtR.Text.Remove(txtR.Text.Length - 1);
        }

        private void button56_Click(object sender, EventArgs e)
        {

        }

        private void btnMR_Click(object sender, EventArgs e)
        {

        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtR.Text = txtR.Text.Remove(txtR.Text.Length - 1);
            txtR.Text = memo.ToString();

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            ecrire("0");
        }

        private void btnCE_Click(object sender, EventArgs e)
        {

        }

        private void btnMplus_Click(object sender, EventArgs e)
        {
            //memo = Math.Max((double.Parse(txtR.Text)));
            //txtR.Text = memo.ToString();
        }

        private void btnMoin_Click(object sender, EventArgs e)
        {
            //memo = Math.Min((double.Parse(txtR.Text)));
            //txtR.Text = memo.ToString();
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            //memo = Math.BigMul((double.Parse(txtR.Text)));
            //txtR.Text = memo.ToString();
            
        }
    }
}
