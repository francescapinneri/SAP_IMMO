using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RinnovoContrattiSAP_IMMO
{
    class Rinnovo
    {
        public SAPbobsCOM.Company c;

        public Rinnovo() {

            c = Connessione.getConnessione();
        }

        public string execRinnovo() {

  

            string _q = @"select ""CardCode"", ""DocEntry"", ""U_Perc_Fat1"", ""U_Imp_Fat1"", ""GrosProfit"", ""DocTotal"", ""VatSum""
                             from ""ORDR"" where ""DocStatus"" = 'O' and  ""Confirmed"" = 'Y' and(""U_Stato_Fat1"" = 0 or ""U_Stato_Fat1"" = 2)
                             and ""U_Data_Fat1"" <= '2017-01-31'; ";

            SAPbobsCOM.Recordset oRecordSet;
            oRecordSet = (SAPbobsCOM.Recordset)c.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);


            oRecordSet.DoQuery(_q);


            Console.WriteLine(oRecordSet.RecordCount);

            c.Disconnect();


            return "";
        }
    }
}
