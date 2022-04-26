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

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            dgvIteraciones.Rows.Clear();
            var n = Convert.ToInt64(txtN.Text);
            var desde = Convert.ToInt32(txtDesde.Text);
            var hasta = Convert.ToInt32(txtHasta.Text);
            lblRes.Text = "Por Generar";
            Registro registro = new Registro();
            registro.stock = 25;
            Registro registro2 = new Registro();
            Random random = new Random();
            lblRes.Text = "Generando ...";
            double promedio = 0;
            bool prendio = true;
            for (int i = 0; i < n; i++)
            {
                registro.mes += 1;
                prendio = false;
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
                        prendio = true;
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
                        prendio = true;
                    }
                    registro.stock = 0;
                    registro.costoMantenimiento = 0;
                }

                if (registro.mes != registro.llegadaPedido && registro.esperaPedido && !prendio)
                {
                    registro.costoOrdenamiento = 0;
                }

                registro.total = registro.costoExterno + registro.costoMantenimiento + registro.costoOrdenamiento;

                promedio += registro.total;
                registro.totalAcumulado += registro.total;

#pragma warning disable CS8601 
                if (registro.mes >= desde && registro.mes <= hasta)
                {
                    var fila = new string[]{
                        registro.mes.ToString(),
                        registro.rnd.ToString(),
                        registro.demanda.ToString(),
                        (prendio) ? registro.rndDemora.ToString() : " ",
                        (prendio) ? registro.demora.ToString() : " ",
                        registro.esperaPedido && prendio ? "Si" : " ",
                        registro.esperaPedido && prendio ? registro.llegadaPedido.ToString() : " ",
                        (registro.disponible) ? infoConsigna.pedido.ToString() : " ",
                        registro.stock.ToString(),
                        registro.costoOrdenamiento.ToString(),
                        registro.costoMantenimiento.ToString(),
                        registro.costoExterno.ToString(),
                        registro.total.ToString(),
                        registro.totalAcumulado.ToString()
                    };
                    dgvIteraciones.Rows.Add(fila);
                }
#pragma warning restore CS8601 
            }
            lblRes.Text = "Generados";
            txtPromedio.Text = "$ " + Math.Truncate((promedio / n) * 1000 / 1000).ToString();
        }
    }
} 