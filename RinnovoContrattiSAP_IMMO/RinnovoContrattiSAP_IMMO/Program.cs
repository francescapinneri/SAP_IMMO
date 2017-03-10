using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RinnovoContrattiSAP_IMMO
{
    class RinnovoAutomatico
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Inizio Rinnovo SAP IMMOBILIARE");
            Rinnovo _oRinnovo = new Rinnovo();

            String risultato =  _oRinnovo.execRinnovo();

            Console.WriteLine(risultato);
            Console.WriteLine("Finito");
        }
    }
}
