using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPPG_CRM_v2
{
    public class GlobalConfig
    {
        public static IDataConnector Connection { get; private set; }

        public static void InitializeConnection()
        {
            Connection = new TextConnector();
        }


    }
}
