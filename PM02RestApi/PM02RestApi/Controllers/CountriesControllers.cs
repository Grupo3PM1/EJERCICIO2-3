using Newtonsoft.Json;
using PM02RestApi.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PM02RestApi.Controllers
{
    public class CountriesControllers
    {
        public async static Task<List<Models.Countries.Example>> getpaises()
        {
            List<Models.Countries.Example> listapersonas = new List<Models.Countries.Example>();

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync("https://restcountries.com/v3.1/region/america");
                if (response.IsSuccessStatusCode)
                {
                    var contenido = response.Content.ReadAsStringAsync().Result;
                    listapersonas = JsonConvert.DeserializeObject<List<Models.Countries.Example>>(contenido);

                }
            }
            return listapersonas;
        }

    }
}