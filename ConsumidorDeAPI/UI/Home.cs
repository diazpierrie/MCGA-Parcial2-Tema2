using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
// ReSharper disable LocalizableElement
namespace UI
{
    public partial class Home : Form
    {
        private static HttpClient client = new HttpClient();
        private readonly BindingList<OperacionDeCompra> _operaciones = new BindingList<OperacionDeCompra>();
        private readonly string[] _rangosEtarios = new[] {"Todos", "Jovenes", "Adultos", "Personas Mayores"};
        public Home()
        {
            InitializeComponent();
            client.BaseAddress = new Uri("https://localhost:44354/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            cbRangosEtarios.DataSource = _rangosEtarios;
        }

        private void btnIniciarCaptura_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private async void GetOperaciones()
        {
            HttpResponseMessage response = null;
            switch (cbRangosEtarios.Text)
            {
                case "Todos": 
                    response = await client.GetAsync("Operaciones/todas");
                    break;
                case "Jovenes":
                    response = await client.GetAsync("Operaciones/juventud");
                    break;
                case "Adultos":
                    response = await client.GetAsync("Operaciones/adultos");
                    break;
                case "Personas Mayores":
                    response = await client.GetAsync("Operaciones/personasMayores");
                    break;
            }

            var data = await response.Content.ReadAsAsync<IEnumerable<OperacionDeCompra>>();
            foreach (var operacion in data)
            {
                _operaciones.Add(operacion);
            }
            this.gridClima.DataSource = _operaciones;
            gridClima.Refresh();
        }

        private void btnFinalizarCaptura_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;


            int jovenesTotales = 0;
            int adultosTotales = 0;
            int personasMayoresTotales = 0;

            double jovenesValorCompraTotal = 0;
            double adultosValorCompraTotal = 0;
            double personasMayoresValorCompraTotal = 0;

            double jovenesCantidadTotal = 0;
            double adultosCantidadTotal = 0;
            double personasMayoresCantidadTotal = 0;

            int hombresTotales = 0;
            int mujeresTotales = 0;
            int otrosTotales = 0;

            foreach (var operacion in _operaciones)
            {
                switch (operacion.Edad)
                {
                    case var n when (n >= 18 && n <= 26):
                        jovenesTotales++;
                        jovenesValorCompraTotal += operacion.ValorCompra;
                        jovenesCantidadTotal += operacion.Cantidad;
                        break;
                    case var n when (n >= 27 && n <= 59):
                        adultosTotales++;
                        adultosValorCompraTotal += operacion.ValorCompra;
                        adultosCantidadTotal += operacion.Cantidad;
                        break;
                    case var n when (n >= 60 && n <= 99):
                        personasMayoresTotales++;
                        personasMayoresValorCompraTotal += operacion.ValorCompra;
                        personasMayoresCantidadTotal += operacion.Cantidad;
                        break;
                    default:
                        break;
                }

                switch (operacion.Genero)
                {
                    case "Masculino":
                        hombresTotales++;
                        break;
                    case "Femenino":
                        mujeresTotales++;
                        break;
                    case "Otros":
                        otrosTotales++;
                        break;
                    default:
                        break;
                }

            }

            switch (cbRangosEtarios.Text)
            {
                case "Todos":
                    lblTotalJovenes.Visible = true;
                    lblTotalAdultos.Visible = true;
                    lblTotalPersonasMayores.Visible = true;
                    lblPromediosValorCompraJovenes.Visible = true;
                    lblPromediosValorCompraAdultos.Visible = true;
                    lblPromediosValorCompraPersonasMayores.Visible = true;
                    lblPromediosCantidadJovenes.Visible = true;
                    lblPromediosCantidadAdultos.Visible = true;
                    lblPromediosCantidadPersonasMayores.Visible = true;


                    lblTotales.Text = $"Totales: {_operaciones.Count}";
                    lblTotalJovenes.Text = $"Jovenes: {jovenesTotales}";
                    lblTotalAdultos.Text = $"Adultos: {adultosTotales}";
                    lblTotalPersonasMayores.Text = $"Personas Mayores: {personasMayoresTotales}";

                    lblPromediosValorCompraJovenes.Text = $"Jovenes: {jovenesValorCompraTotal / jovenesTotales}";
                    lblPromediosValorCompraAdultos.Text = $"Adultos: {adultosValorCompraTotal / adultosTotales}";
                    lblPromediosValorCompraPersonasMayores.Text = $"Personas Mayores: {personasMayoresValorCompraTotal / personasMayoresTotales}";

                    lblPromediosCantidadJovenes.Text = $"Jovenes: {jovenesCantidadTotal / jovenesTotales}";
                    lblPromediosCantidadAdultos.Text = $"Adultos: {adultosCantidadTotal / adultosTotales}";
                    lblPromediosCantidadPersonasMayores.Text = $"Personas Mayores: {personasMayoresCantidadTotal / personasMayoresTotales}";
                    break;
                case "Jovenes":
                    lblTotales.Text = $"Totales: {_operaciones.Count}";
                    lblTotalJovenes.Visible = false;
                    lblTotalAdultos.Visible = false;
                    lblTotalPersonasMayores.Visible = false;

                    lblPromediosCantidad.Text =
                        $"Promedios Valor de Compra: {jovenesValorCompraTotal / jovenesTotales}";
                    lblPromediosValorCompraJovenes.Visible = false;
                    lblPromediosValorCompraAdultos.Visible = false;
                    lblPromediosValorCompraPersonasMayores.Visible = false;

                    lblPromediosValorCompra.Text = $"Promedios Cantidad: {jovenesCantidadTotal / jovenesTotales}";
                    lblPromediosCantidadJovenes.Visible = false;
                    lblPromediosCantidadAdultos.Visible = false;
                    lblPromediosCantidadPersonasMayores.Visible = false;
                    break;
                case "Adultos":
                    lblTotales.Text = $"Totales: {_operaciones.Count}";
                    lblTotalJovenes.Visible = false;
                    lblTotalAdultos.Visible = false;
                    lblTotalPersonasMayores.Visible = false;

                    lblPromediosCantidad.Text =
                        $"Promedios Valor de Compra: {adultosValorCompraTotal / adultosTotales}";
                    lblPromediosValorCompraJovenes.Visible = false;
                    lblPromediosValorCompraAdultos.Visible = false;
                    lblPromediosValorCompraPersonasMayores.Visible = false;

                    lblPromediosValorCompra.Text = $"Promedios Cantidad: {adultosCantidadTotal / adultosTotales}";
                    lblPromediosCantidadJovenes.Visible = false;
                    lblPromediosCantidadAdultos.Visible = false;
                    lblPromediosCantidadPersonasMayores.Visible = false;
                    break;
                case "Personas Mayores":
                    lblTotales.Text = $"Totales: {_operaciones.Count}";
                    lblTotalJovenes.Visible = false;
                    lblTotalAdultos.Visible = false;
                    lblTotalPersonasMayores.Visible = false;

                    lblPromediosCantidad.Text =
                        $"Promedios Valor de Compra: {personasMayoresValorCompraTotal / personasMayoresTotales}";
                    lblPromediosValorCompraJovenes.Visible = false;
                    lblPromediosValorCompraAdultos.Visible = false;
                    lblPromediosValorCompraPersonasMayores.Visible = false;

                    lblPromediosValorCompra.Text = $"Promedios Cantidad: {personasMayoresCantidadTotal / personasMayoresTotales}";
                    lblPromediosCantidadJovenes.Visible = false;
                    lblPromediosCantidadAdultos.Visible = false;
                    lblPromediosCantidadPersonasMayores.Visible = false;
                    break;
            }

            if (hombresTotales == mujeresTotales && mujeresTotales == otrosTotales)
            {
                lblGeneroDeModa.Text = "Genero de Moda: Todos los generos estan igualmente de moda";
            }
            else if (hombresTotales > mujeresTotales && hombresTotales >= otrosTotales)
            {
                lblGeneroDeModa.Text = "Genero de Moda: El genero Hombre esta de moda";
            }
            else if (mujeresTotales > hombresTotales && mujeresTotales >= otrosTotales)
            {
                lblGeneroDeModa.Text = "Genero de Moda: El genero Mujer esta de moda";
            }
            else if (otrosTotales > hombresTotales && otrosTotales >= mujeresTotales)
            {
                lblGeneroDeModa.Text = "Genero de Moda: El genero Otros esta de moda";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetOperaciones();
        }

        private void cbRangosEtarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            _operaciones.Clear();
            timer1.Enabled = false;
            lblTotales.Text = "Totales:";
            lblGeneroDeModa.Text = "Genero de moda:";

            if (cbRangosEtarios.Text == "Todos")
            {
                lblTotalJovenes.Visible = true;
                lblTotalAdultos.Visible = true;
                lblTotalPersonasMayores.Visible = true;
                lblPromediosValorCompraJovenes.Visible = true;
                lblPromediosValorCompraAdultos.Visible = true;
                lblPromediosValorCompraPersonasMayores.Visible = true;
                lblPromediosCantidadJovenes.Visible = true;
                lblPromediosCantidadAdultos.Visible = true;
                lblPromediosCantidadPersonasMayores.Visible = true;
            }
            else
            {
                lblTotalJovenes.Visible = false;
                lblTotalAdultos.Visible = false;
                lblTotalPersonasMayores.Visible = false;
                lblPromediosValorCompraJovenes.Visible = false;
                lblPromediosValorCompraAdultos.Visible = false;
                lblPromediosValorCompraPersonasMayores.Visible = false;
                lblPromediosCantidadJovenes.Visible = false;
                lblPromediosCantidadAdultos.Visible = false;
                lblPromediosCantidadPersonasMayores.Visible = false;
            }

        }
    }
}
