using SAPbobsCOM;

namespace OnBusinessOne.DataAccess
{
    public sealed class SBOConnection
    {
        private static SBOConnection instance;
        private static Company SBOCompany;

        private const string Server = "server";
        private const string UserName = "username";
        private const string Password = "password";

        public SBOConnection()
        {
            SBOCompany = new Company();
        }

        public static SBOConnection GetInstance()
        {
            if (SBOCompany == null)
            {
                instance = new SBOConnection();
            }
            return instance;
        }

        public Recordset GetCompaniesRecordset()
        {
            SBOCompany.Server = Server;
            SBOCompany.DbUserName = UserName;
            SBOCompany.DbPassword = Password;
            SBOCompany.DbServerType = BoDataServerTypes.dst_MSSQL2019;
            Recordset companiesRecordset = SBOCompany.GetCompanyList();
            return companiesRecordset;
        }

        public int ConnectToSAP(Domain.Entities.UserAuth authentication)
        {
            SBOCompany.UserName = authentication.UserName;
            SBOCompany.Password = authentication.Password;
            SBOCompany.CompanyDB = authentication.CompanyDB;
            return SBOCompany.Connect();
        }

        public Company GetSBOCompany()
        {
            return SBOCompany;
        }

    }
}
