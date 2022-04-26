using TP4.Entidades;

namespace TP4

{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
            
        }

        private int getPlazoEntrega(double? rnd)
        {
            var result = -1;
            var tablaPlazo = new List<int>();
            for (int i = 0; i < 4; i++)
            {
                tablaPlazo.Add(0);
            }
            tablaPlazo[0] = 1;
            tablaPlazo[1] = 2;
            tablaPlazo[2] = 3;
            tablaPlazo[3] = 4;

            var tablaHasta = new List<double>();

            for (int i = 0; i < 4; i++)
            {
                tablaHasta.Add(0);
            }
            tablaHasta[0] = 0.43;
            tablaHasta[1] = 0.76;
            tablaHasta[2] = 0.92;
            tablaHasta[3] = 0.9999;
            

            for (int i = 0; i < tablaHasta.Count; i++)
            {
                if (rnd < tablaHasta[i])
                {
                    return tablaPlazo[i];
                }
            }

            return result;
        }

        private int getCantidadCocheVendidos(double rnd)
        {
            var result = -1;
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
            tablaHasta[6] = 0.9999;

            for (int i = 0; i < tablaHasta.Count; i++)
            {
                if (rnd < tablaHasta[i])
                {
                    return tablaCantCoches[i];
                }
            }

            return result;
        }

        private void necesitoEntrega(Registro registro)
        {
            Random random = new Random();
            registro.rndDemora = random.NextDouble();
            registro.demora = getPlazoEntrega(registro.rndDemora);
            registro.esperaPedido = true;
            registro.llegadaPedido = registro.mes + registro.demora;
            registro.llegadaPedido = registro.mes + registro.demora;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Informacion infoConsigna = new Informacion();
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
            bool primero = true;
            for (int i = 0; i < n; i++)
            {
                registro.mes += 1;
                
                if (registro.mes == registro.llegadaPedido && registro.esperaPedido)
                {
                    registro.stock += infoConsigna.pedido;
                    registro.esperaPedido = false;
                }
                
                registro.rnd = random.NextDouble();
                registro.demanda = getCantidadCocheVendidos(registro.rnd);

                if (registro.stock > registro.demanda)
                {
                    //Verifico stock restante
                    //Tengo que pedir - Cumplo la condición de pedido y no hay un pedido.
                    if ((registro.stock - registro.demanda) <= infoConsigna.condicionPedido && !registro.esperaPedido)
                    {
                        necesitoEntrega(registro);
                        registro.costoOrdenamiento = infoConsigna.costoOrdenamiento;
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
                        necesitoEntrega(registro);
                    }
                    registro.stock = 0;
                    registro.costoMantenimiento = 0;
                    registro.costoOrdenamiento = 0;
                }
                registro.total = registro.costoExterno + registro.costoMantenimiento + registro.costoOrdenamiento;

                promedio += registro.total;
                registro.totalAcumulado += registro.total;

#pragma warning disable CS8601 // Posible asignación de referencia nula
                if (registro.mes - 1 >= desde && registro.mes - 1 <= hasta)
                {
                    var fila = new string[]{
                        registro.mes.ToString(),
                        registro.rnd.ToString(),
                        //Math.Truncate((decimal)registro.rnd * 1000 / 1000).ToString(),
                        registro.demanda.ToString(),
                        //Math.Truncate((decimal)registro.rndDemora * 1000 / 1000).ToString(),
                        registro.rndDemora.ToString(),
                        registro.demora.ToString(),
                        registro.esperaPedido ? "Si" : " ",
                        registro.esperaPedido ? registro.llegadaPedido.ToString() : " ",
                        "no se xd",
                        registro.stock.ToString(),
                        registro.costoOrdenamiento.ToString(),
                        registro.costoMantenimiento.ToString(),
                        registro.costoExterno.ToString(),
                        registro.total.ToString(),
                        registro.totalAcumulado.ToString()
                    };
                    dgvIteraciones.Rows.Add(fila);
                }
#pragma warning restore CS8601 // Posible asignación de referencia nula
            }
            lblRes.Text = "Generados";
            txtPromedio.Text = "$ " + (promedio / n).ToString();
        }
    }
}