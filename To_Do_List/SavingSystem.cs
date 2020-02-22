using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
namespace To_Do_List
{
    public static class SavingSystem
    {
        const string savePath = @"data.txt";
        public static void Save(string key, Dictionary<int, string> items)
        {
            Dictionary<String, Dictionary<int, string>> data = LoadData();
            if (data.ContainsKey(key)) data[key] = items;
            else data.Add(key, items);
            using (FileStream stream = File.Open(savePath, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, data);
                stream.Dispose();
            }
        }

        public static Dictionary<string, Dictionary<int, string>> LoadData()
        {
            if (!File.Exists(savePath)) return new Dictionary<string, Dictionary<int, string>>();
            using (FileStream stream = File.Open(savePath, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                var data = (Dictionary<string, Dictionary<int, string>>)formatter.Deserialize(stream);
                stream.Dispose();
                return data;
            }
        }
    }
}