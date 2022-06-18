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
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }
        public void cargarlistado()
        {
            Empleado E = new Empleado();
            DataTable dt = new DataTable();

            dt = E.Listar_Empleado();
            try
            {
                grid.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    grid.Rows.Add(imageList1.Images[0]);
                    grid.Rows[i].Cells[1].Value = dt.Rows[i][0].ToString();
                    grid.Rows[i].Cells[2].Value = dt.Rows[i][1].ToString();
                    grid.Rows[i].Cells[3].Value = dt.Rows[i][2].ToString();
                    grid.Rows[i].Cells[4].Value = dt.Rows[i][3].ToString();
                    grid.Rows[i].Cells[5].Value = dt.Rows[i][4].ToString();
                    grid.Rows[i].Cells[6].Value = dt.Rows[i][5].ToString();
                    grid.Rows[i].Cells[7].Value = dt.Rows[i][6].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            grid.ClearSelection();
        }
        private void Empleados_Load(object sender, EventArgs e)
        {
            cargarlistado();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Program.Evento = 0;
            EmpleadosRegistrar E = new EmpleadosRegistrar();
            E.Show();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Program.Evento = 1;
            if (grid.SelectedRows.Count > 0)
            {
                EmpleadosRegistrar P=new EmpleadosRegistrar();
                P.Show();
                P.txbcedula.Text = Convert.ToString(grid.CurrentRow.Cells[2].Value.ToString());
                P.tbxapellidos.Text = grid.CurrentRow.Cells[3].Value.ToString();
                P.tbxnombres.Text = grid.CurrentRow.Cells[4].Value.ToString();
                P.cbxsexo.Text = grid.CurrentRow.Cells[5].Value.ToString();
                P.tbxdireccion.Text = grid.CurrentRow.Cells[6].Value.ToString();
                P.tbxfon.Text = grid.CurrentRow.Cells[7].Value.ToString();
              
            }

            else
            {
                MessageBox.Show("Debe Seleccionar la Fila a Editar.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            Empleado E = new Empleado();
            int id_Empleado;
            if (grid.SelectedRows.Count > 0)
            {
                DialogResult ORe;
                ORe = MessageBox.Show("Al eliminar este Empleado podria afectar otros datos\n\t\tEliminar aun asi", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (ORe == DialogResult.OK)
                {
                    id_Empleado = Convert.ToInt32(grid.CurrentRow.Cells[1].Value);
                    E.Id = id_Empleado;
                    E.EliminarEmpleados ();
                    MessageBox.Show("Eliminado correctamente");
                    cargarlistado();

                }
                else MessageBox.Show("Eliminacion cancelada");

            }
            else
                MessageBox.Show("No se pudo eliminar");
        }
    }
}
