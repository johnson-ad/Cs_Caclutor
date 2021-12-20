namespace Calculatrice_GUI
{
    partial class frmCalculatrice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculatrice));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.standardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scientifiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlStandard = new System.Windows.Forms.Panel();
            this.btnEgal = new System.Windows.Forms.Button();
            this.btnVirgule = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPlusMoins = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnMoins = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnFois = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnRacine = new System.Windows.Forms.Button();
            this.btnX2 = new System.Windows.Forms.Button();
            this.btn1surX = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnPourcentage = new System.Windows.Forms.Button();
            this.btnMS = new System.Windows.Forms.Button();
            this.btnMoin = new System.Windows.Forms.Button();
            this.btnMplus = new System.Windows.Forms.Button();
            this.btnMR = new System.Windows.Forms.Button();
            this.btnMC = new System.Windows.Forms.Button();
            this.pnlScientifique = new System.Windows.Forms.Panel();
            this.btnE = new System.Windows.Forms.Button();
            this.btnOct = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnExp = new System.Windows.Forms.Button();
            this.btnLnx = new System.Windows.Forms.Button();
            this.btnHex = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnTanh = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnBin = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnCosh = new System.Windows.Forms.Button();
            this.btnAbs = new System.Windows.Forms.Button();
            this.btnDec = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnSinh = new System.Windows.Forms.Button();
            this.button45 = new System.Windows.Forms.Button();
            this.btnDeg = new System.Windows.Forms.Button();
            this.btnX3 = new System.Windows.Forms.Button();
            this.btnPI = new System.Windows.Forms.Button();
            this.btnClearScientifique = new System.Windows.Forms.Button();
            this.btnFactorielle = new System.Windows.Forms.Button();
            this.btnRand = new System.Windows.Forms.Button();
            this.btnCot = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnParantheseD = new System.Windows.Forms.Button();
            this.btnParantheseG = new System.Windows.Forms.Button();
            this.button56 = new System.Windows.Forms.Button();
            this.button57 = new System.Windows.Forms.Button();
            this.txtR = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.pnlStandard.SuspendLayout();
            this.pnlScientifique.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(737, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardToolStripMenuItem,
            this.scientifiqueToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(28, 20);
            this.toolStripMenuItem1.Text = "...";
            // 
            // standardToolStripMenuItem
            // 
            this.standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            this.standardToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.standardToolStripMenuItem.Text = "Standard";
            this.standardToolStripMenuItem.Click += new System.EventHandler(this.standardToolStripMenuItem_Click);
            // 
            // scientifiqueToolStripMenuItem
            // 
            this.scientifiqueToolStripMenuItem.Name = "scientifiqueToolStripMenuItem";
            this.scientifiqueToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.scientifiqueToolStripMenuItem.Text = "Scientifique";
            this.scientifiqueToolStripMenuItem.Click += new System.EventHandler(this.scientifiqueToolStripMenuItem_Click);
            // 
            // pnlStandard
            // 
            this.pnlStandard.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlStandard.Controls.Add(this.btnEgal);
            this.pnlStandard.Controls.Add(this.btnVirgule);
            this.pnlStandard.Controls.Add(this.btn0);
            this.pnlStandard.Controls.Add(this.btnPlusMoins);
            this.pnlStandard.Controls.Add(this.btnPlus);
            this.pnlStandard.Controls.Add(this.btn3);
            this.pnlStandard.Controls.Add(this.btn2);
            this.pnlStandard.Controls.Add(this.btn1);
            this.pnlStandard.Controls.Add(this.btnMoins);
            this.pnlStandard.Controls.Add(this.btn6);
            this.pnlStandard.Controls.Add(this.btn5);
            this.pnlStandard.Controls.Add(this.btn4);
            this.pnlStandard.Controls.Add(this.btnFois);
            this.pnlStandard.Controls.Add(this.btn9);
            this.pnlStandard.Controls.Add(this.btn8);
            this.pnlStandard.Controls.Add(this.btn7);
            this.pnlStandard.Controls.Add(this.btnDivision);
            this.pnlStandard.Controls.Add(this.btnRacine);
            this.pnlStandard.Controls.Add(this.btnX2);
            this.pnlStandard.Controls.Add(this.btn1surX);
            this.pnlStandard.Controls.Add(this.btnRetour);
            this.pnlStandard.Controls.Add(this.btnC);
            this.pnlStandard.Controls.Add(this.btnCE);
            this.pnlStandard.Controls.Add(this.btnPourcentage);
            this.pnlStandard.Controls.Add(this.btnMS);
            this.pnlStandard.Controls.Add(this.btnMoin);
            this.pnlStandard.Controls.Add(this.btnMplus);
            this.pnlStandard.Controls.Add(this.btnMR);
            this.pnlStandard.Controls.Add(this.btnMC);
            this.pnlStandard.Location = new System.Drawing.Point(0, 109);
            this.pnlStandard.Name = "pnlStandard";
            this.pnlStandard.Size = new System.Drawing.Size(365, 369);
            this.pnlStandard.TabIndex = 1;
            this.pnlStandard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlStandard_Paint);
            // 
            // btnEgal
            // 
            this.btnEgal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEgal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEgal.Location = new System.Drawing.Point(265, 287);
            this.btnEgal.Name = "btnEgal";
            this.btnEgal.Size = new System.Drawing.Size(82, 42);
            this.btnEgal.TabIndex = 40;
            this.btnEgal.Text = "=";
            this.btnEgal.UseVisualStyleBackColor = true;
            this.btnEgal.Click += new System.EventHandler(this.btnEgal_Click);
            // 
            // btnVirgule
            // 
            this.btnVirgule.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnVirgule.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVirgule.Location = new System.Drawing.Point(177, 287);
            this.btnVirgule.Name = "btnVirgule";
            this.btnVirgule.Size = new System.Drawing.Size(82, 42);
            this.btnVirgule.TabIndex = 39;
            this.btnVirgule.Text = ",";
            this.btnVirgule.UseVisualStyleBackColor = true;
            this.btnVirgule.Click += new System.EventHandler(this.btnVirgule_Click);
            // 
            // btn0
            // 
            this.btn0.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(89, 287);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(82, 42);
            this.btn0.TabIndex = 38;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnPlusMoins
            // 
            this.btnPlusMoins.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnPlusMoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlusMoins.Location = new System.Drawing.Point(1, 286);
            this.btnPlusMoins.Name = "btnPlusMoins";
            this.btnPlusMoins.Size = new System.Drawing.Size(82, 42);
            this.btnPlusMoins.TabIndex = 37;
            this.btnPlusMoins.Text = "+/-";
            this.btnPlusMoins.UseVisualStyleBackColor = true;
            this.btnPlusMoins.Click += new System.EventHandler(this.btnPlusMoins_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(265, 240);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(82, 42);
            this.btnPlus.TabIndex = 36;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btn3
            // 
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(177, 240);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(82, 42);
            this.btn3.TabIndex = 35;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(89, 240);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(82, 42);
            this.btn2.TabIndex = 34;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(1, 239);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(82, 42);
            this.btn1.TabIndex = 33;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnMoins
            // 
            this.btnMoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoins.Location = new System.Drawing.Point(265, 193);
            this.btnMoins.Name = "btnMoins";
            this.btnMoins.Size = new System.Drawing.Size(82, 42);
            this.btnMoins.TabIndex = 32;
            this.btnMoins.Text = "-";
            this.btnMoins.UseVisualStyleBackColor = true;
            this.btnMoins.Click += new System.EventHandler(this.btnMoins_Click);
            // 
            // btn6
            // 
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(177, 193);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(82, 42);
            this.btn6.TabIndex = 31;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(89, 193);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(82, 42);
            this.btn5.TabIndex = 30;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(1, 192);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(82, 42);
            this.btn4.TabIndex = 29;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btnFois
            // 
            this.btnFois.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFois.Location = new System.Drawing.Point(265, 146);
            this.btnFois.Name = "btnFois";
            this.btnFois.Size = new System.Drawing.Size(82, 42);
            this.btnFois.TabIndex = 28;
            this.btnFois.Text = "X";
            this.btnFois.UseVisualStyleBackColor = true;
            this.btnFois.Click += new System.EventHandler(this.btnFois_Click);
            // 
            // btn9
            // 
            this.btn9.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(177, 146);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(82, 42);
            this.btn9.TabIndex = 27;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(89, 146);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(82, 42);
            this.btn8.TabIndex = 26;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(1, 145);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(82, 42);
            this.btn7.TabIndex = 25;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.Location = new System.Drawing.Point(265, 99);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(82, 42);
            this.btnDivision.TabIndex = 24;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnRacine
            // 
            this.btnRacine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRacine.Image = ((System.Drawing.Image)(resources.GetObject("btnRacine.Image")));
            this.btnRacine.Location = new System.Drawing.Point(177, 99);
            this.btnRacine.Name = "btnRacine";
            this.btnRacine.Size = new System.Drawing.Size(82, 42);
            this.btnRacine.TabIndex = 23;
            this.btnRacine.Text = "    x";
            this.btnRacine.UseVisualStyleBackColor = true;
            this.btnRacine.Click += new System.EventHandler(this.btnRacine_Click);
            // 
            // btnX2
            // 
            this.btnX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX2.Location = new System.Drawing.Point(89, 99);
            this.btnX2.Name = "btnX2";
            this.btnX2.Size = new System.Drawing.Size(82, 42);
            this.btnX2.TabIndex = 22;
            this.btnX2.Text = "X2";
            this.btnX2.UseVisualStyleBackColor = true;
            this.btnX2.Click += new System.EventHandler(this.btnX2_Click);
            // 
            // btn1surX
            // 
            this.btn1surX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1surX.Location = new System.Drawing.Point(1, 98);
            this.btn1surX.Name = "btn1surX";
            this.btn1surX.Size = new System.Drawing.Size(82, 42);
            this.btn1surX.TabIndex = 21;
            this.btn1surX.Text = "1/X";
            this.btn1surX.UseVisualStyleBackColor = true;
            this.btn1surX.Click += new System.EventHandler(this.btn1surX_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.Image = ((System.Drawing.Image)(resources.GetObject("btnRetour.Image")));
            this.btnRetour.Location = new System.Drawing.Point(265, 52);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(82, 42);
            this.btnRetour.TabIndex = 20;
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(177, 52);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(82, 42);
            this.btnC.TabIndex = 19;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            // 
            // btnCE
            // 
            this.btnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.Location = new System.Drawing.Point(89, 52);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(82, 42);
            this.btnCE.TabIndex = 18;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnPourcentage
            // 
            this.btnPourcentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPourcentage.Location = new System.Drawing.Point(1, 51);
            this.btnPourcentage.Name = "btnPourcentage";
            this.btnPourcentage.Size = new System.Drawing.Size(82, 42);
            this.btnPourcentage.TabIndex = 17;
            this.btnPourcentage.Text = "%";
            this.btnPourcentage.UseVisualStyleBackColor = true;
            this.btnPourcentage.Click += new System.EventHandler(this.btnPourcentage_Click);
            // 
            // btnMS
            // 
            this.btnMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMS.Location = new System.Drawing.Point(274, 4);
            this.btnMS.Name = "btnMS";
            this.btnMS.Size = new System.Drawing.Size(73, 42);
            this.btnMS.TabIndex = 16;
            this.btnMS.Text = "ms";
            this.btnMS.UseVisualStyleBackColor = true;
            this.btnMS.Click += new System.EventHandler(this.btnMS_Click);
            // 
            // btnMoin
            // 
            this.btnMoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoin.Location = new System.Drawing.Point(206, 4);
            this.btnMoin.Name = "btnMoin";
            this.btnMoin.Size = new System.Drawing.Size(61, 42);
            this.btnMoin.TabIndex = 15;
            this.btnMoin.Text = "M-";
            this.btnMoin.UseVisualStyleBackColor = true;
            this.btnMoin.Click += new System.EventHandler(this.btnMoin_Click);
            // 
            // btnMplus
            // 
            this.btnMplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMplus.Location = new System.Drawing.Point(138, 4);
            this.btnMplus.Name = "btnMplus";
            this.btnMplus.Size = new System.Drawing.Size(61, 42);
            this.btnMplus.TabIndex = 14;
            this.btnMplus.Text = "M+";
            this.btnMplus.UseVisualStyleBackColor = true;
            this.btnMplus.Click += new System.EventHandler(this.btnMplus_Click);
            // 
            // btnMR
            // 
            this.btnMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMR.Location = new System.Drawing.Point(70, 4);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(61, 42);
            this.btnMR.TabIndex = 13;
            this.btnMR.Text = "MR";
            this.btnMR.UseVisualStyleBackColor = true;
            this.btnMR.Click += new System.EventHandler(this.btnMR_Click);
            // 
            // btnMC
            // 
            this.btnMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMC.Location = new System.Drawing.Point(2, 3);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(61, 42);
            this.btnMC.TabIndex = 0;
            this.btnMC.Text = "MC";
            this.btnMC.UseVisualStyleBackColor = true;
            this.btnMC.Click += new System.EventHandler(this.btnMC_Click);
            // 
            // pnlScientifique
            // 
            this.pnlScientifique.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlScientifique.Controls.Add(this.btnE);
            this.pnlScientifique.Controls.Add(this.btnOct);
            this.pnlScientifique.Controls.Add(this.btnMod);
            this.pnlScientifique.Controls.Add(this.btnExp);
            this.pnlScientifique.Controls.Add(this.btnLnx);
            this.pnlScientifique.Controls.Add(this.btnHex);
            this.pnlScientifique.Controls.Add(this.btnTan);
            this.pnlScientifique.Controls.Add(this.btnTanh);
            this.pnlScientifique.Controls.Add(this.btnLog);
            this.pnlScientifique.Controls.Add(this.btnBin);
            this.pnlScientifique.Controls.Add(this.btnCos);
            this.pnlScientifique.Controls.Add(this.btnCosh);
            this.pnlScientifique.Controls.Add(this.btnAbs);
            this.pnlScientifique.Controls.Add(this.btnDec);
            this.pnlScientifique.Controls.Add(this.btnSin);
            this.pnlScientifique.Controls.Add(this.btnSinh);
            this.pnlScientifique.Controls.Add(this.button45);
            this.pnlScientifique.Controls.Add(this.btnDeg);
            this.pnlScientifique.Controls.Add(this.btnX3);
            this.pnlScientifique.Controls.Add(this.btnPI);
            this.pnlScientifique.Controls.Add(this.btnClearScientifique);
            this.pnlScientifique.Controls.Add(this.btnFactorielle);
            this.pnlScientifique.Controls.Add(this.btnRand);
            this.pnlScientifique.Controls.Add(this.btnCot);
            this.pnlScientifique.Controls.Add(this.btnClearAll);
            this.pnlScientifique.Controls.Add(this.btnParantheseD);
            this.pnlScientifique.Controls.Add(this.btnParantheseG);
            this.pnlScientifique.Controls.Add(this.button56);
            this.pnlScientifique.Controls.Add(this.button57);
            this.pnlScientifique.Location = new System.Drawing.Point(367, 109);
            this.pnlScientifique.Name = "pnlScientifique";
            this.pnlScientifique.Size = new System.Drawing.Size(370, 369);
            this.pnlScientifique.TabIndex = 2;
            // 
            // btnE
            // 
            this.btnE.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnE.Location = new System.Drawing.Point(265, 287);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(82, 42);
            this.btnE.TabIndex = 69;
            this.btnE.Text = "e";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnOct
            // 
            this.btnOct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOct.Location = new System.Drawing.Point(177, 287);
            this.btnOct.Name = "btnOct";
            this.btnOct.Size = new System.Drawing.Size(82, 42);
            this.btnOct.TabIndex = 68;
            this.btnOct.Text = "Oct";
            this.btnOct.UseVisualStyleBackColor = true;
            this.btnOct.Click += new System.EventHandler(this.btnOct_Click);
            // 
            // btnMod
            // 
            this.btnMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMod.Location = new System.Drawing.Point(89, 287);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(82, 42);
            this.btnMod.TabIndex = 67;
            this.btnMod.Text = "Mod";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnExp
            // 
            this.btnExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExp.Location = new System.Drawing.Point(1, 286);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(82, 42);
            this.btnExp.TabIndex = 66;
            this.btnExp.Text = "Exp";
            this.btnExp.UseVisualStyleBackColor = true;
            this.btnExp.Click += new System.EventHandler(this.btnExp_Click);
            // 
            // btnLnx
            // 
            this.btnLnx.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLnx.Location = new System.Drawing.Point(265, 240);
            this.btnLnx.Name = "btnLnx";
            this.btnLnx.Size = new System.Drawing.Size(82, 42);
            this.btnLnx.TabIndex = 65;
            this.btnLnx.Text = "Ln x";
            this.btnLnx.UseVisualStyleBackColor = true;
            this.btnLnx.Click += new System.EventHandler(this.btnLnx_Click);
            // 
            // btnHex
            // 
            this.btnHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHex.Location = new System.Drawing.Point(177, 240);
            this.btnHex.Name = "btnHex";
            this.btnHex.Size = new System.Drawing.Size(82, 42);
            this.btnHex.TabIndex = 64;
            this.btnHex.Text = "Hex";
            this.btnHex.UseVisualStyleBackColor = true;
            this.btnHex.Click += new System.EventHandler(this.btnHex_Click);
            // 
            // btnTan
            // 
            this.btnTan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTan.Location = new System.Drawing.Point(89, 240);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(82, 42);
            this.btnTan.TabIndex = 63;
            this.btnTan.Text = "Tan";
            this.btnTan.UseVisualStyleBackColor = true;
            this.btnTan.Click += new System.EventHandler(this.btnTan_Click);
            // 
            // btnTanh
            // 
            this.btnTanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTanh.Location = new System.Drawing.Point(1, 239);
            this.btnTanh.Name = "btnTanh";
            this.btnTanh.Size = new System.Drawing.Size(82, 42);
            this.btnTanh.TabIndex = 62;
            this.btnTanh.Text = "Tanh";
            this.btnTanh.UseVisualStyleBackColor = true;
            this.btnTanh.Click += new System.EventHandler(this.btnTanh_Click);
            // 
            // btnLog
            // 
            this.btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.Location = new System.Drawing.Point(265, 193);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(82, 42);
            this.btnLog.TabIndex = 61;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnBin
            // 
            this.btnBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBin.Location = new System.Drawing.Point(177, 193);
            this.btnBin.Name = "btnBin";
            this.btnBin.Size = new System.Drawing.Size(82, 42);
            this.btnBin.TabIndex = 60;
            this.btnBin.Text = "Bin";
            this.btnBin.UseVisualStyleBackColor = true;
            this.btnBin.Click += new System.EventHandler(this.btnBin_Click);
            // 
            // btnCos
            // 
            this.btnCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCos.Location = new System.Drawing.Point(89, 193);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(82, 42);
            this.btnCos.TabIndex = 59;
            this.btnCos.Text = "Cos";
            this.btnCos.UseVisualStyleBackColor = true;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnCosh
            // 
            this.btnCosh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCosh.Location = new System.Drawing.Point(1, 192);
            this.btnCosh.Name = "btnCosh";
            this.btnCosh.Size = new System.Drawing.Size(82, 42);
            this.btnCosh.TabIndex = 58;
            this.btnCosh.Text = "Cosh";
            this.btnCosh.UseVisualStyleBackColor = true;
            this.btnCosh.Click += new System.EventHandler(this.btnCosh_Click);
            // 
            // btnAbs
            // 
            this.btnAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbs.Location = new System.Drawing.Point(265, 146);
            this.btnAbs.Name = "btnAbs";
            this.btnAbs.Size = new System.Drawing.Size(82, 42);
            this.btnAbs.TabIndex = 57;
            this.btnAbs.Text = "| x |";
            this.btnAbs.UseVisualStyleBackColor = true;
            this.btnAbs.Click += new System.EventHandler(this.btnAbs_Click);
            // 
            // btnDec
            // 
            this.btnDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDec.Location = new System.Drawing.Point(177, 146);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(82, 42);
            this.btnDec.TabIndex = 56;
            this.btnDec.Text = "Dec";
            this.btnDec.UseVisualStyleBackColor = true;
            // 
            // btnSin
            // 
            this.btnSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSin.Location = new System.Drawing.Point(89, 146);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(82, 42);
            this.btnSin.TabIndex = 55;
            this.btnSin.Text = "Sin";
            this.btnSin.UseVisualStyleBackColor = true;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnSinh
            // 
            this.btnSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinh.Location = new System.Drawing.Point(1, 145);
            this.btnSinh.Name = "btnSinh";
            this.btnSinh.Size = new System.Drawing.Size(82, 42);
            this.btnSinh.TabIndex = 54;
            this.btnSinh.Text = "Sinh";
            this.btnSinh.UseVisualStyleBackColor = true;
            this.btnSinh.Click += new System.EventHandler(this.btnSinh_Click);
            // 
            // button45
            // 
            this.button45.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button45.Location = new System.Drawing.Point(265, 99);
            this.button45.Name = "button45";
            this.button45.Size = new System.Drawing.Size(82, 42);
            this.button45.TabIndex = 53;
            this.button45.Text = "/";
            this.button45.UseVisualStyleBackColor = true;
            // 
            // btnDeg
            // 
            this.btnDeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeg.Location = new System.Drawing.Point(177, 99);
            this.btnDeg.Name = "btnDeg";
            this.btnDeg.Size = new System.Drawing.Size(82, 42);
            this.btnDeg.TabIndex = 52;
            this.btnDeg.Text = "Deg";
            this.btnDeg.UseVisualStyleBackColor = true;
            this.btnDeg.Click += new System.EventHandler(this.btnDeg_Click);
            // 
            // btnX3
            // 
            this.btnX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX3.Location = new System.Drawing.Point(89, 99);
            this.btnX3.Name = "btnX3";
            this.btnX3.Size = new System.Drawing.Size(82, 42);
            this.btnX3.TabIndex = 51;
            this.btnX3.Text = "X3";
            this.btnX3.UseVisualStyleBackColor = true;
            this.btnX3.Click += new System.EventHandler(this.btnX3_Click);
            // 
            // btnPI
            // 
            this.btnPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPI.Image = ((System.Drawing.Image)(resources.GetObject("btnPI.Image")));
            this.btnPI.Location = new System.Drawing.Point(1, 98);
            this.btnPI.Name = "btnPI";
            this.btnPI.Size = new System.Drawing.Size(82, 42);
            this.btnPI.TabIndex = 50;
            this.btnPI.UseVisualStyleBackColor = true;
            this.btnPI.Click += new System.EventHandler(this.btnPI_Click);
            // 
            // btnClearScientifique
            // 
            this.btnClearScientifique.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearScientifique.Image = ((System.Drawing.Image)(resources.GetObject("btnClearScientifique.Image")));
            this.btnClearScientifique.Location = new System.Drawing.Point(265, 52);
            this.btnClearScientifique.Name = "btnClearScientifique";
            this.btnClearScientifique.Size = new System.Drawing.Size(82, 42);
            this.btnClearScientifique.TabIndex = 49;
            this.btnClearScientifique.UseVisualStyleBackColor = true;
            this.btnClearScientifique.Click += new System.EventHandler(this.btnClearScientifique_Click);
            // 
            // btnFactorielle
            // 
            this.btnFactorielle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactorielle.Location = new System.Drawing.Point(177, 52);
            this.btnFactorielle.Name = "btnFactorielle";
            this.btnFactorielle.Size = new System.Drawing.Size(82, 42);
            this.btnFactorielle.TabIndex = 48;
            this.btnFactorielle.Text = "n!";
            this.btnFactorielle.UseVisualStyleBackColor = true;
            this.btnFactorielle.Click += new System.EventHandler(this.btnFactorielle_Click);
            // 
            // btnRand
            // 
            this.btnRand.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRand.Location = new System.Drawing.Point(89, 52);
            this.btnRand.Name = "btnRand";
            this.btnRand.Size = new System.Drawing.Size(82, 42);
            this.btnRand.TabIndex = 47;
            this.btnRand.Text = "Rand";
            this.btnRand.UseVisualStyleBackColor = true;
            this.btnRand.Click += new System.EventHandler(this.btnRand_Click);
            // 
            // btnCot
            // 
            this.btnCot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCot.Location = new System.Drawing.Point(1, 51);
            this.btnCot.Name = "btnCot";
            this.btnCot.Size = new System.Drawing.Size(82, 42);
            this.btnCot.TabIndex = 46;
            this.btnCot.Text = "Cot";
            this.btnCot.UseVisualStyleBackColor = true;
            this.btnCot.Click += new System.EventHandler(this.btnCot_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Image = ((System.Drawing.Image)(resources.GetObject("btnClearAll.Image")));
            this.btnClearAll.Location = new System.Drawing.Point(274, 4);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(73, 42);
            this.btnClearAll.TabIndex = 45;
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnParantheseD
            // 
            this.btnParantheseD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParantheseD.Location = new System.Drawing.Point(206, 4);
            this.btnParantheseD.Name = "btnParantheseD";
            this.btnParantheseD.Size = new System.Drawing.Size(61, 42);
            this.btnParantheseD.TabIndex = 44;
            this.btnParantheseD.Text = ")";
            this.btnParantheseD.UseVisualStyleBackColor = true;
            this.btnParantheseD.Click += new System.EventHandler(this.btnParantheseD_Click);
            // 
            // btnParantheseG
            // 
            this.btnParantheseG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParantheseG.Location = new System.Drawing.Point(138, 4);
            this.btnParantheseG.Name = "btnParantheseG";
            this.btnParantheseG.Size = new System.Drawing.Size(61, 42);
            this.btnParantheseG.TabIndex = 43;
            this.btnParantheseG.Text = "(";
            this.btnParantheseG.UseVisualStyleBackColor = true;
            this.btnParantheseG.Click += new System.EventHandler(this.btnParantheseG_Click);
            // 
            // button56
            // 
            this.button56.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button56.Location = new System.Drawing.Point(70, 4);
            this.button56.Name = "button56";
            this.button56.Size = new System.Drawing.Size(61, 42);
            this.button56.TabIndex = 42;
            this.button56.Text = "MR";
            this.button56.UseVisualStyleBackColor = true;
            this.button56.Click += new System.EventHandler(this.button56_Click);
            // 
            // button57
            // 
            this.button57.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button57.Location = new System.Drawing.Point(2, 3);
            this.button57.Name = "button57";
            this.button57.Size = new System.Drawing.Size(61, 42);
            this.button57.TabIndex = 41;
            this.button57.Text = "MC";
            this.button57.UseVisualStyleBackColor = true;
            // 
            // txtR
            // 
            this.txtR.Enabled = false;
            this.txtR.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtR.Location = new System.Drawing.Point(0, 27);
            this.txtR.Multiline = true;
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(737, 82);
            this.txtR.TabIndex = 3;
            this.txtR.Text = "0";
            this.txtR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtR.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frmCalculatrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(737, 478);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.pnlScientifique);
            this.Controls.Add(this.pnlStandard);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCalculatrice";
            this.Text = "frmCalculatrice";
            this.Load += new System.EventHandler(this.frmCalculatrice_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlStandard.ResumeLayout(false);
            this.pnlScientifique.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem standardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scientifiqueToolStripMenuItem;
        private System.Windows.Forms.Panel pnlStandard;
        private System.Windows.Forms.Panel pnlScientifique;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.Button btnMC;
        private System.Windows.Forms.Button btnPourcentage;
        private System.Windows.Forms.Button btnMS;
        private System.Windows.Forms.Button btnMoin;
        private System.Windows.Forms.Button btnMplus;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.Button btnEgal;
        private System.Windows.Forms.Button btnVirgule;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnPlusMoins;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnMoins;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnFois;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnRacine;
        private System.Windows.Forms.Button btnX2;
        private System.Windows.Forms.Button btn1surX;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnOct;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.Button btnLnx;
        private System.Windows.Forms.Button btnHex;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btnTanh;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnBin;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnCosh;
        private System.Windows.Forms.Button btnAbs;
        private System.Windows.Forms.Button btnDec;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnSinh;
        private System.Windows.Forms.Button button45;
        private System.Windows.Forms.Button btnDeg;
        private System.Windows.Forms.Button btnX3;
        private System.Windows.Forms.Button btnPI;
        private System.Windows.Forms.Button btnClearScientifique;
        private System.Windows.Forms.Button btnFactorielle;
        private System.Windows.Forms.Button btnRand;
        private System.Windows.Forms.Button btnCot;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnParantheseD;
        private System.Windows.Forms.Button btnParantheseG;
        private System.Windows.Forms.Button button56;
        private System.Windows.Forms.Button button57;
    }
}