namespace Ejercicio_Login
{
    public partial class Form1 : Form
    {
        public string ContraseniaUsuario;
        public string UsuarioUsuario;
        public Form1()
        {

            InitializeComponent();
            ContraseniaUsuario = "1234";
            UsuarioUsuario = "John";
        }

        private void BtnAcept_Click(object sender, EventArgs e)
        {
            //comprobations
            if (TxtUsuario.Text == string.Empty || TxtPass.Text== string.Empty)
            {
                MessageBox.Show("Nombre o contrasenia vacios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //comprobations
                if (TxtUsuario.Text == UsuarioUsuario && TxtPass.Text == ContraseniaUsuario)
                {
                    MessageBox.Show("Login exitoso", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Nombre o contrasenia incorrectos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

            
        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
