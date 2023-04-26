//Librerías internas
using System.Collections.Generic;
using System.Linq;
//Librerías externas
using CRUD_TEST_CORE.Data;
using CRUD_TEST_CORE.Entities;
using SOLTUM.Framework.Business;
using SOLTUM.Framework.Data.Attributes;


namespace CRUD_TEST_CORE.Business
{
    public class ProspectoBAL : TableBaseBAL<ProspectoInfo, ProspectoDAL>
    {
        #region Global Variables...
        //private readonly Data.ProspectoDAL _ProspectoDAL;
        #endregion

        #region Constructors...
        public ProspectoBAL()
        {
            //_ProspectoDAL = new Data.ProspectoDAL();
        }
        #endregion

        #region Properties...
        //public string ConnectionString
        //{
        //    get => DataAccessLayer.ConnectionString;
        //    set { DataAccessLayer.ConnectionString = value; }
        //}
        #endregion

        #region Methods...
        
        public List<ProspectoInfo> ObtenerListaProspectos()
        {
            return DataAccessLayer.GetEntityObjects().ToList();
        }

        //public Entities.ProspectoInfo GetProspecto(int Id)
        //{
        //    return _ProspectoDAL.GetProspecto(Id);
        //}

        //public List<Entities.ProspectoInfo> GetListProspectos()
        //{
        //    Thread.Sleep(1000);
        //    return _ProspectoDAL.GetListProspectos();
        //}

        //public List<Entities.ProspectoInfo> GetListProspectoFilterDate(DateTime date)
        //{
        //    return _ProspectoDAL.GetListProspectosFilterDate(date);
        //}

        //public int AddProspecto(Entities.ProspectoInfo Prospecto)
        //{
        //    Thread.Sleep(1000);
        //    return _ProspectoDAL.AddProspecto(Prospecto);
        //}

        //public int DeleteProspecto(int Id)
        //{
        //    Thread.Sleep(1000);
        //    return _ProspectoDAL.DeleteProspecto(Id);
        //}
        #endregion
    }
}
