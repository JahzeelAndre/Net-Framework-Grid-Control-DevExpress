using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD_TEST_CORE.Business;
using CRUD_TEST_CORE.Entities;

namespace CRUD_TEST.Presentation
{
    public partial class AgregarProspecto_1001 : Form
    {
        #region Global Variables...
        private readonly ProspectoBAL _ProspectoBAL;
        #endregion

        #region Constructors...
        public AgregarProspecto_1001()
        {
            InitializeComponent();
            _ProspectoBAL = new ProspectoBAL { ConnectionString = Api.Connections.ConnectionStringDataBaseCrudTest };
            InitComponents();
        }
        #endregion

        #region Methods...
        public void InitComponents()
        {
            simpleButtonAgregar.Click += Buttons_Clicks;
        }
        public void AgregarProspecto()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                int NumeroFilasAfectadas = _ProspectoBAL.AddProspecto(new ProspectoInfo
                {
                    FirstName = textEditFirstName.Text,
                    LastName = textEditLastName.Text,
                    NumberPhone = Convert.ToDecimal(textEditTelefono.Text),
                    Client = checkEditCliente.Checked,
                });
                MessageBox.Show($"Operación exitosa. \nFilas afectadas: {NumeroFilasAfectadas}");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        #endregion

        #region Events...
        public void Buttons_Clicks(object sender, EventArgs e)
        {
            if (sender == simpleButtonAgregar)
            {
                AgregarProspecto();
            }
        }
        #endregion
    }
}
