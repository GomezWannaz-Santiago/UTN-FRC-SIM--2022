namespace TP1_SIM
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnGenerarAlea = new System.Windows.Forms.Button();
            this.btnTestChi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTestiKS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerarAlea
            // 
            this.btnGenerarAlea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarAlea.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGenerarAlea.Location = new System.Drawing.Point(198, 210);
            this.btnGenerarAlea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGenerarAlea.Name = "btnGenerarAlea";
            this.btnGenerarAlea.Size = new System.Drawing.Size(256, 32);
            this.btnGenerarAlea.TabIndex = 0;
            this.btnGenerarAlea.Text = "Generar Aleatorios";
            this.btnGenerarAlea.UseVisualStyleBackColor = true;
            this.btnGenerarAlea.Click += new System.EventHandler(this.btnGenerarAlea_Click);
            // 
            // btnTestChi
            // 
            this.btnTestChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestChi.Location = new System.Drawing.Point(198, 257);
            this.btnTestChi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTestChi.Name = "btnTestChi";
            this.btnTestChi.Size = new System.Drawing.Size(256, 32);
            this.btnTestChi.TabIndex = 1;
            this.btnTestChi.Text = "Test de Chi Cuadrado";
            this.btnTestChi.UseVisualStyleBackColor = true;
            this.btnTestChi.Click += new System.EventHandler(this.btnTestChi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "TRABAJO PRÁCTICO 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Simulación";
            // 
            // btnTestiKS
            // 
            this.btnTestiKS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestiKS.Location = new System.Drawing.Point(198, 303);
            this.btnTestiKS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTestiKS.Name = "btnTestiKS";
            this.btnTestiKS.Size = new System.Drawing.Size(256, 32);
            this.btnTestiKS.TabIndex = 4;
            this.btnTestiKS.Text = "Test de KS";
            this.btnTestiKS.UseVisualStyleBackColor = true;
            this.btnTestiKS.Click += new System.EventHandler(this.btnTestKS_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(685, 413);
            this.Controls.Add(this.btnTestiKS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTestChi);
            this.Controls.Add(this.btnGenerarAlea);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarAlea;
        private System.Windows.Forms.Button btnTestChi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTestiKS;
    }
}