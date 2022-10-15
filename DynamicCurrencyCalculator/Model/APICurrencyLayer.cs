using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DynamicCurrencyCalculator.Model
{
    internal class APICurrencyLayer
    {
        string URL = "https://api.apilayer.com/currency_data/live";
        string apikey = "Zpjm2T8eYVskOwx4rBXA7TuhuFgAxtQL";

        public RestResponse GetAllActualCurrency()
        {
            RestClient client = new RestClient(URL);
            var request = new RestRequest();
            request.AddHeader("apikey", apikey);
            var response = client.Get(request);
            //Выводимый тип: RestSharp.RestResponse
            return response;
        }
    }
}
