using SOLTUM.Framework.Core;
using System;

namespace CRUD_TEST_CORE.Entities
{
    public class ProspectoInfo : IEntity
    {
        #region Properties...
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal NumberPhone { get; set; }
        public bool Client { get; set; }
        public DateTime DateRegister { get; set; }
        #endregion

        #region Database FieldsNames...
        public class FieldsNames
        {
            public const string Id = "Id";

            [Field(FirstName, "FirstName", FieldAttribute.eFieldType.Texto, Length = 50)]
            public const string FirstName = "FirstName";

            [Field(LastName, "LastName", FieldAttribute.eFieldType.Texto, Length = 50)]
            public const string LastName = "LastName";

            [Field(NumberPhone, "NumberPhone", FieldAttribute.eFieldType.Numero)]
            public const string NumberPhone = "NumberPhone";

            [Field(Client, "Client", FieldAttribute.eFieldType.SiNo)]
            public const string Client = "Client";

            [Field(DateRegister, "DateRegister", FieldAttribute.eFieldType.Fecha)]
            public const string DateRegister = "DateRegister";
        }
        #endregion
    }
}
