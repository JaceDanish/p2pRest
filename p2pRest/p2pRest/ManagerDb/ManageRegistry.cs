using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Text.Json;
//using Newtonsoft.Json;
using p2pRest.Model;

namespace p2pRest.ManagerDb
{
    public class ManageRegistry
    {
        private static Dictionary<String, List<FileEndPoint>> _registryDictionary = new Dictionary<String, List<FileEndPoint>>();

        public string GetAll(string filename)
        {
            IList<FileEndPoint> newList = new List<FileEndPoint>();

            foreach (var reg in _registryDictionary)
            {
                if (reg.Key.Equals(filename))
                {
                    foreach (FileEndPoint fep in reg.Value)
                    {
                        newList.Add(fep);
                    }
                }
            }

            return JsonSerializer.Serialize(newList);
        }

        public int Register(String filename, FileEndPoint fep)
        {
            //FileEndPoint fep = JsonSerializer.Deserialize<FileEndPoint>(jSon);
            if (!(fep is FileEndPoint))
            {
                return -1;
            }

            if (_registryDictionary.ContainsKey(filename))
            {
                List<FileEndPoint> temp;
                _registryDictionary.TryGetValue(filename, out temp);
                foreach (FileEndPoint f in temp)
                {
                    if (f.Ipaddress.Equals(fep.Ipaddress))
                    {
                        return 0;
                    }
                }
                temp.Add(fep);
                return 1;
            }

            _registryDictionary.Add(filename, new List<FileEndPoint>()
            {
                fep
            });
            return 1;
        }

        public int Deregister(String filename, FileEndPoint fep)
        {
            //FileEndPoint fep = JsonSerializer.Deserialize<FileEndPoint>(jSon);
            if (!(fep is FileEndPoint))
            {
                return -1;
            }

            if (!_registryDictionary.ContainsKey(filename))
            {
                return 0;
            }

            //_registryDictionary.Remove(filename);
            List<FileEndPoint> temp;
            _registryDictionary.TryGetValue(filename, out temp);
            if (temp.Count == 1)
            {
                _registryDictionary.Remove(filename);
            }
            else
            {
                foreach (FileEndPoint f in temp)
                {
                    if (f.Ipaddress.Equals(fep.Ipaddress))
                    {
                        temp.Remove(f);
                        
                    }
                }
            }
            return 1;
        }
    }
}
