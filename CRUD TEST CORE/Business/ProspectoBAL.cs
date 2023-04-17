using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CRUD_TEST_CORE.Business
{
    public class ProspectoBAL
    {
        #region Global Variables...
        private readonly Data.ProspectoDAL _ProspectoDAL;
        #endregion

        #region Constructors...
        public ProspectoBAL()
        {
            _ProspectoDAL = new Data.ProspectoDAL();
        }
        #endregion

        #region Properties...
        public string ConnectionString
        {
            get 
            { 
                return _ProspectoDAL.ConnectionString; 
            }
            set 
            {
                _ProspectoDAL.ConnectionString = value;
            }
        }
        #endregion

        #region Methods...
        public Entities.ProspectoInfo GetProspecto(int Id)
        {
            return _ProspectoDAL.GetProspecto(Id);
        }

        public List<Entities.ProspectoInfo> GetListProspectos()
        {
            Thread.Sleep(1000);
            return _ProspectoDAL.GetListProspectos();
        }

        public List<Entities.ProspectoInfo> GetListProspectoFilterDate(DateTime date)
        {
            return _ProspectoDAL.GetListProspectosFilterDate(date);
        }

        public int AddProspecto(Entities.ProspectoInfo Prospecto)
        {
            Thread.Sleep(1000);
            return _ProspectoDAL.AddProspecto(Prospecto);
        }

        public int DeleteProspecto(int Id)
        {
            Thread.Sleep(1000);
            return _ProspectoDAL.DeleteProspecto(Id);
        }
        #endregion
    }
}
