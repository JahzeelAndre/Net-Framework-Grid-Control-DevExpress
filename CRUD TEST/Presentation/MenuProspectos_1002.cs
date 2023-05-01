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
        private void FillGrid()
        {
            ProspectosvGridControl.DataSource = _ProspectoBAL.ObtenerListaProspectos();
            ProspectosvGridControl.OptionsBehavior.Editable = true;
            ProspectosvGridControl.OptionsBehavior.EditorShowMode = (DevExpress.Utils.EditorShowMode)GridEditingMode.EditForm;
        }
        #endregion
    }
}
