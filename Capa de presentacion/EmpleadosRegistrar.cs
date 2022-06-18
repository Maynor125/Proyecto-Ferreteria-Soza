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
    public partial class EmpleadosRegistrar : Form
    {
        public EmpleadosRegistrar()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            
            if (txbcedula.Text.Length != 0)
            {
                if (txbcedula.Text.Length != 0)
                {
                    errorProvider1.SetError(txbcedula, "");
                }
                if (tbxapellidos.Text.Length != 0)
                {
                    if (tbxnombres.Text.Length != 0)
                    {
                        errorProvider1.SetError(tbxnombres, "");
                    }
                    if (cbxsexo.Text.Length != 0)
                    {
                        if (tbxdireccion.Text.Length != 0)
                        {
                            if (tbxfon.Text.Length != 0)
                            {
                                errorProvider1.SetError(tbxfon, "");
                                if (Program.Evento == 0)
                                {

                                    Empleado Variable = new Empleado();
                                    Variable.Cedula = txbcedula.Text;
                                    Variable.Apellidos = tbxapellidos.Text;
                                    Variable.Nombres = tbxnombres.Text;
                                    Variable.Sexo = cbxsexo.SelectedValue.ToString();
                                    Variable.Direccion = tbxdireccion.Text;
                                    Variable.Telefono = tbxfon.Text;


                                    Variable.RegistrarEmpleados();

                                    Empleados Variable3 = new Empleados();
                                    Variable3.cargarlistado();
                                    this.Visible = false;
                                    bunifuSnackbar1.Show(Variable3, "Producto agregado exitosamente");
                                }
                                else if(Program.Evento==1)
                                {
                                    Empleado Variable = new Empleado();
                                    Variable.Cedula = txbcedula.Text;
                                    Variable.Apellidos = tbxapellidos.Text;
                                    Variable.Nombres = tbxnombres.Text;
                                    Variable.Sexo = cbxsexo.SelectedValue.ToString();
                                    Variable.Direccion = tbxdireccion.Text;
                                    Variable.Telefono = tbxfon.Text;


                                    Variable.ActualizarEmpleados();

                                    Empleados Variable3 = new Empleados();
                                    Variable3.cargarlistado();
                                    this.Visible = false;
                                    bunifuSnackbar1.Show(Variable3, "Producto agregado exitosamente");
                                }
                            }

                          
                            else
                            {
                                errorProvider1.SetError(txbcedula, "No se Haceptan valores vacios");
                            }

                        }
                        else
                        {
                            errorProvider1.SetError(tbxapellidos, "No se Haceptan valores vacios");
                        }

                    }
                    else
                    {
                        errorProvider1.SetError(tbxnombres, "No se Haceptan valores vacios");
                    }

                }
                else
                {
                    errorProvider1.SetError(tbxdireccion, "No se Haceptan valores vacios");
                }

            }
        }
    }
}
