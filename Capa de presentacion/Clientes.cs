using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Logica_Del_Negocio;

namespace Capa_de_presentacion
{
    public partial class Clientes : Form
    {
        Clientee C = new Clientee();
        
        
        public Clientes()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            CargarListado();
        }
        public void CargarListado()
        {
            DataTable dt  = C.Listar_Clientes();
            try
            {
                grid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            NuevoCliente cliente = new NuevoCliente();
            Program.Evento = 0;
            cliente.Show();

            CargarListado();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (grid.SelectedRows.Count > 0)
            {
                NuevoCliente P = new NuevoCliente();
                P.tbxid.Text = (grid.CurrentRow.Cells["Id_Cliente"].Value.ToString());
                P.tbxnonbreclient.Text = Convert.ToString(grid.CurrentRow.Cells["Nombres"].Value.ToString());
                P.tbxapellido.Text = grid.CurrentRow.Cells["Apellidos"].Value.ToString();
                P.tbxCedula.Text = grid.CurrentRow.Cells["Cedula"].Value.ToString();
                P.cbxsexo.SelectedValue = grid.CurrentRow.Cells["Sexo"].Value.ToString();
                P.txbxciudad.Text = grid.CurrentRow.Cells["Ciudad"].Value.ToString();
                P.tbxbarrio.Text = grid.CurrentRow.Cells["Barrio"].Value.ToString();
                P.tbxtelefono.Text = grid.CurrentRow.Cells["Telefono"].Value.ToString();
                P.tbxnonbreclient.Focus();
                P.Show(); 
                Program.Evento = 1;
                CargarListado();
            }
            else
            {
                MessageBox.Show("Debe Seleccionar la Fila a Editar.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Program.Evento = 0;
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if (grid.SelectedRows.Count > 0)
            {
                DialogResult ORe;
                ORe = MessageBox.Show("Al eliminar este cliente podria afectar otras tablas\n\t\tEliminar aun asi", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (ORe == DialogResult.OK)
                {
                    C.Id_Cliente = Convert.ToInt32(grid.CurrentRow.Cells["Id_cliente"].Value);
                    C.EliminarCliente();
                    MessageBox.Show("Eliminado correctamente");
                    CargarListado();

                }
                else MessageBox.Show("Eliminacion cancelada");

            }
            else
                MessageBox.Show("Seleccione una fila");
        }
    }
}
