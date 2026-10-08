namespace Calculadora2
{
    public partial class Form1 : Form
    {
        private bool nuevaEntrada = true;
        private string? OperacionPendiente;
        private decimal acumulador;

        public Form1()
        {
            InitializeComponent();
            txtPantalla.Text = "0";
            btnMas.Click += new EventHandler(Operador_click);
            btnMenos.Click += new EventHandler(Operador_click);
            btnMultiplicacion.Click += new EventHandler(Operador_click);
            btnDivision.Click += new EventHandler(Operador_click);
            btnIgual.Click += new EventHandler(Igual_Click);
        }
        private void numero_Click(object sender, EventArgs e)
        {
            if(sender is not Button boton)
            {
                return;
            }
            AgregarAPantalla(boton.Text); 
        }
        private void AgregarAPantalla(string valor)
        {
            if (nuevaEntrada)
            {
                txtPantalla.Text = valor == "." ? "0." : valor;
                nuevaEntrada = false;
                return;
            }
            if (valor == "." && txtPantalla.Text.Contains(".", StringComparison.Ordinal))
            {
                return;
            }
            if((txtPantalla.Text == "0" || txtPantalla.Text == "-0") && valor != ".")
            {
                txtPantalla.Text = txtPantalla.Text.StartsWith("-", StringComparison.Ordinal) ? $"-{valor}" : valor;
                return;
            }
            txtPantalla.Text += valor;
        }
        public void signo_click(object sender, EventArgs e)
        {
            if (sender is not Button boton) { return; }
            if (txtPantalla.Text == "0")
            {
                txtPantalla.Text = "-0";
                return;
            }
            if (txtPantalla.Text == "-0")
            {
                txtPantalla.Text = "0";
                return;
            }
            decimal temporal = decimal.Parse(txtPantalla.Text) * -1;
            txtPantalla.Text = temporal.ToString();
        }
        private bool ObtenerValorPantalla(out decimal valor)
        {
            return decimal.TryParse(txtPantalla.Text, out valor);
        }
        private void Operador_click(object sender, EventArgs e)
        {
            if (sender is not Button boton)
            {
                return;
            }
            if(!ObtenerValorPantalla(out var valorActual))
            {
                return;
            }
            if (OperacionPendiente is not null && !nuevaEntrada)
            {
                if (!AplicarOperacionPendiente(valorActual, out var resultadoIntermedio))
                {
                    return;
                }
                acumulador = resultadoIntermedio;
                txtPantalla.Text = acumulador.ToString();
            }
            else
            {
                acumulador = valorActual;
            }
            OperacionPendiente = boton.Text;
            nuevaEntrada = true;
            lblResultado.Text = $"{acumulador.ToString()} {OperacionPendiente}";
        }
        private bool AplicarOperacionPendiente(decimal valorActual, out decimal resultadoIntermedio)
        {
            resultadoIntermedio = acumulador;
            switch (OperacionPendiente)
            {
                case "+":
                    resultadoIntermedio = acumulador + valorActual; 
                    return true;
                case "-":
                    resultadoIntermedio = acumulador - valorActual; 
                    return true;
                case "*":
                    resultadoIntermedio = acumulador * valorActual; 
                    return true;
                case "/":
                    if (valorActual == 0)
                    {
                        MessageBox.Show("No mastiques agua", "Operacion no Valida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    resultadoIntermedio = acumulador / valorActual;
                    return true;
                default:
                    return false;
            }
        }
        private void Igual_Click(object sender, EventArgs e)
        {
            if (OperacionPendiente is null || ObtenerValorPantalla(out var valor))
            {
                return;
            }
            if (nuevaEntrada)
            {
                valor = acumulador;
            }
            decimal valorAnterior = acumulador;
            if(!AplicarOperacionPendiente(valor, out var resultado))
            {
                return;
            }
            txtPantalla.Text = resultado.ToString();
            lblResultado.Text = $"{valorAnterior} {OperacionPendiente} {valor} =";
            acumulador = resultado;
            OperacionPendiente = null;
            nuevaEntrada = true;
        }
        private void Limpiar_Click(object sender, EventArgs e)
        {
            acumulador = 0;
            OperacionPendiente = null;
            txtPantalla.Text = "0";
            lblResultado.Text = "";
        }
        private void Borrar_Click(object sender, EventArgs e)
        {
            if (nuevaEntrada)
            {
                return;
            }
            if (txtPantalla.Text.Length == 1 || (txtPantalla.Text.Length == 2) && txtPantalla.Text.StartsWith("-"))
            {
                txtPantalla.Text = "0";
                return;
            }
            txtPantalla.Text = txtPantalla.Text[..^1];
        }
    }
}
