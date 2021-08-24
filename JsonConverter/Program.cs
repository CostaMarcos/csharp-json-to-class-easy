using System;
using System.Text;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using Newtonsoft;
using Newtonsoft.Json;

namespace JsonConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Geting json from a file
            var json = File.ReadAllText("path to json");

            /*** CONVERTING JSON TO A CLASS IN NATIVE WAY***/
            #region Native
            //Change 'object' to your class
            var serializer = new DataContractJsonSerializer(typeof(List<Object>));
            var memory = new MemoryStream(Encoding.UTF8.GetBytes(json));

            //Change 'object' to your class
            var something = (List<object>)serializer.ReadObject(memory);
            #endregion

            /*** EASY WAY TO CONVERT JSON IN A CLASS ***/
            #region easy
            
            var urclass = JsonConvert.DeserializeObject<List<Object>>(json);
            
            #endregion

        }
    }
}
