﻿using System;
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
        private static Dictionary<String, FileEndPoint> _registryDictionary = new Dictionary<String, FileEndPoint>();

        public string GetAll(string filename)
        {
            IList<FileEndPoint> newList = new List<FileEndPoint>();

            foreach (var reg in _registryDictionary)
            {
                if (reg.Key.Equals(filename))
                {
                    newList.Add(reg.Value);
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
                return 0;
            }

            _registryDictionary.Add(filename, fep);
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

            _registryDictionary.Remove(filename);
            return 1;
        }
    }
}
