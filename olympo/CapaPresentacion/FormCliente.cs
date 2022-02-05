
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FormCliente : Form
    {
        CN_Cliente objCN = new CN_Cliente();

        private string idCliente = null;
        private bool Editar = false;

       
        public FormCliente()
        {
            InitializeComponent();
        }

  

     

     

      

        private void FormCliente_Load(object sender, EventArgs e)
        {
            MostrarClientes();

        }

        private void MostrarClientes()
        {
            CN_Cliente objeto = new CN_Cliente();
            dataGridView1.DataSource = objeto.MostrarClie();
        }

        private void FormCliente_Load_1(object sender, EventArgs e)
        {
            MostrarClientes();

        }
    }
}