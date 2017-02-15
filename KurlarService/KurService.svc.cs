using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace KurlarService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "KurService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select KurService.svc or KurService.svc.cs at the Solution Explorer and start debugging.
    public class KurService : IKurService
    {
        public List<double> KurlariGetir(string kurTipi)
        {
            Random RandomKur = new Random();
            List<double> kurlarListesi = new List<double>();
            for (int i = 0; i < 15; i++)
            {
                kurlarListesi.Add(RandomKur.NextDouble() + 3); //NextDouble'da 0 ile 1 arasi bir random sayi uretilir.
            }
            return kurlarListesi;
        }

        public List<string> ParaBirimleriGetir()
        {
            List<string> ParaBirimleri = new List<string>();
            ParaBirimleri.Add("Japon Yeni");
            ParaBirimleri.Add("Dolar");
            ParaBirimleri.Add("Euro");
            ParaBirimleri.Add("Pound");
            return ParaBirimleri;
        }
    }
}
