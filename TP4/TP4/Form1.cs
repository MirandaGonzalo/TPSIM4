using TP4.Entidades;

namespace TP4

{
    public partial class Formulario : Form
    {
        Informacion infoConsigna = new Informacion();
        List<int> tablaPlazo;
        List<double> tablaHastaPlazo;
        List<int> tablaCantCoches;
        List<double> tablaHastaCantCoches;
        public Formulario()
        {
            InitializeComponent();
            tablaPlazo = crearPlazosEntrega();
            tablaHastaPlazo = crearTablaHastaPlazosEntrega();
            tablaCantCoches = crearTablaCantCoches();
            tablaHastaCantCoches = crearTablaHastaCantCoches();
        }

        private List<int> crearPlazosEntrega()
        {
            var tablaPlazo = new List<int>();
            for (int i = 0; i < 4; i++)
            {
                tablaPlazo.Add(0);
            }
            tablaPlazo[0] = 1;
            tablaPlazo[1] = 2;
            tablaPlazo[2] = 3;
            tablaPlazo[3] = 4;
            return tablaPlazo;
        }

        private List<double> crearTablaHastaPlazosEntrega()
        {
            var tablaHasta = new List<double>();

            for (int i = 0; i < 4; i++)
            {
                tablaHasta.Add(0);
            }
            tablaHasta[0] = 0.43;
            tablaHasta[1] = 0.76;
            tablaHasta[2] = 0.92;
            tablaHasta[3] = 0.99999;
            return tablaHasta;
        }

        private List<int> crearTablaCantCoches()
        {
            var tablaCantCoches = new List<int>();
            for (int i = 0; i < 7; i++)
            {
                tablaCantCoches.Add(0);
            }
            tablaCantCoches[0] = 6;
            tablaCantCoches[1] = 7;
            tablaCantCoches[2] = 8;
            tablaCantCoches[3] = 9;
            tablaCantCoches[4] = 10;
            tablaCantCoches[5] = 11;
            tablaCantCoches[6] = 12;
            return tablaCantCoches;
        }

        private List<double> crearTablaHastaCantCoches()
        {
            var tablaHasta = new List<double>();

            for (int i = 0; i < 7; i++)
            {
                tablaHasta.Add(0);
            }
            tablaHasta[0] = 0.07;
            tablaHasta[1] = 0.18;
            tablaHasta[2] = 0.35;
            tablaHasta[3] = 0.68;
            tablaHasta[4] = 0.93;
            tablaHasta[5] = 0.97;
            tablaHasta[6] = 0.99999;
            return tablaHasta;
        }

        private int getPlazoEntrega(double? rnd)
        {
            var result = -1;

            for (int i = 0; i < tablaHastaPlazo.Count; i++)
            {
                if (rnd < tablaHastaPlazo[i])
                {
                    return tablaPlazo[i];
                }
            }
            return result;
        }

        private int getCantidadCocheVendidos(double rnd)
        {
            var result = -1;
            for (int i = 0; i < tablaHastaCantCoches.Count; i++)
            {
                if (rnd < tablaHastaCantCoches[i])
                {
                    return tablaCantCoches[i];
                }
            }

            return result;
        }

        private void necesitoEntrega(Registro registro, double costoOrdenamiento)
        {
            Random random = new Random();
            registro.rndDemora = Math.Truncate(random.NextDouble() * 10000) / 10000;
            registro.demora = getPlazoEntrega(registro.rndDemora);
            registro.llegadaPedido = registro.mes + registro.demora;
            registro.costoOrdenamiento = costoOrdenamiento;
            registro.esperaPedido = true;
        }

        private void agregarFila(Registro registro)
        {
#pragma warning disable CS8601
            var fila = new string[]{
                registro.mes.ToString(),
                registro.rnd.ToString(),
                registro.demanda.ToString(),
                (registro.prendio) ? registro.rndDemora.ToString() : " ",
                (registro.prendio) ? registro.demora.ToString() : " ",
                registro.esperaPedido && registro.prendio ? "Si" : " ",
                registro.esperaPedido && registro.prendio ? registro.llegadaPedido.ToString() : " ",
                (registro.disponible) ? infoConsigna.pedido.ToString() : " ",
                registro.stock.ToString(),
                registro.costoOrdenamiento.ToString(),
                registro.costoMantenimiento.ToString(),
                registro.costoExterno.ToString(),
                registro.total.ToString(),
                registro.totalAcumulado.ToString(),
                registro.minimoParcial.ToString(),
                registro.maximoParcial.ToString(),
                registro.promedioParcial.ToString()                        
            };
            dgvIteraciones.Rows.Add(fila);
        }

