using CRUD_TEST_CORE.Business;
using CRUD_TEST_CORE.Entities;
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
    public partial class AgregarProspecto_1004 : Form
    {
        int Id;
        private readonly ProspectoBAL _ProspectoBAL;
        public AgregarProspecto_1004(int Id)
        {
            InitializeComponent();
            this.Id = Id;
            _ProspectoBAL = new ProspectoBAL { ConnectionString = Api.Connections.ConnectionStringDataBaseCrudTest };
            InitComponents();
        }

        public void InitComponents()
        {
            LLenarGrid();
        }

        public void LLenarGrid()
        {
            if (Id > 0)
            {
                vGridControl1.DataSource = _ProspectoBAL.ObtenerProspecto(Id);
            }
            else
            {
                List<ProspectoInfo> prospectoInfos = new List<ProspectoInfo>
                {
                    new ProspectoInfo
                    {
                        Id = 0,
                        FirstName = "",
                        LastName = "",
                        NumberPhone = 0,
                        Client = false,
                        DateRegister = DateTime.Now,
                    }
                };
                vGridControl1.DataSource = prospectoInfos;
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int NuevoId = _ProspectoBAL.Save(
                new ProspectoInfo
                {
                    Id = Convert.ToInt32(vGridControl1.GetCellDisplayText(rowId, 0)),
                    FirstName = vGridControl1.GetCellDisplayText(rowFirstName,0),
                    LastName = vGridControl1.GetCellDisplayText(rowLastName,0),
                    NumberPhone = Convert.ToDecimal(vGridControl1.GetCellDisplayText(rowNumberPhone, 0)),
                    Client = Convert.ToBoolean(vGridControl1.GetCellValue(rowClient, 0)),
                    DateRegister = DateTime.Now,
                }
                );
            if (Id > 0)
            {
                MessageBox.Show($"Prospecto actualizado correctamente con Id {NuevoId}");
            }
            else
            {
                MessageBox.Show($"Prospecto agregado correctamente con Id {NuevoId}");
            }
        }
    }
}
