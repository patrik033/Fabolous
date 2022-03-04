using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLibrary.Stuff
{
    public class JsonEditor
    {
        /// <summary>
        /// Ange fordonstyp och vilket fält du vill läsa av, Teckenkänslig!
        /// </summary>
        /// <param name="vehicleType"></param>
        /// <param name="field"></param>
        /// <returns></returns>
        string ReadProperty(string vehicleType, string field)
        {
            string json = File.ReadAllText(@"GarageSettings.json");

            dynamic jsonObject = JsonConvert.DeserializeObject(json);



            return jsonObject[vehicleType][field];
        }
        /// <summary>
        /// Ange cilket fordon du vill ändra, vilket fält och vad det nya värdet ska bli, VAR NOGRANN! Teckenkänsliga fält och värdet måste vara av rätt typ!, ska det vara en int, då ska den skickas in som en int!
        /// </summary>
        /// <param name="vehicleType"></param>
        /// <param name="field"></param>
        /// <param name="value"></param>
        void EditProperty(string vehicleType, string field, dynamic value)
        {
            string path = "GarageSettings.json";
            string json = File.ReadAllText(path);

            dynamic jsonObject = JsonConvert.DeserializeObject(json);

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(jsonObject);
            }
        }
    }
}
