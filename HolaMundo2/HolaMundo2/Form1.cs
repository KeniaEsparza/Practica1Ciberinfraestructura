using System.Text.RegularExpressions;

namespace HolaMundo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1validar_Click(object sender, EventArgs e)
        {
            Regex validacion = new Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[^\\w+$]).*$");
            if (string.IsNullOrEmpty(txtContrasena1.Text) &&
                string.IsNullOrEmpty(txtContrasena2.Text))
            {
                MessageBox.Show("Los campos estan vacios");
                return;
            }
            //Condicion que valida
            //Si no son iguales los textos contenidos
            //El signo de exclamacion indica negacion
            if (!txtContrasena1.Text.Equals(txtContrasena2.Text))
            {
                MessageBox.Show("Las contrasenas no son iguales");
                return;
            }
            if (validacion.IsMatch(txtContrasena1.Text))
            {
                MessageBox.Show("Las contrasena es VALIDA");
            }
            else
            {
                MessageBox.Show("La contrasena es INVALIDA");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}