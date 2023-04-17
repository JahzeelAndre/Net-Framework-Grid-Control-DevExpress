using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CRUD_TEST_CORE.Business;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace CRUD_TEST.Presentation
{
    public partial class MenuProspectos_1001 : Form
    {
        #region Global Variables...
        private readonly ProspectoBAL _ProspectoBAL;
        #endregion

        #region Constructors...
        public MenuProspectos_1001()
        {
            InitializeComponent();
            _ProspectoBAL = new ProspectoBAL { ConnectionString = Api.Connections.ConnectionStringDataBaseCrudTest };
            InitComponents();
        }
        #endregion

        #region Methods...
        public void InitGlobalVariables()
        {
            
        }

        public void InitComponents()
        {
            LlenarGrid();
            dateTimeOffsetEdit.Closed += DateTimeOffsetEdit_Closed;
            
        }

        public void LlenarGrid()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                gridControlListaProspectos.DataSource = _ProspectoBAL.GetListProspectos();
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
                AgregarProspecto_1001 agregarProspecto_1001 = new AgregarProspecto_1001();
                agregarProspecto_1001.ShowDialog();
                LlenarGrid();
            }
            else if (sender == simpleButtonEliminar)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    //Obtenemos la vista principal del gridControl.
                    GridView VistaPrincipal = gridControlListaProspectos.MainView as GridView;
                    //Obtener la columna 0, que es la del Id
                    GridColumn ColumnaId = VistaPrincipal.Columns[0];
                    //Obtengo la posición de la fila seleccionada en el gridControl.
                    int PosicionFilaSeleccionada = VistaPrincipal.FocusedRowHandle;
                    //Obtengo el texto de la celda en la fila y columna específicada.
                    int IdProspecto = Convert.ToInt32(VistaPrincipal.GetRowCellDisplayText(PosicionFilaSeleccionada, ColumnaId));
                    //Guardo número de filas afectadas en la bd.
                    int NumeroFilasAfectadas = _ProspectoBAL.DeleteProspecto(IdProspecto);
                    MessageBox.Show($"Operación exitosa. \nFilas afectadas: {NumeroFilasAfectadas}");
                    LlenarGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
        }
        private void DateTimeOffsetEdit_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            string dateText = dateTimeOffsetEdit.Text;
            DateTime dateTime = DateTime.Parse(dateText);
            //gridControlListaProspectos.DataSource = _ProspectoBAL.GetListProspectoFilterDate(SqlDateTime.Parse(dateTimeOffsetEdit.Text));
            gridControlListaProspectos.DataSource = _ProspectoBAL.GetListProspectoFilterDate(dateTime);
        }
        #endregion
    }
}
