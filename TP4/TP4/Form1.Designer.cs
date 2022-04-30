namespace TP4
{
    partial class Formulario
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
            this.lblN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dgvIteraciones = new System.Windows.Forms.DataGridView();
            this.Reloj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RNDDemanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Demanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RNDDemora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Demora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LlegadaPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Km = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoAcumulado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Minimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maximo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Promedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRes = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.lblMinimo = new System.Windows.Forms.Label();
            this.txtMinimo = new System.Windows.Forms.TextBox();
            this.lblMaximo = new System.Windows.Forms.Label();
            this.txtMaximo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIteraciones)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblN.Location = new System.Drawing.Point(22, 25);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(27, 21);
            this.lblN.TabIndex = 0;
            this.lblN.Text = "N:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(197, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Desde:";
            // 
            // txtN
            // 
            this.txtN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtN.Location = new System.Drawing.Point(54, 17);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 29);
            this.txtN.TabIndex = 1;
            this.txtN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDesde
            // 
            this.txtDesde.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDesde.Location = new System.Drawing.Point(264, 17);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(100, 29);
            this.txtDesde.TabIndex = 3;
            this.txtDesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGenerar.Location = new System.Drawing.Point(25, 15);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(167, 35);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // dgvIteraciones
            // 
            this.dgvIteraciones.AllowUserToAddRows = false;
            this.dgvIteraciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIteraciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Reloj,
            this.RNDDemanda,
            this.Demanda,
            this.RNDDemora,
            this.Demora,
            this.Pedido,
            this.LlegadaPedido,
            this.Disponible,
            this.Stock,
            this.Ko,
            this.Km,
            this.Ks,
            this.CostoTotal,
            this.CostoAcumulado,
            this.Minimo,
            this.Maximo,
            this.Promedio});
            this.dgvIteraciones.Location = new System.Drawing.Point(12, 126);
            this.dgvIteraciones.Name = "dgvIteraciones";
            this.dgvIteraciones.RowTemplate.Height = 25;
            this.dgvIteraciones.Size = new System.Drawing.Size(1482, 245);
            this.dgvIteraciones.TabIndex = 5;
            // 
            // Reloj
            // 
            this.Reloj.HeaderText = "Reloj (Mes)";
            this.Reloj.Name = "Reloj";
            // 
            // RNDDemanda
            // 
            this.RNDDemanda.HeaderText = "RND Demanda";
            this.RNDDemanda.Name = "RNDDemanda";
            // 
            // Demanda
            // 
            this.Demanda.HeaderText = "Demanda";
            this.Demanda.Name = "Demanda";
            // 
            // RNDDemora
            // 
            this.RNDDemora.HeaderText = "RND Demora";
            this.RNDDemora.Name = "RNDDemora";
            // 
            // Demora
            // 
            this.Demora.HeaderText = "Demora";
            this.Demora.Name = "Demora";
            // 
            // Pedido
            // 
            this.Pedido.HeaderText = "Orden/Pedido";
            this.Pedido.Name = "Pedido";
            // 
            // LlegadaPedido
            // 
            this.LlegadaPedido.HeaderText = "LlegadaPedido";
            this.LlegadaPedido.Name = "LlegadaPedido";
            // 
            // Disponible
            // 
            this.Disponible.HeaderText = "Disponible";
            this.Disponible.Name = "Disponible";
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            // 
            // Ko
            // 
            this.Ko.HeaderText = "Ko";
            this.Ko.Name = "Ko";
            // 
            // Km
            // 
            this.Km.HeaderText = "Km";
            this.Km.Name = "Km";
            // 
            // Ks
            // 
            this.Ks.HeaderText = "Ks";
            this.Ks.Name = "Ks";
            // 
            // CostoTotal
            // 
            this.CostoTotal.HeaderText = "Costo Total";
            this.CostoTotal.Name = "CostoTotal";
            // 
            // CostoAcumulado
            // 
            this.CostoAcumulado.HeaderText = "Costo Acumulado";
            this.CostoAcumulado.Name = "CostoAcumulado";
            // 
            // Minimo
            // 
            this.Minimo.HeaderText = "Minimo";
            this.Minimo.Name = "Minimo";
            // 
            // Maximo
            // 
            this.Maximo.HeaderText = "Maximo";
            this.Maximo.Name = "Maximo";
            // 
            // Promedio
            // 
            this.Promedio.HeaderText = "Promedio";
            this.Promedio.Name = "Promedio";
            // 
            // Mes
            // 
            this.Mes.HeaderText = "Reloj (mes)";
            this.Mes.Name = "Mes";
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(29, 425);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(25, 15);
            this.lblRes.TabIndex = 6;
            this.lblRes.Text = "Res";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPromedio.Location = new System.Drawing.Point(12, 20);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(89, 21);
            this.lblPromedio.TabIndex = 7;
            this.lblPromedio.Text = "Promedio:";
            // 
            // txtPromedio
            // 
            this.txtPromedio.Enabled = false;
            this.txtPromedio.Location = new System.Drawing.Point(107, 18);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(100, 23);
            this.txtPromedio.TabIndex = 8;
            this.txtPromedio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMinimo
            // 
            this.lblMinimo.AutoSize = true;
            this.lblMinimo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMinimo.Location = new System.Drawing.Point(213, 20);
            this.lblMinimo.Name = "lblMinimo";
            this.lblMinimo.Size = new System.Drawing.Size(74, 21);
            this.lblMinimo.TabIndex = 11;
            this.lblMinimo.Text = "Mínimo:";
            // 
            // txtMinimo
            // 
            this.txtMinimo.Enabled = false;
            this.txtMinimo.Location = new System.Drawing.Point(293, 18);
            this.txtMinimo.Name = "txtMinimo";
            this.txtMinimo.Size = new System.Drawing.Size(100, 23);
            this.txtMinimo.TabIndex = 12;
            this.txtMinimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMaximo
            // 
            this.lblMaximo.AutoSize = true;
            this.lblMaximo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMaximo.Location = new System.Drawing.Point(399, 20);
            this.lblMaximo.Name = "lblMaximo";
            this.lblMaximo.Size = new System.Drawing.Size(77, 21);
            this.lblMaximo.TabIndex = 13;
            this.lblMaximo.Text = "Máximo:";
            // 
            // txtMaximo
            // 
            this.txtMaximo.Enabled = false;
            this.txtMaximo.Location = new System.Drawing.Point(482, 18);
            this.txtMaximo.Name = "txtMaximo";
            this.txtMaximo.Size = new System.Drawing.Size(100, 23);
            this.txtMaximo.TabIndex = 14;
            this.txtMaximo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblN);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtN);
            this.panel1.Controls.Add(this.txtDesde);
            this.panel1.Location = new System.Drawing.Point(29, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 66);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtMaximo);
            this.panel2.Controls.Add(this.lblPromedio);
            this.panel2.Controls.Add(this.txtPromedio);
            this.panel2.Controls.Add(this.lblMaximo);
            this.panel2.Controls.Add(this.lblMinimo);
            this.panel2.Controls.Add(this.txtMinimo);
            this.panel2.Location = new System.Drawing.Point(474, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 66);
            this.panel2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnGenerar);
            this.panel3.Location = new System.Drawing.Point(1284, 397);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(210, 65);
            this.panel3.TabIndex = 17;
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1520, 481);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.dgvIteraciones);
            this.Name = "Formulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario";
            this.Load += new System.EventHandler(this.Formulario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIteraciones)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblN;
        private Label label1;
        private TextBox txtN;
        private TextBox txtDesde;
        private Button btnGenerar;
        private DataGridView dgvIteraciones;
        private DataGridViewTextBoxColumn Mes;
        private Label lblRes;
        private Label lblPromedio;
        private TextBox txtPromedio;
        private Label lblMinimo;
        private TextBox txtMinimo;
        private Label lblMaximo;
        private TextBox txtMaximo;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridViewTextBoxColumn Reloj;
        private DataGridViewTextBoxColumn RNDDemanda;
        private DataGridViewTextBoxColumn Demanda;
        private DataGridViewTextBoxColumn RNDDemora;
        private DataGridViewTextBoxColumn Demora;
        private DataGridViewTextBoxColumn Pedido;
        private DataGridViewTextBoxColumn LlegadaPedido;
        private DataGridViewTextBoxColumn Disponible;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Ko;
        private DataGridViewTextBoxColumn Km;
        private DataGridViewTextBoxColumn Ks;
        private DataGridViewTextBoxColumn CostoTotal;
        private DataGridViewTextBoxColumn CostoAcumulado;
        private DataGridViewTextBoxColumn Minimo;
        private DataGridViewTextBoxColumn Maximo;
        private DataGridViewTextBoxColumn Promedio;
    }
}