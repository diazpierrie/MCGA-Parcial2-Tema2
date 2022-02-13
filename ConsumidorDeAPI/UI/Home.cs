using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows.Forms;
// ReSharper disable LocalizableElement
namespace UI
{
    public partial class Home : Form
    {
        private static readonly HttpClient Client = new();
        private readonly BindingList<OperacionDeCompra> _operaciones = new();
        private readonly string[] _rangosEtarios = new[] {"Todos", "Jovenes", "Adultos", "Personas Mayores"};
        public Home()
        {
            InitializeComponent();
            Client.BaseAddress = new Uri("https://localhost:44354/");
            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            cbRangosEtarios.DataSource = _rangosEtarios;
        }

        private void btnIniciarCaptura_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private async void GetOperaciones()
        {
            HttpResponseMessage response = cbRangosEtarios.Text switch
            {
                "Todos" => await Client.GetAsync("Operaciones/todas"),
                "Jovenes" => await Client.GetAsync("Operaciones/juventud"),
                "Adultos" => await Client.GetAsync("Operaciones/adultos"),
                "Personas Mayores" => await Client.GetAsync("Operaciones/personasMayores"),
                _ => null
            };

            if (response != null)
            {
                var data = await response.Content.ReadAsAsync<IEnumerable<OperacionDeCompra>>();
                foreach (var operacion in data)
                {
                    _operaciones.Add(operacion);
                }
            }

            this.gridClima.DataSource = _operaciones;
            gridClima.Refresh();
        }

        private void btnFinalizarCaptura_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;


            var jovenesTotales = 0;
            var adultosTotales = 0;
            var personasMayoresTotales = 0;

            double jovenesValorCompraTotal = 0;
            double adultosValorCompraTotal = 0;
            double personasMayoresValorCompraTotal = 0;

            double jovenesCantidadTotal = 0;
            double adultosCantidadTotal = 0;
            double personasMayoresCantidadTotal = 0;

            var hombresTotales = 0;
            var mujeresTotales = 0;
            var otrosTotales = 0;

            foreach (var operacion in _operaciones)
            {
                switch (operacion.Edad)
                {
                    case <= 26 and >= 18:
                        jovenesTotales++;
                        jovenesValorCompraTotal += operacion.ValorCompra;
                        jovenesCantidadTotal += operacion.Cantidad;
                        break;
                    case <= 59 and >= 27:
                        adultosTotales++;
                        adultosValorCompraTotal += operacion.ValorCompra;
                        adultosCantidadTotal += operacion.Cantidad;
                        break;
                    case <= 99 and >= 60:
                        personasMayoresTotales++;
                        personasMayoresValorCompraTotal += operacion.ValorCompra;
                        personasMayoresCantidadTotal += operacion.Cantidad;
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
