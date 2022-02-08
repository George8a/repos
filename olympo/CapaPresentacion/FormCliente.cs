
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

  

     

     

      

      

        private void MostrarClientes()
        {
            CN_Cliente objeto = new CN_Cliente();
            dataGridView1.DataSource = objeto.MostrarClie();
        }
        private void limpiarForm()
        {
            cmbBoxTipoDoc.Text = "";
            txtboxDocumento.Clear();
            txtbox1erNombre.Clear();
            txtbox2Nombre.Clear();
            txtbox1Apellido.Clear();
            txtbox2Apellido.Clear();
            txtboxDireccion.Clear();
            txtboxCorreo.Clear();
            txtboxTelefono.Clear();
            txtboxContactoEmergecia.Clear();
            txtboxTelefonoContacto.Clear();
            txtboxObservacionesMedicas.Clear();


        }

        private void FormCliente_Load_1(object sender, EventArgs e)
        {
            MostrarClientes();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    objCN.InsertarClie(txtboxDocumento.Text, cmbBoxTipoDoc.SelectedItem.ToString(), txtbox1erNombre.Text, txtbox2Nombre.Text, txtbox1Apellido.Text, txtbox2Apellido.Text, txtboxDireccion.Text, txtboxCorreo.Text, txtboxTelefono.Text, txtboxContactoEmergecia.Text, txtboxTelefonoContacto.Text, textBox1.Text, txtboxObservacionesMedicas.Text);
                    MessageBox.Show("Se guardar correctamente", "Guardar");
                    MostrarClientes();
                    limpiarForm();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("No se puedo guardar por: " + ex);
                }
            }
            if(Editar == true)
            {
                try
                {
                    objCN.EditarClie(txtboxDocumento.Text, cmbBoxTipoDoc.SelectedIndex.ToString(), txtbox1erNombre.Text, txtbox2Nombre.Text, txtbox1Apellido.Text, txtbox2Apellido.Text, txtboxDireccion.Text, txtboxCorreo.Text, txtboxTelefono.Text, txtboxContactoEmergecia.Text, txtboxTelefonoContacto.Text, textBox1.Text, txtboxObservacionesMedicas.Text, txtboxObservacionesMedicas.Text);
                    MessageBox.Show("Se actualizo correctamente");
                    MostrarClientes();
                    limpiarForm();
                    Editar = false;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("no puedo actualizar los datos por :" + ex);
                }
                   
            }
        }
    }
}