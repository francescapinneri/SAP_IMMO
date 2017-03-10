using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace RinnovoContrattiSAP_IMMO
{
    class Connessione
    {

    
        public static SAPbobsCOM.Company getConnessione()
        {

            SAPbobsCOM.Company c;
            c = new SAPbobsCOM.Company();
            c.Server = ConfigurationManager.AppSettings["Server"].ToString();
            c.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_HANADB;
            c.LicenseServer = ConfigurationManager.AppSettings["LicenseServer"].ToString();
            c.DbUserName = ConfigurationManager.AppSettings["DbUserName"].ToString();
            c.DbPassword = ConfigurationManager.AppSettings["DbPassword"].ToString();
            c.UserName = ConfigurationManager.AppSettings["UserName"].ToString();
            c.Password = ConfigurationManager.AppSettings["Password"].ToString();
            c.CompanyDB = ConfigurationManager.AppSettings["CompanyDB"].ToString();
            c.Connect();

            return c;
        }

       
    }
}
