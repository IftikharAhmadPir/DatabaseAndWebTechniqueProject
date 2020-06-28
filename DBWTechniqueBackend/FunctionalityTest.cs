using DBWTechniqueData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBWTechniqueBackend
{
    class FunctionalityTest
    {
        ProxyData DataLayerObj = new ProxyData();
        public void runAllTests()
        {

        }

        public void getProxyFromDatabaseAndUpdateStatus()
        {
            bool CountCheck = DataLayerObj.GetProxyFromDatabase().Count > 1;
            if(CountCheck == true)
            {
                DataLayerObj.setFunctionalityTestingResults("GetProxyFromDatabase", 1);
            }
        }
    }
}
