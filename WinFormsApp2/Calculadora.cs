using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Calculadora : Form
    {
        private double numero1 = 0;
        private string operador = "";
        private bool limpiarPantalla = false;

        [DllImport("user32.dll")]
        private static extern bool HideCaret(IntPtr hWnd);

        public Calculadora()
        {
            InitializeComponent();
            txtPantalla.KeyDown += txtPantalla_KeyDown;
            txtPantalla.GotFocus += (s, e) => HideCaret(txtPantalla.Handle);
            txtPantalla.Click += (s, e) => HideCaret(txtPantalla.Handle);

            if (lstHistorial != null)
            {
                lstHistorial.Visible = false;
            }
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            HideCaret(txtPantalla.Handle);
        }

        private void AgregarNumero(string texto)
        {
            txtPantalla.Focus();
            HideCaret(txtPantalla.Handle);

            if (txtPantalla.Text == "0" || limpiarPantalla)
            {
                txtPantalla.Text = texto;
                limpiarPantalla = false;
            }
            else
            {
                txtPantalla.Text += texto;
            }
            txtPantalla.SelectionStart = txtPantalla.Text.Length;
            HideCaret(txtPantalla.Handle);
        }

        private void EstablecerOperador(string nuevoOperador)
        {
            txtPantalla.Focus();
            HideCaret(txtPantalla.Handle);

            if (double.TryParse(txtPantalla.Text, out double num))
            {
                numero1 = num;
            }

            operador = nuevoOperador;
            label1.Text = numero1.ToString() + " " + operador;
            limpiarPantalla = true;
        }

        private void txtPantalla_KeyDown(object sender, KeyEventArgs e)
        {
            HideCaret(txtPantalla.Handle);

            if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 && !e.Shift) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9))
            {
                string digito = "";
                if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
                    digito = (e.KeyCode - Keys.D0).ToString();
                else
                    digito = (e.KeyCode - Keys.NumPad0).ToString();

                AgregarNumero(digito);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Multiply || (e.Shift && e.KeyCode == Keys.D8) || e.KeyCode == Keys.OemQuotes || (e.Shift && e.KeyCode == Keys.Oemplus))
            {
                EstablecerOperador("x");
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Add || (e.KeyCode == Keys.Oemplus && !e.Shift) || (e.Shift && e.KeyCode == Keys.D1))
            {
                EstablecerOperador("+");
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Subtract || e.KeyCode == Keys.OemMinus)
            {
                EstablecerOperador("-");
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Divide || e.KeyCode == Keys.OemQuestion || (e.Shift && (e.KeyCode == Keys.D7 || e.KeyCode == Keys.D6)))
            {
                EstablecerOperador("÷");
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                BotonIgual_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Back)
            {
                if (txtPantalla.Text.Length > 1)
                {
                    txtPantalla.Text = txtPantalla.Text.Substring(0, txtPantalla.Text.Length - 1);
                }
                else
                {
                    txtPantalla.Text = "0";
                }
                txtPantalla.SelectionStart = txtPantalla.Text.Length;
                HideCaret(txtPantalla.Handle);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void BotonNumero_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            AgregarNumero(btn.Text);
        }

        private void BotonOperador_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string op = btn.Text;
            if (op == "*") op = "x";
            if (op == "/") op = "÷";
            EstablecerOperador(op);
        }

        private void BotonIgual_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null) btn.Focus(); else txtPantalla.Focus();
            HideCaret(txtPantalla.Handle);

            double numero2 = 0;

            if (!double.TryParse(txtPantalla.Text, out numero2))
            {
                numero2 = 0;
            }

            if (numero2 == 0 && limpiarPantalla && !string.IsNullOrEmpty(txtPantalla.Text))
            {
                double.TryParse(txtPantalla.Text, out numero2);
            }

            double resultado = 0;

            switch (operador)
            {
                case "+":
                    resultado = numero1 + numero2;
                    break;
                case "-":
                    resultado = numero1 - numero2;
                    break;
                case "*":
                case "x":
                    resultado = numero1 * numero2;
                    break;
                case "/":
                case "÷":
                    if (numero2 != 0) resultado = numero1 / numero2;
                    else { MessageBox.Show("No se puede dividir entre cero"); return; }
                    break;
            }

            string operacionCompleta = numero1.ToString() + " " + operador + " " + numero2.ToString() + " = " + resultado.ToString();
            label1.Text = numero1.ToString() + " " + operador + " " + numero2.ToString() + " =";
            txtPantalla.Text = resultado.ToString();

            if (lstHistorial != null)
            {
                if (lstHistorial.Items.Contains("No hay historial todavía"))
                {
                    lstHistorial.Items.Clear();
                }
                lstHistorial.Items.Add(operacionCompleta);
            }

            txtPantalla.SelectionStart = txtPantalla.Text.Length;
            HideCaret(txtPantalla.Handle);

            operador = "";
            limpiarPantalla = true;
        }

        private void BotonLimpiar_Click(object sender, EventArgs e)
        {
            txtPantalla.Focus();
            txtPantalla.Text = "0";
            txtPantalla.SelectionStart = txtPantalla.Text.Length;
            HideCaret(txtPantalla.Handle);
            label1.Text = "";
            numero1 = 0;
            operador = "";
            limpiarPantalla = false;
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            if (lstHistorial != null)
            {
                if (lstHistorial.Visible)
                {
                    lstHistorial.Visible = false;
                    this.Width = 370;
                }
                else
                {
                    lstHistorial.Visible = true;
                    this.Width = 600;

                    if (lstHistorial.Items.Count == 0)
                    {
                        lstHistorial.Items.Add("No hay historial todavía");
                    }
                }
            }
            txtPantalla.Focus();
            HideCaret(txtPantalla.Handle);
        }

        private void btnLimpiarHistorial_Click(object sender, EventArgs e)
        {
            if (lstHistorial != null)
            {
                lstHistorial.Items.Clear();
                lstHistorial.Items.Add("No hay historial todavía");
            }
            txtPantalla.Focus();
            HideCaret(txtPantalla.Handle);
        }
    }
}