using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using p2pRest.Model;

namespace p2pRest.ManagerDb
{
    public class ManageRegistry
    {
        private Dictionary<FileEndPoint, string> _registryDictionary = new Dictionary<FileEndPoint, string>();

        public string GetAll(string filename)
        {
            IList<FileEndPoint> newList = new List<FileEndPoint>();

            foreach (var reg in _registryDictionary)
            {
                if (reg.Value.Equals(filename))
                {
                    newList.Add(reg.Key);
                }
            }

            return JsonConvert.SerializeObject(newList);
        }
    }
}
