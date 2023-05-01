using CRUD_TEST_CORE.Business;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_TEST.Presentation
{
    public partial class AgregarProspecto_1003 : Form
    {
        #region Global Variables...
        int Id;
        private readonly ProspectoBAL _ProspectoBAL;
        #endregion


        #region Constructors...
        public AgregarProspecto_1003(int Id)
        {
            InitializeComponent();
            _ProspectoBAL = new ProspectoBAL { ConnectionString = Api.Connections.ConnectionStringDataBaseCrudTest };
            this.Id = Id;
            InitComponents();
        }
        #endregion

        #region Methods...
        public void InitComponents()
        {
            FillGrid();
        }
        public void FillGrid()
        {
            GridView gridView = gridControlProspecto.MainView as GridView;
            if (Id > 0)
            {
                gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                gridControlProspecto.DataSource = _ProspectoBAL.ObtenerProspecto(Id);
            }
            else
            {
                gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;
            }
        }
        #endregion

        #region Events...
        private void barButtonItemGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GridView gridView = gridControlProspecto.MainView as GridView;
            //Verificando que haya agregado filas nuevas para agregar objetos nuevos.
            if (gridView.RowCount > 0)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    //Recorre las filas agregadas al grid.
                    for (int i = 0; i < gridView.RowCount; i++)
                    {
                        //Ejecuta el método guardar.
                        _ProspectoBAL.Save
                            (
                            //Crea objetos nuevos para agregar.
                                new CRUD_TEST_CORE.Entities.ProspectoInfo
                                {
                                    Id = Id,
                                    FirstName = gridView.GetRowCellDisplayText(i, gridView.Columns[1]),
                                    LastName = gridView.GetRowCellDisplayText(i, gridView.Columns[2]),
                                    NumberPhone = Convert.ToDecimal(gridView.GetRowCellDisplayText(i, gridView.Columns[3])),
                                    Client = Convert.ToBoolean(gridView.GetRowCellValue(i, gridView.Columns[4])),
                                    DateRegister = DateTime.Now,
                                }
                            );
                    }
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
            else
            {
                MessageBox.Show("Ingrese una fila nueva.");
            }
            
        }
        #endregion
    }
}