        private void generarIteraciones(Registro registro, int n, int desde, int hasta)
        {
            Random random = new Random();
            bool primero = true;
            double minimo = 0;
            double maximo = 0;
            for (int i = 0; i < n; i++)
            {
                registro.mes += 1;
                registro.prendio = false;
                if (registro.mes == registro.llegadaPedido && registro.esperaPedido)
                {
                    registro.stock += infoConsigna.pedido;
                    registro.esperaPedido = false;
                    registro.costoOrdenamiento = 0;
                    registro.disponible = true;
                }
                else
                {
                    registro.disponible = false;
                }
                registro.rnd = Math.Truncate(random.NextDouble() * 10000) / 10000;
                registro.demanda = getCantidadCocheVendidos(registro.rnd);

                if (registro.stock > registro.demanda)
                {
                    //Verifico stock restante
                    //Tengo que pedir - Cumplo la condición de pedido y no hay un pedido.
                    if ((registro.stock - registro.demanda) <= infoConsigna.condicionPedido && !registro.esperaPedido)
                    {
                        necesitoEntrega(registro, infoConsigna.costoOrdenamiento);
                        registro.prendio = true;
                    }
                    registro.stock -= registro.demanda;
                    registro.costoMantenimiento = registro.stock * infoConsigna.costoAlmacenamiento;
                    registro.costoExterno = 0;
                }
                else
                {
                    registro.costoExterno = (registro.demanda - registro.stock) * infoConsigna.ventaPerdida;
                    if (!registro.esperaPedido)
                    {
                        necesitoEntrega(registro, infoConsigna.costoOrdenamiento);
                        registro.prendio = true;
                    }
                    registro.stock = 0;
                    registro.costoMantenimiento = 0;
                }

                if (registro.mes != registro.llegadaPedido && registro.esperaPedido && !registro.prendio)
                {
                    registro.costoOrdenamiento = 0;
                }

                registro.total = registro.costoExterno + registro.costoMantenimiento + registro.costoOrdenamiento;

                if (primero)
                {
                    registro.minimoParcial = registro.total;
                    registro.maximoParcial = registro.total;
                    registro.promedioParcial = registro.total;
                    minimo = registro.minimoParcial;
                    maximo = registro.maximoParcial;
                    primero = false;
                }
                else
                {
                    if (registro.total < minimo)
                    {
                        registro.minimoParcial = registro.total;
                        minimo = registro.minimoParcial;
                    }
                    if (registro.total > maximo)
                    {
                        registro.maximoParcial = registro.total;
                        maximo = registro.maximoParcial;
                    }
                };

                registro.totalAcumulado += registro.total;
                registro.promedioParcial = registro.totalAcumulado / registro.mes;


                if (registro.mes >= desde && registro.mes <= hasta)
                {
                    agregarFila(registro);   
                } 
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            dgvIteraciones.Rows.Clear();
            var n = Convert.ToInt64(txtN.Text);
            var desde = Convert.ToInt32(txtDesde.Text);
            var hasta = desde + 400;
            lblRes.Text = "Por Generar";
            Registro registro = new Registro();
            registro.stock = 25;
            lblRes.Text = "Generando ...";
            generarIteraciones(registro,(int)n,desde,hasta);
            if (n != hasta)
            {
                agregarFila(registro);
            }
            dgvIteraciones.Rows[dgvIteraciones.RowCount - 1].Cells[13].Style.BackColor = Color.Yellow;
            dgvIteraciones.Rows[dgvIteraciones.RowCount - 1].Cells[14].Style.BackColor = Color.Yellow;
            dgvIteraciones.Rows[dgvIteraciones.RowCount - 1].Cells[15].Style.BackColor = Color.Yellow;
            dgvIteraciones.Rows[dgvIteraciones.RowCount - 1].Cells[16].Style.BackColor = Color.Yellow;
            lblRes.Text = "Generados";
            txtPromedio.Text = "$ " + registro.promedioParcial.ToString();
            txtMinimo.Text = "$ " + registro.minimoParcial.ToString();
            txtMaximo.Text = "$ " + registro.maximoParcial.ToString();
        }

        private void Formulario_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtN;
        }
    }
}