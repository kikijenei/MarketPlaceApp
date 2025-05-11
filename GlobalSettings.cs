using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Resources;
using System.Threading;


namespace Proiect2
{
    public static class GlobalSettings
    {
        public static CultureInfo CurrentCulture { get; private set; } = CultureInfo.InvariantCulture;
        public static ResourceManager ResourceManager { get; private set; } =  new ResourceManager("Proiect2.Languages.Strings", typeof(GlobalSettings).Assembly);

        public static void SetLanguage(string limbaj_cod) {
            try
            {
                CurrentCulture = new CultureInfo(limbaj_cod);
                Thread.CurrentThread.CurrentCulture = CurrentCulture;
                Thread.CurrentThread.CurrentUICulture = CurrentCulture; 
            }
            catch(CultureNotFoundException) {
                CurrentCulture = CultureInfo.InvariantCulture;
            }
               
        }

        public static string GetString(string cheie) { 
            return ResourceManager.GetString(cheie);
        }

    }
}
