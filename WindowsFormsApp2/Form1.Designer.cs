namespace WindowsFormsApp4
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.karteA = new System.Windows.Forms.TextBox();
            this.karteB = new System.Windows.Forms.TextBox();
            this.karteC = new System.Windows.Forms.TextBox();
            this.karteD = new System.Windows.Forms.TextBox();
            this.KarteE = new System.Windows.Forms.TextBox();
            this.KarteF = new System.Windows.Forms.TextBox();
            this.Randomstarter = new System.Windows.Forms.Button();
            this.Superzahl1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kartenauswerfer";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // karteA
            // 
            this.karteA.Location = new System.Drawing.Point(31, 77);
            this.karteA.Name = "karteA";
            this.karteA.Size = new System.Drawing.Size(100, 22);
            this.karteA.TabIndex = 1;
            this.karteA.TextChanged += new System.EventHandler(this.karteA_TextChanged);
            // 
            // karteB
            // 
            this.karteB.Location = new System.Drawing.Point(150, 77);
            this.karteB.Name = "karteB";
            this.karteB.Size = new System.Drawing.Size(100, 22);
            this.karteB.TabIndex = 2;
            this.karteB.TextChanged += new System.EventHandler(this.karteB_TextChanged);
            // 
            // karteC
            // 
            this.karteC.Location = new System.Drawing.Point(271, 77);
            this.karteC.Name = "karteC";
            this.karteC.Size = new System.Drawing.Size(100, 22);
            this.karteC.TabIndex = 3;
            this.karteC.TextChanged += new System.EventHandler(this.karteC_TextChanged);
            // 
            // karteD
            // 
            this.karteD.Location = new System.Drawing.Point(389, 77);
            this.karteD.Name = "karteD";
            this.karteD.Size = new System.Drawing.Size(100, 22);
            this.karteD.TabIndex = 4;
            this.karteD.TextChanged += new System.EventHandler(this.karteD_TextChanged);
            // 
            // KarteE
            // 
            this.KarteE.Location = new System.Drawing.Point(513, 77);
            this.KarteE.Name = "KarteE";
            this.KarteE.Size = new System.Drawing.Size(100, 22);
            this.KarteE.TabIndex = 5;
            this.KarteE.TextChanged += new System.EventHandler(this.KarteE_TextChanged);
            // 
            // KarteF
            // 
            this.KarteF.Location = new System.Drawing.Point(632, 77);
            this.KarteF.Name = "KarteF";
            this.KarteF.Size = new System.Drawing.Size(100, 22);
            this.KarteF.TabIndex = 6;
            this.KarteF.TextChanged += new System.EventHandler(this.KarteF_TextChanged);
            // 
            // Randomstarter
            // 
            this.Randomstarter.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Randomstarter.Location = new System.Drawing.Point(317, 233);
            this.Randomstarter.Name = "Randomstarter";
            this.Randomstarter.Size = new System.Drawing.Size(120, 70);
            this.Randomstarter.TabIndex = 7;
            this.Randomstarter.Text = "Ziehen";
            this.Randomstarter.UseVisualStyleBackColor = true;
            this.Randomstarter.Click += new System.EventHandler(this.Randomstarter_Click_1);
            // 
            // Superzahl1
            // 
            this.Superzahl1.Location = new System.Drawing.Point(337, 149);
            this.Superzahl1.Name = "Superzahl1";
            this.Superzahl1.Size = new System.Drawing.Size(100, 22);
            this.Superzahl1.TabIndex = 8;
            this.Superzahl1.TextChanged += new System.EventHandler(this.Superzahl1_TextChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(735, 341);
            this.Controls.Add(this.Superzahl1);
            this.Controls.Add(this.Randomstarter);
            this.Controls.Add(this.KarteF);
            this.Controls.Add(this.KarteE);
            this.Controls.Add(this.karteD);
            this.Controls.Add(this.karteC);
            this.Controls.Add(this.karteB);
            this.Controls.Add(this.karteA);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox karteA;
        private System.Windows.Forms.TextBox karteB;
        private System.Windows.Forms.TextBox karteC;
        private System.Windows.Forms.TextBox karteD;
        private System.Windows.Forms.TextBox KarteE;
        private System.Windows.Forms.TextBox KarteF;
        private System.Windows.Forms.Button Randomstarter;
        private System.Windows.Forms.TextBox Superzahl1;
    }
}

