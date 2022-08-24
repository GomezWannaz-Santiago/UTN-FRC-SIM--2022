namespace TP1_SIM
{
    partial class GeneradorAleatorios
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneradorAleatorios));
            this.lblRaiz = new System.Windows.Forms.Label();
            this.txtRaiz = new System.Windows.Forms.TextBox();
            this.lblMetodo = new System.Windows.Forms.Label();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.ite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblC = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtM = new System.Windows.Forms.TextBox();
            this.lblM = new System.Windows.Forms.Label();
            this.txtK = new System.Windows.Forms.TextBox();
            this.lblK = new System.Windows.Forms.Label();
            this.lblG = new System.Windows.Forms.Label();
            this.txtG = new System.Windows.Forms.TextBox();
            this.dgvMetodo = new System.Windows.Forms.DataGridView();
            this.lblTestKS = new System.Windows.Forms.Label();
            this.chartRnd = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbAditivo = new System.Windows.Forms.RadioButton();
            this.rbMixto = new System.Windows.Forms.RadioButton();
            this.rbMultiplicativo = new System.Windows.Forms.RadioButton();
            this.btnUnValor = new System.Windows.Forms.Button();
            this.btnMil = new System.Windows.Forms.Button();
            this.btnVeinte = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Desde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrecAbs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrecuenciaRelativa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRnd)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRaiz
            // 
            this.lblRaiz.AutoSize = true;
            this.lblRaiz.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaiz.Location = new System.Drawing.Point(61, 202);
            this.lblRaiz.Name = "lblRaiz";
            this.lblRaiz.Size = new System.Drawing.Size(35, 16);
            this.lblRaiz.TabIndex = 0;
            this.lblRaiz.Text = "X0: ";
            // 
            // txtRaiz
            // 
            this.txtRaiz.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRaiz.Location = new System.Drawing.Point(101, 200);
            this.txtRaiz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRaiz.Name = "txtRaiz";
            this.txtRaiz.Size = new System.Drawing.Size(39, 23);
            this.txtRaiz.TabIndex = 1;
            this.txtRaiz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // lblMetodo
            // 
            this.lblMetodo.AutoSize = true;
            this.lblMetodo.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetodo.Location = new System.Drawing.Point(47, 120);
            this.lblMetodo.Name = "lblMetodo";
            this.lblMetodo.Size = new System.Drawing.Size(179, 17);
            this.lblMetodo.TabIndex = 4;
            this.lblMetodo.Text = "Seleccionar un método:";
            // 
            // dgvTabla
            // 
            this.dgvTabla.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ite,
            this.rnd});
            this.dgvTabla.Location = new System.Drawing.Point(66, 22);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.RowHeadersWidth = 51;
            this.dgvTabla.Size = new System.Drawing.Size(376, 395);
            this.dgvTabla.TabIndex = 6;
            // 
            // ite
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ite.DefaultCellStyle = dataGridViewCellStyle1;
            this.ite.HeaderText = "i";
            this.ite.MinimumWidth = 6;
            this.ite.Name = "ite";
            this.ite.Width = 160;
            // 
            // rnd
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "N4";
            dataGridViewCellStyle2.NullValue = null;
            this.rnd.DefaultCellStyle = dataGridViewCellStyle2;
            this.rnd.HeaderText = "RND";
            this.rnd.MaxInputLength = 6;
            this.rnd.MinimumWidth = 6;
            this.rnd.Name = "rnd";
            this.rnd.Width = 160;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.Black;
            this.btnGenerar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Location = new System.Drawing.Point(66, 246);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(429, 31);
            this.btnGenerar.TabIndex = 7;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(296, 725);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(174, 29);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(142, 202);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(21, 16);
            this.lblA.TabIndex = 10;
            this.lblA.Text = "a:";
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(170, 200);
            this.txtA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(39, 23);
            this.txtA.TabIndex = 2;
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(212, 201);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(20, 16);
            this.lblC.TabIndex = 12;
            this.lblC.Text = "c:";
            // 
            // txtC
            // 
            this.txtC.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC.Location = new System.Drawing.Point(238, 200);
            this.txtC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(39, 23);
            this.txtC.TabIndex = 3;
            this.txtC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txtM
            // 
            this.txtM.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtM.Location = new System.Drawing.Point(314, 200);
            this.txtM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(39, 23);
            this.txtM.TabIndex = 4;
            this.txtM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblM.Location = new System.Drawing.Point(280, 202);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(26, 16);
            this.lblM.TabIndex = 15;
            this.lblM.Text = "m:";
            // 
            // txtK
            // 
            this.txtK.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtK.Location = new System.Drawing.Point(384, 200);
            this.txtK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(39, 23);
            this.txtK.TabIndex = 5;
            this.txtK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // lblK
            // 
            this.lblK.AutoSize = true;
            this.lblK.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblK.Location = new System.Drawing.Point(356, 202);
            this.lblK.Name = "lblK";
            this.lblK.Size = new System.Drawing.Size(20, 16);
            this.lblK.TabIndex = 17;
            this.lblK.Text = "k:";
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblG.Location = new System.Drawing.Point(426, 202);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(21, 16);
            this.lblG.TabIndex = 18;
            this.lblG.Text = "g:";
            // 
            // txtG
            // 
            this.txtG.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtG.Location = new System.Drawing.Point(456, 200);
            this.txtG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(39, 23);
            this.txtG.TabIndex = 6;
            this.txtG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // dgvMetodo
            // 
            this.dgvMetodo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMetodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMetodo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Desde,
            this.Hasta,
            this.FrecAbs,
            this.FrecuenciaRelativa});
            this.dgvMetodo.Location = new System.Drawing.Point(39, 438);
            this.dgvMetodo.Name = "dgvMetodo";
            this.dgvMetodo.RowHeadersWidth = 51;
            this.dgvMetodo.Size = new System.Drawing.Size(528, 275);
            this.dgvMetodo.TabIndex = 29;
            // 
            // lblTestKS
            // 
            this.lblTestKS.AutoSize = true;
            this.lblTestKS.Font = new System.Drawing.Font("Verdana", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestKS.Location = new System.Drawing.Point(41, 8);
            this.lblTestKS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTestKS.Name = "lblTestKS";
            this.lblTestKS.Size = new System.Drawing.Size(406, 84);
            this.lblTestKS.TabIndex = 42;
            this.lblTestKS.Text = "Generador de\r\nNumeros Aleatorios";
            // 
            // chartRnd
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRnd.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartRnd.Legends.Add(legend1);
            this.chartRnd.Location = new System.Drawing.Point(50, 397);
            this.chartRnd.Margin = new System.Windows.Forms.Padding(4);
            this.chartRnd.Name = "chartRnd";
            this.chartRnd.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.chartRnd.Size = new System.Drawing.Size(473, 371);
            this.chartRnd.TabIndex = 43;
            this.chartRnd.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rbAditivo);
            this.panel1.Controls.Add(this.rbMixto);
            this.panel1.Controls.Add(this.rbMultiplicativo);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(65, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 34);
            this.panel1.TabIndex = 44;
            // 
            // rbAditivo
            // 
            this.rbAditivo.AutoSize = true;
            this.rbAditivo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAditivo.ForeColor = System.Drawing.Color.White;
            this.rbAditivo.Location = new System.Drawing.Point(271, 8);
            this.rbAditivo.Margin = new System.Windows.Forms.Padding(4);
            this.rbAditivo.Name = "rbAditivo";
            this.rbAditivo.Size = new System.Drawing.Size(76, 20);
            this.rbAditivo.TabIndex = 47;
            this.rbAditivo.TabStop = true;
            this.rbAditivo.Text = "Aditivo";
            this.rbAditivo.UseVisualStyleBackColor = true;
            // 
            // rbMixto
            // 
            this.rbMixto.AutoSize = true;
            this.rbMixto.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMixto.ForeColor = System.Drawing.Color.White;
            this.rbMixto.Location = new System.Drawing.Point(172, 8);
            this.rbMixto.Margin = new System.Windows.Forms.Padding(4);
            this.rbMixto.Name = "rbMixto";
            this.rbMixto.Size = new System.Drawing.Size(65, 20);
            this.rbMixto.TabIndex = 46;
            this.rbMixto.TabStop = true;
            this.rbMixto.Text = "Mixto";
            this.rbMixto.UseVisualStyleBackColor = true;
            // 
            // rbMultiplicativo
            // 
            this.rbMultiplicativo.AutoSize = true;
            this.rbMultiplicativo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMultiplicativo.ForeColor = System.Drawing.Color.White;
            this.rbMultiplicativo.Location = new System.Drawing.Point(20, 8);
            this.rbMultiplicativo.Margin = new System.Windows.Forms.Padding(4);
            this.rbMultiplicativo.Name = "rbMultiplicativo";
            this.rbMultiplicativo.Size = new System.Drawing.Size(122, 20);
            this.rbMultiplicativo.TabIndex = 45;
            this.rbMultiplicativo.TabStop = true;
            this.rbMultiplicativo.Text = "Multiplicativo";
            this.rbMultiplicativo.UseVisualStyleBackColor = true;
            // 
            // btnUnValor
            // 
            this.btnUnValor.BackColor = System.Drawing.Color.Black;
            this.btnUnValor.Enabled = false;
            this.btnUnValor.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnValor.ForeColor = System.Drawing.Color.White;
            this.btnUnValor.Location = new System.Drawing.Point(64, 283);
            this.btnUnValor.Name = "btnUnValor";
            this.btnUnValor.Size = new System.Drawing.Size(430, 31);
            this.btnUnValor.TabIndex = 47;
            this.btnUnValor.Text = "Agregar un valor a la serie";
            this.btnUnValor.UseVisualStyleBackColor = false;
            this.btnUnValor.Click += new System.EventHandler(this.btnUnValor_Click);
            // 
            // btnMil
            // 
            this.btnMil.BackColor = System.Drawing.Color.Black;
            this.btnMil.Enabled = false;
            this.btnMil.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMil.ForeColor = System.Drawing.Color.White;
            this.btnMil.Location = new System.Drawing.Point(64, 366);
            this.btnMil.Name = "btnMil";
            this.btnMil.Size = new System.Drawing.Size(430, 31);
            this.btnMil.TabIndex = 48;
            this.btnMil.Text = "Simular hasta diez mil valores";
            this.btnMil.UseVisualStyleBackColor = false;
            this.btnMil.Click += new System.EventHandler(this.btnMil_Click);
            // 
            // btnVeinte
            // 
            this.btnVeinte.BackColor = System.Drawing.Color.Black;
            this.btnVeinte.Enabled = false;
            this.btnVeinte.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeinte.ForeColor = System.Drawing.Color.White;
            this.btnVeinte.Location = new System.Drawing.Point(64, 323);
            this.btnVeinte.Name = "btnVeinte";
            this.btnVeinte.Size = new System.Drawing.Size(430, 31);
            this.btnVeinte.TabIndex = 49;
            this.btnVeinte.Text = "Agregar veinte valores";
            this.btnVeinte.UseVisualStyleBackColor = false;
            this.btnVeinte.Click += new System.EventHandler(this.btnVeinte_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dgvTabla);
            this.panel2.Controls.Add(this.dgvMetodo);
            this.panel2.Controls.Add(this.btnLimpiar);
            this.panel2.Location = new System.Drawing.Point(577, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(610, 774);
            this.panel2.TabIndex = 50;
            // 
            // Desde
            // 
            this.Desde.HeaderText = "Desde";
            this.Desde.MinimumWidth = 6;
            this.Desde.Name = "Desde";
            this.Desde.Width = 125;
            // 
            // Hasta
            // 
            this.Hasta.HeaderText = "Hasta";
            this.Hasta.MinimumWidth = 6;
            this.Hasta.Name = "Hasta";
            this.Hasta.Width = 125;
            // 
            // FrecAbs
            // 
            this.FrecAbs.HeaderText = "Frecuencia Absoluta";
            this.FrecAbs.MinimumWidth = 6;
            this.FrecAbs.Name = "FrecAbs";
            this.FrecAbs.Width = 125;
            // 
            // FrecuenciaRelativa
            // 
            this.FrecuenciaRelativa.HeaderText = "Frecuencia Relativa";
            this.FrecuenciaRelativa.MinimumWidth = 6;
            this.FrecuenciaRelativa.Name = "FrecuenciaRelativa";
            this.FrecuenciaRelativa.Width = 125;
            // 
            // GeneradorAleatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1197, 795);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnVeinte);
            this.Controls.Add(this.btnMil);
            this.Controls.Add(this.btnUnValor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chartRnd);
            this.Controls.Add(this.lblTestKS);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.lblG);
            this.Controls.Add(this.lblK);
            this.Controls.Add(this.txtK);
            this.Controls.Add(this.lblM);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblMetodo);
            this.Controls.Add(this.txtRaiz);
            this.Controls.Add(this.lblRaiz);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GeneradorAleatorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Serie De Numeros Aleatorios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRnd)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRaiz;
        private System.Windows.Forms.TextBox txtRaiz;
        private System.Windows.Forms.Label lblMetodo;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.Label lblK;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.DataGridViewTextBoxColumn ite;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd;
        private System.Windows.Forms.DataGridView dgvMetodo;
        private System.Windows.Forms.Label lblTestKS;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartRnd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbMixto;
        private System.Windows.Forms.RadioButton rbMultiplicativo;
        private System.Windows.Forms.Button btnUnValor;
        private System.Windows.Forms.Button btnMil;
        private System.Windows.Forms.Button btnVeinte;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbAditivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrecAbs;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrecuenciaRelativa;
    }
}

