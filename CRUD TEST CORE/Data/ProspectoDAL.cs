using CRUD_TEST_CORE.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLTUM.Framework.Data;

namespace CRUD_TEST_CORE.Data
{
    public class ProspectoDAL : TableBaseDAL<ProspectoInfo, ProspectoInfo.FieldsNames>
    {
        #region Properties...
        //public string ConnectionString { get; set; }
        #endregion

        #region Global Variables...
        //private readonly Utilities.SQL_Helper _SqlHelper;
        #endregion

        #region Constructors...
        public ProspectoDAL() : base() {
            TableName = "TablaProspectos";
            //MaestraDAL = new SOLTUM.Framework.Data.MaestraDAL().ConnectionString;
            //_SqlHelper = new Utilities.SQL_Helper();
        }
        #endregion

        #region Methods...
        ///// <summary>
        ///// Método para obtener un prospecto.
        ///// </summary>
        ///// <param name="Id"></param>
        ///// <returns>Devuelve un valor ProspectoInfo, resultante del comando sql.</returns>
        //public ProspectoInfo GetProspecto(int Id) 
        //{
        //    DataTable TablaProspectos = _SqlHelper.GetDataTable(ConnectionString, $"select * from TablaProspectos where {ProspectoInfo.FieldsNames.Id} = ${Id}");
        //    return GetProspecto(TablaProspectos.Rows[0]);

        //}
        ///// <summary>
        ///// Método para obtener un prospecto.
        ///// </summary>
        ///// <param name="dataRow"></param>
        ///// <returns>Devuelve un valor ProspectoInfo, resultante del DataRow mandado.</returns>
        //public ProspectoInfo GetProspecto(DataRow dataRow)
        //{
        //    ProspectoInfo prospecto = new ProspectoInfo
        //    {
        //        Id = Convert.ToInt32(dataRow[ProspectoInfo.FieldsNames.Id]),
        //        FirstName = dataRow[ProspectoInfo.FieldsNames.FirstName].ToString(),
        //        LastName = dataRow[ProspectoInfo.FieldsNames.LastName].ToString(),
        //        NumberPhone = Convert.ToDecimal(dataRow[ProspectoInfo.FieldsNames.NumberPhone]),
        //        Client = Convert.ToBoolean(dataRow[ProspectoInfo.FieldsNames.Client]),
        //        DateRegister = dataRow[ProspectoInfo.FieldsNames.DateRegister].ToString(),
        //    };
        //    return prospecto;
        //}
        ///// <summary>
        ///// Método para obtener una lista de prospectos.
        ///// </summary>
        ///// <returns>Devuelve un valor List<ProspectoInfo>, resultante del comando sql.</returns>
        //public List<ProspectoInfo> GetListProspectos()
        //{
        //    List<ProspectoInfo> ListaProspectos = new List<ProspectoInfo>();
        //    DataTable TablaProspectos = _SqlHelper.GetDataTable(ConnectionString, $"select * from TablaProspectos");
        //    foreach (DataRow Row in TablaProspectos.Rows)
        //    {
        //        ListaProspectos.Add(GetProspecto(Row));
        //    }
        //    return ListaProspectos;
        //}

        //public List<ProspectoInfo> GetListProspectosFilterDate(DateTime date)
        //{
        //    List<ProspectoInfo> ListaProspectos = new List<ProspectoInfo>();
        //    StringBuilder CommandStringBuilder = new StringBuilder();
        //    CommandStringBuilder.AppendLine("set language spanish;");
        //    CommandStringBuilder.AppendLine($"select * from TablaProspectos where DateRegister between convert(date, '{date.ToShortDateString()}') and convert(date, '{date.AddDays(1).ToShortDateString()}');");
        //    /*
        //     new List<SOLTUM.Framework.Data.Attributes.Condition>()
        //        {
        //            new SOLTUM.Framework.Data.Attributes.Condition($"DataRegister", "between", $"converter(date, '{date.ToShortDateString()}') and converter(date, '{date.AddDays(1).ToShortDateString()}')"),
        //        }
        //     */
        //    DataTable TablaProspectos = _SqlHelper.GetDataTable(ConnectionString, CommandStringBuilder.ToString());
        //    foreach (DataRow Row in TablaProspectos.Rows)
        //    {
        //        ListaProspectos.Add(GetProspecto(Row));
        //    }
        //    return ListaProspectos;
        //}

        ///// <summary>
        ///// Método para agregar un nuevo prospecto a la base de datos.
        ///// </summary>
        ///// <param name="Prospecto"></param>
        ///// <returns>Devuelvo un valor int, resultante de las filas afectadas por el comando.</returns>
        //public int AddProspecto(ProspectoInfo Prospecto)
        //{
        //    string CommandString = $"insert into TablaProspectos ({ProspectoInfo.FieldsNames.FirstName}, {ProspectoInfo.FieldsNames.LastName}, {ProspectoInfo.FieldsNames.NumberPhone}, {ProspectoInfo.FieldsNames.Client}, {ProspectoInfo.FieldsNames.DateRegister}) " +
        //        $"values ('{Prospecto.FirstName}', '{Prospecto.LastName}', {Prospecto.NumberPhone}, {Convert.ToInt32(Prospecto.Client)}, GETDATE())";
        //    return _SqlHelper.ExecuteANonQuery(ConnectionString, CommandString);
        //}

        //public int DeleteProspecto(int Id)
        //{
        //    string CommandString = $"delete from TablaProspectos where {ProspectoInfo.FieldsNames.Id}={Id}";
        //    return _SqlHelper.ExecuteANonQuery(ConnectionString, CommandString);
        //}
        #endregion
    }
}
