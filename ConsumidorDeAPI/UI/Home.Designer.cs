
namespace UI
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.btnIniciarCaptura = new System.Windows.Forms.Button();
            this.btnFinalizarCaptura = new System.Windows.Forms.Button();
            this.gridClima = new System.Windows.Forms.DataGridView();
            this.lblTotales = new System.Windows.Forms.Label();
            this.lblTotalJovenes = new System.Windows.Forms.Label();
            this.lblTotalAdultos = new System.Windows.Forms.Label();
            this.lblTotalPersonasMayores = new System.Windows.Forms.Label();
            this.lblPromediosValorCompra = new System.Windows.Forms.Label();
            this.lblGeneroDeModa = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbRangosEtarios = new System.Windows.Forms.ComboBox();
            this.lblRangoEtario = new System.Windows.Forms.Label();
            this.lblPromediosValorCompraPersonasMayores = new System.Windows.Forms.Label();
            this.lblPromediosValorCompraAdultos = new System.Windows.Forms.Label();
            this.lblPromediosValorCompraJovenes = new System.Windows.Forms.Label();
            this.lblPromediosCantidadPersonasMayores = new System.Windows.Forms.Label();
            this.lblPromediosCantidadAdultos = new System.Windows.Forms.Label();
            this.lblPromediosCantidadJovenes = new System.Windows.Forms.Label();
            this.lblPromediosCantidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridClima)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIniciarCaptura
            // 
            this.btnIniciarCaptura.Location = new System.Drawing.Point(411, 38);
            this.btnIniciarCaptura.Name = "btnIniciarCaptura";
            this.btnIniciarCaptura.Size = new System.Drawing.Size(133, 23);
            this.btnIniciarCaptura.TabIndex = 0;
            this.btnIniciarCaptura.Text = "Iniciar Captura";
            this.btnIniciarCaptura.UseVisualStyleBackColor = true;
            this.btnIniciarCaptura.Click += new System.EventHandler(this.btnIniciarCaptura_Click);
            // 
            // btnFinalizarCaptura
            // 
            this.btnFinalizarCaptura.Location = new System.Drawing.Point(550, 38);
            this.btnFinalizarCaptura.Name = "btnFinalizarCaptura";
            this.btnFinalizarCaptura.Size = new System.Drawing.Size(157, 23);
            this.btnFinalizarCaptura.TabIndex = 1;
            this.btnFinalizarCaptura.Text = "Finalizar Captura";
            this.btnFinalizarCaptura.UseVisualStyleBackColor = true;
            this.btnFinalizarCaptura.Click += new System.EventHandler(this.btnFinalizarCaptura_Click);
            // 
            // gridClima
            // 
            this.gridClima.AllowUserToAddRows = false;
            this.gridClima.AllowUserToDeleteRows = false;
            this.gridClima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClima.Location = new System.Drawing.Point(12, 91);
            this.gridClima.Name = "gridClima";
            this.gridClima.ReadOnly = true;
            this.gridClima.RowTemplate.Height = 25;
            this.gridClima.Size = new System.Drawing.Size(695, 450);
            this.gridClima.TabIndex = 2;
            // 
            // lblTotales
            // 
            this.lblTotales.AutoSize = true;
            this.lblTotales.Location = new System.Drawing.Point(755, 91);
            this.lblTotales.Name = "lblTotales";
            this.lblTotales.Size = new System.Drawing.Size(46, 15);
            this.lblTotales.TabIndex = 3;
            this.lblTotales.Text = "Totales:";
            // 
            // lblTotalJovenes
            // 
            this.lblTotalJovenes.AutoSize = true;
            this.lblTotalJovenes.Location = new System.Drawing.Point(793, 106);
            this.lblTotalJovenes.Name = "lblTotalJovenes";
            this.lblTotalJovenes.Size = new System.Drawing.Size(51, 15);
            this.lblTotalJovenes.TabIndex = 4;
            this.lblTotalJovenes.Text = "Jovenes:";
            // 
            // lblTotalAdultos
            // 
            this.lblTotalAdultos.AutoSize = true;
            this.lblTotalAdultos.Location = new System.Drawing.Point(793, 121);
            this.lblTotalAdultos.Name = "lblTotalAdultos";
            this.lblTotalAdultos.Size = new System.Drawing.Size(51, 15);
            this.lblTotalAdultos.TabIndex = 5;
            this.lblTotalAdultos.Text = "Adultos:";
            // 
            // lblTotalPersonasMayores
            // 
            this.lblTotalPersonasMayores.AutoSize = true;
            this.lblTotalPersonasMayores.Location = new System.Drawing.Point(793, 136);
            this.lblTotalPersonasMayores.Name = "lblTotalPersonasMayores";
            this.lblTotalPersonasMayores.Size = new System.Drawing.Size(105, 15);
            this.lblTotalPersonasMayores.TabIndex = 6;
            this.lblTotalPersonasMayores.Text = "Personas Mayores:";
            // 
            // lblPromediosValorCompra
            // 
            this.lblPromediosValorCompra.AutoSize = true;
            this.lblPromediosValorCompra.Location = new System.Drawing.Point(755, 184);
            this.lblPromediosValorCompra.Name = "lblPromediosValorCompra";
            this.lblPromediosValorCompra.Size = new System.Drawing.Size(158, 15);
            this.lblPromediosValorCompra.TabIndex = 7;
            this.lblPromediosValorCompra.Text = "Promedios Valor de Compra:";
            // 
            // lblGeneroDeModa
            // 
            this.lblGeneroDeModa.AutoSize = true;
            this.lblGeneroDeModa.Location = new System.Drawing.Point(734, 360);
            this.lblGeneroDeModa.Name = "lblGeneroDeModa";
            this.lblGeneroDeModa.Size = new System.Drawing.Size(101, 15);
            this.lblGeneroDeModa.TabIndex = 10;
            this.lblGeneroDeModa.Text = "Genero de Moda: ";
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cbRangosEtarios
            // 
            this.cbRangosEtarios.FormattingEnabled = true;
            this.cbRangosEtarios.Location = new System.Drawing.Point(117, 38);
            this.cbRangosEtarios.Name = "cbRangosEtarios";
            this.cbRangosEtarios.Size = new System.Drawing.Size(121, 23);
            this.cbRangosEtarios.TabIndex = 11;
            this.cbRangosEtarios.SelectedIndexChanged += new System.EventHandler(this.cbRangosEtarios_SelectedIndexChanged);
            // 
            // lblRangoEtario
            // 
            this.lblRangoEtario.AutoSize = true;
            this.lblRangoEtario.Location = new System.Drawing.Point(23, 42);
            this.lblRangoEtario.Name = "lblRangoEtario";
            this.lblRangoEtario.Size = new System.Drawing.Size(74, 15);
            this.lblRangoEtario.TabIndex = 12;
            this.lblRangoEtario.Text = "Rango Etario";
            // 
            // lblPromediosValorCompraPersonasMayores
            // 
            this.lblPromediosValorCompraPersonasMayores.AutoSize = true;
            this.lblPromediosValorCompraPersonasMayores.Location = new System.Drawing.Point(794, 229);
            this.lblPromediosValorCompraPersonasMayores.Name = "lblPromediosValorCompraPersonasMayores";
            this.lblPromediosValorCompraPersonasMayores.Size = new System.Drawing.Size(105, 15);
            this.lblPromediosValorCompraPersonasMayores.TabIndex = 15;
            this.lblPromediosValorCompraPersonasMayores.Text = "Personas Mayores:";
            // 
            // lblPromediosValorCompraAdultos
            // 
            this.lblPromediosValorCompraAdultos.AutoSize = true;
            this.lblPromediosValorCompraAdultos.Location = new System.Drawing.Point(794, 214);
            this.lblPromediosValorCompraAdultos.Name = "lblPromediosValorCompraAdultos";
            this.lblPromediosValorCompraAdultos.Size = new System.Drawing.Size(51, 15);
            this.lblPromediosValorCompraAdultos.TabIndex = 14;
            this.lblPromediosValorCompraAdultos.Text = "Adultos:";
            // 
            // lblPromediosValorCompraJovenes
            // 
            this.lblPromediosValorCompraJovenes.AutoSize = true;
            this.lblPromediosValorCompraJovenes.Location = new System.Drawing.Point(794, 199);
            this.lblPromediosValorCompraJovenes.Name = "lblPromediosValorCompraJovenes";
            this.lblPromediosValorCompraJovenes.Size = new System.Drawing.Size(51, 15);
            this.lblPromediosValorCompraJovenes.TabIndex = 13;
            this.lblPromediosValorCompraJovenes.Text = "Jovenes:";
            // 
            // lblPromediosCantidadPersonasMayores
            // 
            this.lblPromediosCantidadPersonasMayores.AutoSize = true;
            this.lblPromediosCantidadPersonasMayores.Location = new System.Drawing.Point(794, 302);
            this.lblPromediosCantidadPersonasMayores.Name = "lblPromediosCantidadPersonasMayores";
            this.lblPromediosCantidadPersonasMayores.Size = new System.Drawing.Size(108, 15);
            this.lblPromediosCantidadPersonasMayores.TabIndex = 19;
            this.lblPromediosCantidadPersonasMayores.Text = "Personas Mayores: ";
            // 
            // lblPromediosCantidadAdultos
            // 
            this.lblPromediosCantidadAdultos.AutoSize = true;
            this.lblPromediosCantidadAdultos.Location = new System.Drawing.Point(794, 287);
            this.lblPromediosCantidadAdultos.Name = "lblPromediosCantidadAdultos";
            this.lblPromediosCantidadAdultos.Size = new System.Drawing.Size(51, 15);
            this.lblPromediosCantidadAdultos.TabIndex = 18;
            this.lblPromediosCantidadAdultos.Text = "Adultos:";
            // 
            // lblPromediosCantidadJovenes
            // 
            this.lblPromediosCantidadJovenes.AutoSize = true;
            this.lblPromediosCantidadJovenes.Location = new System.Drawing.Point(794, 272);
            this.lblPromediosCantidadJovenes.Name = "lblPromediosCantidadJovenes";
            this.lblPromediosCantidadJovenes.Size = new System.Drawing.Size(51, 15);
            this.lblPromediosCantidadJovenes.TabIndex = 17;
            this.lblPromediosCantidadJovenes.Text = "Jovenes:";
            // 
            // lblPromediosCantidad
            // 
            this.lblPromediosCantidad.AutoSize = true;
            this.lblPromediosCantidad.Location = new System.Drawing.Point(755, 257);
            this.lblPromediosCantidad.Name = "lblPromediosCantidad";
            this.lblPromediosCantidad.Size = new System.Drawing.Size(118, 15);
            this.lblPromediosCantidad.TabIndex = 16;
            this.lblPromediosCantidad.Text = "Promedios Cantidad:";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 574);
            this.Controls.Add(this.lblPromediosCantidadPersonasMayores);
            this.Controls.Add(this.lblPromediosCantidadAdultos);
            this.Controls.Add(this.lblPromediosCantidadJovenes);
            this.Controls.Add(this.lblPromediosCantidad);
            this.Controls.Add(this.lblPromediosValorCompraPersonasMayores);
            this.Controls.Add(this.lblPromediosValorCompraAdultos);
            this.Controls.Add(this.lblPromediosValorCompraJovenes);
            this.Controls.Add(this.lblRangoEtario);
            this.Controls.Add(this.cbRangosEtarios);
            this.Controls.Add(this.lblGeneroDeModa);
            this.Controls.Add(this.lblPromediosValorCompra);
            this.Controls.Add(this.lblTotalPersonasMayores);
            this.Controls.Add(this.lblTotalAdultos);
            this.Controls.Add(this.lblTotalJovenes);
            this.Controls.Add(this.lblTotales);
            this.Controls.Add(this.gridClima);
            this.Controls.Add(this.btnFinalizarCaptura);
            this.Controls.Add(this.btnIniciarCaptura);
            this.Name = "Home";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridClima)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciarCaptura;
        private System.Windows.Forms.Button btnFinalizarCaptura;
        private System.Windows.Forms.DataGridView gridClima;
        private System.Windows.Forms.Label lblTotales;
        private System.Windows.Forms.Label lblTotalJovenes;
        private System.Windows.Forms.Label lblTotalAdultos;
        private System.Windows.Forms.Label lblTotalPersonasMayores;
        private System.Windows.Forms.Label lblPromediosValorCompra;
        private System.Windows.Forms.Label lblGeneroDeModa;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cbRangosEtarios;
        private System.Windows.Forms.Label lblRangoEtario;
        private System.Windows.Forms.Label lblPromediosValorCompraPersonasMayores;
        private System.Windows.Forms.Label lblPromediosValorCompraAdultos;
        private System.Windows.Forms.Label lblPromediosValorCompraJovenes;
        private System.Windows.Forms.Label lblPromediosCantidadPersonasMayores;
        private System.Windows.Forms.Label lblPromediosCantidadAdultos;
        private System.Windows.Forms.Label lblPromediosCantidadJovenes;
        private System.Windows.Forms.Label lblPromediosCantidad;
    }
}

