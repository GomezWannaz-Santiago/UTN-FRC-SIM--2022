
namespace TP1_SIM
{
    partial class TestKS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestKS));
            this.label6 = new System.Windows.Forms.Label();
            this.txt_calculado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_gradoslibertad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.dgvFrecuencias = new System.Windows.Forms.DataGridView();
            this.desde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Po = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poAc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peAc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.difP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSerie = new System.Windows.Forms.DataGridView();
            this.serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.mstxtMuestra = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rb20 = new System.Windows.Forms.RadioButton();
            this.rb10 = new System.Windows.Forms.RadioButton();
            this.rb15 = new System.Windows.Forms.RadioButton();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.lblTestKS = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrecuencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSerie)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 695);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(498, 40);
            this.label6.TabIndex = 39;
            this.label6.Text = "Por convención, para obtener los valores tabulados\r\nutilizaremos un nivel de sign" +
    "ificancia de 0,05.  ";
            // 
            // txt_calculado
            // 
            this.txt_calculado.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_calculado.Location = new System.Drawing.Point(832, 725);
            this.txt_calculado.Margin = new System.Windows.Forms.Padding(4);
            this.txt_calculado.Name = "txt_calculado";
            this.txt_calculado.Size = new System.Drawing.Size(132, 27);
            this.txt_calculado.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(624, 728);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Valor calculado: ";
            // 
            // txt_gradoslibertad
            // 
            this.txt_gradoslibertad.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gradoslibertad.Location = new System.Drawing.Point(831, 683);
            this.txt_gradoslibertad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_gradoslibertad.Name = "txt_gradoslibertad";
            this.txt_gradoslibertad.Size = new System.Drawing.Size(132, 27);
            this.txt_gradoslibertad.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(623, 687);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Grados de libertad: ";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(1211, 118);
            this.btn_limpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(100, 31);
            this.btn_limpiar.TabIndex = 34;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // dgvFrecuencias
            // 
            this.dgvFrecuencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFrecuencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.desde,
            this.hasta,
            this.fo,
            this.fe,
            this.Po,
            this.Pe,
            this.poAc,
            this.peAc,
            this.difP});
            this.dgvFrecuencias.Location = new System.Drawing.Point(213, 187);
            this.dgvFrecuencias.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFrecuencias.Name = "dgvFrecuencias";
            this.dgvFrecuencias.RowHeadersWidth = 51;
            this.dgvFrecuencias.Size = new System.Drawing.Size(1098, 459);
            this.dgvFrecuencias.TabIndex = 32;
            // 
            // desde
            // 
            this.desde.HeaderText = "Desde";
            this.desde.MinimumWidth = 6;
            this.desde.Name = "desde";
            this.desde.Width = 125;
            // 
            // hasta
            // 
            this.hasta.HeaderText = "Hasta";
            this.hasta.MinimumWidth = 6;
            this.hasta.Name = "hasta";
            this.hasta.Width = 125;
            // 
            // fo
            // 
            this.fo.HeaderText = "Fo";
            this.fo.MinimumWidth = 6;
            this.fo.Name = "fo";
            this.fo.Width = 125;
            // 
            // fe
            // 
            this.fe.HeaderText = "Fe";
            this.fe.MinimumWidth = 6;
            this.fe.Name = "fe";
            this.fe.Width = 125;
            // 
            // Po
            // 
            this.Po.HeaderText = "Po";
            this.Po.MinimumWidth = 6;
            this.Po.Name = "Po";
            this.Po.Width = 125;
            // 
            // Pe
            // 
            this.Pe.HeaderText = "Pe";
            this.Pe.MinimumWidth = 6;
            this.Pe.Name = "Pe";
            this.Pe.Width = 125;
            // 
            // poAc
            // 
            this.poAc.HeaderText = "Po(Ac)";
            this.poAc.MinimumWidth = 6;
            this.poAc.Name = "poAc";
            this.poAc.Width = 125;
            // 
            // peAc
            // 
            this.peAc.HeaderText = "Pe(Ac)";
            this.peAc.MinimumWidth = 6;
            this.peAc.Name = "peAc";
            this.peAc.Width = 125;
            // 
            // difP
            // 
            this.difP.HeaderText = "|Po(AC)-Pe(AC)|";
            this.difP.MinimumWidth = 6;
            this.difP.Name = "difP";
            this.difP.Width = 125;
            // 
            // dgvSerie
            // 
            this.dgvSerie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSerie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serie});
            this.dgvSerie.Location = new System.Drawing.Point(46, 187);
            this.dgvSerie.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSerie.Name = "dgvSerie";
            this.dgvSerie.RowHeadersWidth = 51;
            this.dgvSerie.Size = new System.Drawing.Size(159, 459);
            this.dgvSerie.TabIndex = 31;
            // 
            // serie
            // 
            this.serie.HeaderText = "Serie";
            this.serie.MinimumWidth = 6;
            this.serie.Name = "serie";
            this.serie.Width = 125;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(1103, 118);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(100, 31);
            this.btnGenerar.TabIndex = 30;
            this.btnGenerar.Text = "Generar ";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1211, 721);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 28);
            this.btnSalir.TabIndex = 29;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(477, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Sub Intervalos (k)";
            // 
            // mstxtMuestra
            // 
            this.mstxtMuestra.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mstxtMuestra.Location = new System.Drawing.Point(310, 120);
            this.mstxtMuestra.Margin = new System.Windows.Forms.Padding(4);
            this.mstxtMuestra.Name = "mstxtMuestra";
            this.mstxtMuestra.Size = new System.Drawing.Size(121, 27);
            this.mstxtMuestra.TabIndex = 23;
            this.mstxtMuestra.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tamaño de la Muestra (N)";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.rb20);
            this.panel1.Controls.Add(this.rb10);
            this.panel1.Controls.Add(this.rb15);
            this.panel1.Controls.Add(this.rb5);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(690, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 38);
            this.panel1.TabIndex = 40;
            // 
            // rb20
            // 
            this.rb20.AutoSize = true;
            this.rb20.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb20.Location = new System.Drawing.Point(272, 5);
            this.rb20.Margin = new System.Windows.Forms.Padding(4);
            this.rb20.Name = "rb20";
            this.rb20.Size = new System.Drawing.Size(54, 24);
            this.rb20.TabIndex = 44;
            this.rb20.TabStop = true;
            this.rb20.Text = "12";
            this.rb20.UseVisualStyleBackColor = true;
            // 
            // rb10
            // 
            this.rb10.AutoSize = true;
            this.rb10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb10.Location = new System.Drawing.Point(112, 5);
            this.rb10.Margin = new System.Windows.Forms.Padding(4);
            this.rb10.Name = "rb10";
            this.rb10.Size = new System.Drawing.Size(42, 24);
            this.rb10.TabIndex = 42;
            this.rb10.TabStop = true;
            this.rb10.Text = "8";
            this.rb10.UseVisualStyleBackColor = true;
            // 
            // rb15
            // 
            this.rb15.AutoSize = true;
            this.rb15.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb15.Location = new System.Drawing.Point(192, 5);
            this.rb15.Margin = new System.Windows.Forms.Padding(4);
            this.rb15.Name = "rb15";
            this.rb15.Size = new System.Drawing.Size(54, 24);
            this.rb15.TabIndex = 43;
            this.rb15.TabStop = true;
            this.rb15.Text = "10";
            this.rb15.UseVisualStyleBackColor = true;
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb5.Location = new System.Drawing.Point(32, 5);
            this.rb5.Margin = new System.Windows.Forms.Padding(4);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(42, 24);
            this.rb5.TabIndex = 41;
            this.rb5.TabStop = true;
            this.rb5.Text = "5";
            this.rb5.UseVisualStyleBackColor = true;
            // 
            // lblTestKS
            // 
            this.lblTestKS.AutoSize = true;
            this.lblTestKS.Font = new System.Drawing.Font("Verdana", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestKS.Location = new System.Drawing.Point(36, 26);
            this.lblTestKS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTestKS.Name = "lblTestKS";
            this.lblTestKS.Size = new System.Drawing.Size(780, 59);
            this.lblTestKS.TabIndex = 41;
            this.lblTestKS.Text = "Prueba KolmogorovSmirnov";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(624, 707);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 14);
            this.label3.TabIndex = 42;
            this.label3.Text = "(tamaño de muestra)";
            // 
            // TestKS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1357, 799);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTestKS);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_calculado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_gradoslibertad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.dgvFrecuencias);
            this.Controls.Add(this.dgvSerie);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mstxtMuestra);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TestKS";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TestKolmogorovSmirnov";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrecuencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSerie)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_calculado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_gradoslibertad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.DataGridView dgvFrecuencias;
        private System.Windows.Forms.DataGridView dgvSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn serie;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mstxtMuestra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rb20;
        private System.Windows.Forms.RadioButton rb10;
        private System.Windows.Forms.RadioButton rb15;
        private System.Windows.Forms.RadioButton rb5;
        private System.Windows.Forms.Label lblTestKS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn desde;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn fo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Po;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pe;
        private System.Windows.Forms.DataGridViewTextBoxColumn poAc;
        private System.Windows.Forms.DataGridViewTextBoxColumn peAc;
        private System.Windows.Forms.DataGridViewTextBoxColumn difP;
    }
}