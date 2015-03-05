using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace TFS2013BIAdmin.Console
{
    public static class WebService
    {
        private static WSControleCenter.WarehouseControlWebServiceSoapClient _WSBIClient;

        public static WSControleCenter.WarehouseControlWebServiceSoapClient WsBIClient
        {
            get
            {
                if (_WSBIClient == null)
                    _WSBIClient = new WSControleCenter.WarehouseControlWebServiceSoapClient();

                return _WSBIClient;
            }
        }
    }
}
