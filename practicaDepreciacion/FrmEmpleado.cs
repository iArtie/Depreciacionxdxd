using AppCore.IServices;
using AppCore.Services;
using Autofac;
using Domain.Entities;
using Domain.Enum;
using Domain.Interfaces;
using Infraestructure.Repository;
using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicaDepreciacion
{
    public partial class FrmEmpleado : Form
    {
        public int index;
        public IEmpleadoServices empleadoServices; /*{ get; set; }*/
        public FrmEmpleado(int index)
        {
            this.index = index;
            InitializeComponent();
        }

        private bool verificarEmp()
        {
            if (String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtApellidos.Text) || String.IsNullOrEmpty(txtCed.Text) || String.IsNullOrEmpty(txtAdress.Text) || String.IsNullOrEmpty(txtPhone.Text) || String.IsNullOrEmpty(txtEmail.Text) || cmbEmpleadoEst == null)
            {

                return false;
            }
            return true;
        }
        private void limpiar()
        {
            this.txtName.Text = String.Empty;
            this.txtApellidos.Text = String.Empty;
            this.txtCed.Text = String.Empty;
            this.txtAdress.Text = String.Empty;
            this.txtPhone.Text = String.Empty;
            this.txtEmail.Text = String.Empty;
            this.cmbEmpleadoEst.Text = String.Empty;
        }
        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void CmbEmpeadoEst_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            try
            {
                dataEmpleado.DataSource = empleadoServices.Read();
            }
            catch (NullReferenceException)
            {
                
            }
            cmbEmpleadoEst.DataSource = Enum.GetValues(typeof(EstadoEmpleado));
        }

        private void TxtName_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No puede introducir numeros");
            }

        }

        private void TxtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No puede introducir numeros");
            }
        }

        private void TxtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No puede introducir letras");
            }
        }

        private void BtnEmpleadoEnv_Click(object sender, EventArgs e)
        {
            bool verificado = verificarEmp();
            if (verificado == false)
            {
                MessageBox.Show("Tienes que llenar todos los formularios.");
            }
            else
            {
                EstadoEmpleado d = (EstadoEmpleado)Enum.GetValues(typeof(EstadoEmpleado)).GetValue(cmbEmpleadoEst.SelectedIndex);
                Empleado empleado = new Empleado()
                {
                    Nombres = txtName.Text,
                    Apellidos = txtApellidos.Text,
                    Cedula = txtCed.Text,
                    Direccion = txtAdress.Text,
                    Telefono = int.Parse(txtPhone.Text),
                    email = txtEmail.Text,
                    Estado = d.ToString()

                };
                //try
                //{
                //    empleadoServices.Add(empleado);
                //    dataEmpleado.DataSource = null;
                //    limpiar();
                //    dataEmpleado.DataSource = empleadoServices.Read();
                //}
                //catch (NullReferenceException)
                //{

                //}
                empleadoServices.Add(empleado);
                dataEmpleado.DataSource = null;
                limpiar();
                dataEmpleado.DataSource = empleadoServices.Read();

            }
        }
    }
}
