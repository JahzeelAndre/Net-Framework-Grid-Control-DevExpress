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
using CRUD_TEST_CORE.Entities;
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
                gridControlListaProspectos.DataSource = _ProspectoBAL.ObtenerListaProspectos();
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

        public int GetIdProspecto() {
            //Instanciamos clase GridView y asignamos la vista(MainView) del grid.
            GridView gridView = gridControlListaProspectos.MainView as GridView;
            //Verificamos si hay filas seleccionados, si si, se obtiene y manda el Id.
            if (gridView.SelectedRowsCount > 0)
            {
                /*Obtenemos el texto de la celda de la fila y columna específicada con el método GetRowCellDisplayText, de la clase GridView, y le mandamos de argumento
                la posición de la fila seleccionada y la columna 0(Id).*/
                return Convert.ToInt32(gridView.GetRowCellDisplayText(gridView.FocusedRowHandle, gridView.Columns[0]));
            }
            else
            {
                //Se manda 0, porque no se seleccionó ninguna fila.
                return 0;
            }
        }
        #endregion

        #region Events...
        public void Buttons_Clicks(object sender, EventArgs e)
        {
            if (sender == simpleButtonAgregar)
            {
                //Envíamos Id obtenido en el método GetIdProspecto
                AgregarProspecto_1003 agregarProspecto_1003 = new AgregarProspecto_1003(GetIdProspecto());
                agregarProspecto_1003.ShowDialog();
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
                    bool responseDelete = _ProspectoBAL.Delete(new ProspectoInfo { Id = IdProspecto });
                    if (responseDelete)
                    {
                        MessageBox.Show("Producto borrado exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show("El producto no se pudo borrar.");
                    }
                    //Guardo número de filas afectadas en la bd.
                    //int NumeroFilasAfectadas = _ProspectoBAL.DeleteProspecto(IdProspecto);
                    //MessageBox.Show($"Operación exitosa. \nFilas afectadas: {NumeroFilasAfectadas}");
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
            //gridControlListaProspectos.DataSource = _ProspectoBAL.GetListProspectoFilterDate(dateTime);
        }
        #endregion

        private void gridControlListaProspectos_Load(object sender, EventArgs e)
        {
            LlenarGrid();
            GridView gridView = gridControlListaProspectos.MainView as GridView;
            gridView.ClearSelection();
            gridView.DoubleClick += GridView_DoubleClick;
        }
        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            GridView gridView = gridControlListaProspectos.MainView as GridView;
            gridView.UnselectRow(gridView.FocusedRowHandle);
            gridView.ClearSelection();
        }
    }
}
