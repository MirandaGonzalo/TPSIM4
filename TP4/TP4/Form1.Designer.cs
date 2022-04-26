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
            this.Mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRes = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.txtHasta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIteraciones)).BeginInit();
            this.SuspendLayout();
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblN.Location = new System.Drawing.Point(29, 47);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(27, 21);
            this.lblN.TabIndex = 0;
            this.lblN.Text = "N:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(29, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Desde:";
            // 
            // txtN
            // 
            this.txtN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtN.Location = new System.Drawing.Point(96, 44);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 29);
            this.txtN.TabIndex = 2;
            this.txtN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDesde
            // 
            this.txtDesde.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDesde.Location = new System.Drawing.Point(96, 83);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(100, 29);
            this.txtDesde.TabIndex = 3;
            this.txtDesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGenerar.Location = new System.Drawing.Point(29, 145);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(167, 35);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // dgvIteraciones
            // 
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
            this.CostoAcumulado});
            this.dgvIteraciones.Location = new System.Drawing.Point(30, 229);
            this.dgvIteraciones.Name = "dgvIteraciones";
            this.dgvIteraciones.RowTemplate.Height = 25;
            this.dgvIteraciones.Size = new System.Drawing.Size(1469, 245);
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
            // Mes
            // 
            this.Mes.HeaderText = "Reloj (mes)";
            this.Mes.Name = "Mes";
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(1382, 513);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(25, 15);
            this.lblRes.TabIndex = 6;
            this.lblRes.Text = "Res";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPromedio.Location = new System.Drawing.Point(30, 508);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(89, 21);
            this.lblPromedio.TabIndex = 7;
            this.lblPromedio.Text = "Promedio:";
            // 
            // txtPromedio
            // 
            this.txtPromedio.Enabled = false;
            this.txtPromedio.Location = new System.Drawing.Point(125, 508);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(100, 23);
            this.txtPromedio.TabIndex = 8;
            this.txtPromedio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblHasta
            // 
            this.lblHasta.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHasta.Location = new System.Drawing.Point(214, 89);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(57, 21);
            this.lblHasta.TabIndex = 9;
            this.lblHasta.Text = "Hasta:";
            // 
            // txtHasta
            // 
            this.txtHasta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtHasta.Location = new System.Drawing.Point(277, 86);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(100, 29);
            this.txtHasta.TabIndex = 10;
            this.txtHasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1524, 572);
            this.Controls.Add(this.txtHasta);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.txtPromedio);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.dgvIteraciones);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtDesde);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblN);
            this.Name = "Formulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIteraciones)).EndInit();
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
        private Label lblRes;
        private Label lblPromedio;
        private TextBox txtPromedio;
        private Label lblHasta;
        private TextBox txtHasta;
    }
}