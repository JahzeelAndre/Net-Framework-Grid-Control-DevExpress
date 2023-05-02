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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTreeList;

namespace CRUD_TEST.Presentation
{
    public partial class MenuProspectos_1002 : Form
    {
        #region Global Variables...
        private readonly ProspectoBAL _ProspectoBAL;
        #endregion

        #region Constructors...
        public MenuProspectos_1002()
        {
            InitializeComponent();
            _ProspectoBAL= new ProspectoBAL{ ConnectionString = Api.Connections.ConnectionStringDataBaseCrudTest };
            FillGrid();
        }
        #endregion

        #region Methods...
        public int GetIdProspecto()
        {
            if (ProspectosvGridControl.GetSelectedRows().Length == 0)
            {
                return 0;
            }
            else
            {
                int IndexColumnaSeleccionada = ProspectosvGridControl.FocusedRecord;
                Console.WriteLine("Columna seleccionada: " + IndexColumnaSeleccionada);
                int IdProspecto = Convert.ToInt32(ProspectosvGridControl.GetCellDisplayText(rowId, IndexColumnaSeleccionada));
                return IdProspecto;
            }
        }
        private void FillGrid()
        {
            ProspectosvGridControl.DataSource = _ProspectoBAL.ObtenerListaProspectos();
            ProspectosvGridControl.OptionsBehavior.Editable = true;
            ProspectosvGridControl.OptionsBehavior.EditorShowMode = (DevExpress.Utils.EditorShowMode)GridEditingMode.EditForm;
            ProspectosvGridControl.UnselectRow(rowId);
            ProspectosvGridControl.ClearSelection();
            
        }

        #endregion

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ProspectosvGridControl.GetSelectedRows().Length > 1)
            {
                MessageBox.Show("Por favor, selecciona solo una fila");
            }
            else
            {
                int IdProspecto = GetIdProspecto();
                AgregarProspecto_1003 agregarProspecto_1003 = new AgregarProspecto_1003(IdProspecto);
                agregarProspecto_1003.ShowDialog();
                FillGrid();
            }
        }
    }
}
