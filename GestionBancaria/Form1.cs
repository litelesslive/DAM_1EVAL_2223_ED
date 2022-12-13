namespace GestionBancaria
{
    public partial class Form1 : Form
    {
        private double saldodamirGrim1dam = 1000;  // Saldo inicial de la cuenta, 1000�

        public Form1()
        {
            InitializeComponent();
            txtSaldo.Text = saldodamirGrim1dam.ToString();
            txtCantidad.Text = "0";
        }

        private bool realizarReintegro(double cantidadgrimaylo2)
        {
            if (cantidadgrimaylo2 > 0 && saldodamirGrim1dam >= cantidadgrimaylo2) //Si saldo = cantidad no puedes sacarlo
            {
                saldodamirGrim1dam -= cantidadgrimaylo2;
                txtSaldo.Text = saldodamirGrim1dam.ToString();
                return true;
            }
            else
            {
                return false;
            }
        }

        private void realizarIngreso(double cantidadgrimaylo2)
        {
            if (cantidadgrimaylo2 > 0)
                saldodamirGrim1dam += cantidadgrimaylo2;
        }

        private void btOperar_Click(object sender, EventArgs e)
        {
            double cantidadgrimaylo2 = Convert.ToDouble(txtCantidad.Text); // Cogemos la cantidad del TextBox y la pasamos a n�mero
            if (rbReintegro.Checked)
            {  //Si cantidad es  0 no dice el error.
                    if (cantidadgrimaylo2 <= 0) //Si cantidad es  0 no dice el error.
                    {
                        MessageBox.Show("Cantidad no v�lid�, s�lo se admiten cantidades positivas.");
                    }
                    else
                    {
                        if (realizarReintegro(cantidadgrimaylo2) == false)
                        { // No se ha podido completar la operaci�n, saldo insuficiente?
                            MessageBox.Show("No se ha podido realizar la operaci�n (�Saldo insuficiente?)");
                    }
                }
            }
            else
            {
                if (cantidadgrimaylo2 <= 0) //Si cantidad es  0 no dice el error.
                {
                    MessageBox.Show("Cantidad no v�lid�, s�lo se admiten cantidades positivas.");
                }

                else
                {

                    realizarIngreso(cantidadgrimaylo2);
                    txtSaldo.Text = saldodamirGrim1dam.ToString();
                }
            }
           

        }
    }
}