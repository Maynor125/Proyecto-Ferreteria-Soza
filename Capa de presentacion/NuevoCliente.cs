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
    public partial class NuevoCliente : Form
    {
        Clientee c = new Clientee();
        
        public NuevoCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NuevoCliente_Load(object sender, EventArgs e)
        {
            cbxsexo.Items.Add("F");
            cbxsexo.Items.Add("M");
            cbxsexo.Items.Add("X");
            tbxnonbreclient.Focus();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (tbxnonbreclient.Text.Length != 0)
            {
                if (tbxnonbreclient.Text.Length != 0)
                {
                    errorProvider1.SetError(tbxnonbreclient, "");
                }
                if (tbxapellido.Text.Length != 0)
                {
                    if (tbxapellido.Text.Length != 0)
                    {
                        errorProvider1.SetError(tbxapellido, "");
                    }
                    if (tbxCedula.Text.Length != 0)
                    {
                        if (tbxCedula.Text.Length != 0)
                        {
                            errorProvider1.SetError(tbxCedula, "");
                        }
                        if (cbxsexo.Text.Length != 0)
                        {
                            if (cbxsexo.Text.Length != 0)
                            {
                                errorProvider1.SetError(cbxsexo, "");
                            }
                            if (txbxciudad.Text.Length != 0)
                            {
                                if (txbxciudad.Text.Length != 0)
                                {
                                    errorProvider1.SetError(txbxciudad, "");
                                }
                                if (tbxbarrio.Text.Length != 0)
                                {
                                    if (tbxbarrio.Text.Length != 0)
                                    {
                                        errorProvider1.SetError(tbxbarrio, "");
                                    }
                                    if (Program.Evento == 0)
                                    {
                                        c.Nombres = tbxnonbreclient.Text;
                                        c.Apellidos = tbxapellido.Text;
                                        c.Cedula = tbxCedula.Text;
                                        c.Sexo = Convert.ToString(cbxsexo.SelectedItem.ToString());
                                        c.Ciudad = txbxciudad.Text;
                                        c.Barrio = tbxbarrio.Text;
                                        c.Telefono = tbxtelefono.Text;
                                        c.RegistrarCliente();
                                        Clientes t = new Clientes();                                        
                                        bunifuSnackbar1.Show(t, "Cliente agregado exitosamente");
                                        t.CargarListado();
                                       
                                        
                                        this.Visible = false;
                                    }
                                    else if(Program.Evento == 1)
                                    {
                                        c.Id_Cliente = Convert.ToInt32(tbxid.Text);
                                        c.Nombres = tbxnonbreclient.Text;
                                        c.Apellidos = tbxapellido.Text;
                                        c.Cedula = tbxCedula.Text;
                                        c.Sexo = Convert.ToString(cbxsexo.SelectedItem.ToString());
                                        c.Ciudad = txbxciudad.Text;
                                        c.Barrio = tbxbarrio.Text;
                                        c.Telefono = tbxtelefono.Text;
                                        c.AtualizarCliente();
                                        Clientes t = new Clientes();  
                                       t.CargarListado();                                      
                                        bunifuSnackbar1.Show(t, "Cliente actualizado exitosamente");
                                       
                                        
                                        this.Visible = false;
                                    }                               
                                }
                                else
                                {
                                    errorProvider1.SetError(tbxbarrio, "No se Haceptan valores vacios");
                                }

                            }
                            else
                            {
                                errorProvider1.SetError(txbxciudad, "No se Haceptan valores vacios");
                            }

                        }
                        else
                        {
                            errorProvider1.SetError(cbxsexo, "No se Haceptan valores vacios");
                        }

                    }
                    else
                    {
                        errorProvider1.SetError(tbxCedula, "No se Haceptan valores vacios");
                    }

                }
                else
                {
                    errorProvider1.SetError(tbxapellido, "No se Haceptan valores vacios");
                }
            }
            else
            {
                errorProvider1.SetError(tbxnonbreclient, "No se Haceptan valores vacios");
            }
        }
    }
}
