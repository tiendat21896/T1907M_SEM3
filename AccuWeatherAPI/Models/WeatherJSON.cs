using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace AccuWeatherAPI.Models
{
    public class Temperature
    {
        public string value { get; set; }
        public string Value { get; internal set; }
        public string Unit { get; set; }

        public int UnitType { get; set; }
    }

    public class WeatherJSON
    {
        private static List<WeatherJSON> value;

        public string DateTime { get; set; }

        public int EpochDateTime { get; set; }

        public string WeatherIcon { get; set; }

        public string IconPhrase { get; set; }

        public string IsDaylight { get; set; }

        public Temperature Temperature { get; set; }

        public int PrecipitationProbability { get; set; }

        public string MobileLink { get; set; }

        public string Link { get; set; }

        public async static Task<List<WeatherJSON>> GetJSON(string url)
        {
            var http = new HttpClient();

            var response = await http.GetAsync(url);

            var result = await response.Content.ReadAsStringAsync();

            var serializer = new DataContractJsonSerializer(typeof(List<WeatherJSON>));

            return value;
        }
    }
}
