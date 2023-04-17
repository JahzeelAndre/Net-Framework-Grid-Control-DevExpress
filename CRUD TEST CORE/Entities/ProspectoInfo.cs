using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_TEST_CORE.Entities
{
    public class ProspectoInfo
    {
        #region Properties...
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal NumberPhone { get; set; }
        public bool Client { get; set; }
        public string DateRegister { get; set; }
        #endregion

        #region Database FieldsNames...
        public class FieldsNames
        {
            public const string Id = "Id";
            public const string FirstName = "FirstName";
            public const string LastName = "LastName";
            public const string NumberPhone = "NumberPhone";
            public const string Client = "Client";
            public const string DateRegister = "DateRegister";
        }
        #endregion
    }
}
