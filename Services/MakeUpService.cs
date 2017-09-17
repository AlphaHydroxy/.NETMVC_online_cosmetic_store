using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace cosmetic_store.Services
{
    public class MakeUpService
    {
        public MakeUpService()
        {

        }

        public async Task<List<Product>> GetAllProducts()
        {
            var client = new HttpClient();

            var result = await client.GetStringAsync("http://makeup-api.herokuapp.com/api/v1/products.json");
            var products = JsonConvert.DeserializeObject<List<Product>>(result);

            return products.Where(x => x.Brand == "pure anada").ToList();
        }
    }
}
