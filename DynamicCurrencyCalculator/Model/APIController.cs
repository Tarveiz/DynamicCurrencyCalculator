﻿using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;


namespace DynamicCurrencyCalculator.Model
{
    /// <summary>
    /// Контроллер API-клиентов
    /// </summary>
    internal class APIController
    {
        string apikey = "Zpjm2T8eYVskOwx4rBXA7TuhuFgAxtQL";


        /// <summary>
        /// Ресурс: CurrencyLayer.com
        /// </summary>
        /// <param name="Action"></param>
        /// <returns></returns>
        public RestResponse CurrencyLayer(ActionsAPI Action)
        {
            string URL = "https://api.apilayer.com/currency_data/live";
            
            switch (Action)
            {
                
                case ActionsAPI.CURRENCY_VALUE:
                    RestClient client = new RestClient(URL);
                    var request = new RestRequest();
                    request.AddHeader("apikey", apikey);
                    var response = client.Get(request);
                    //Выводимый тип: RestSharp.RestResponse
                    return response;
                default:
                    return new RestResponse();
            }
        }
        /// <summary>
        /// Ресурс: FixerIO.com
        /// </summary>
        /// <param name="Action"></param>
        /// <returns></returns>
        public RestResponse FixerIO(ActionsAPI Action)
        {
            string URL = "https://api.apilayer.com/fixer/latest";

            switch (Action)
            {
                case ActionsAPI.CURRENCY_VALUE:
                    RestClient client = new RestClient(URL);
                    var request = new RestRequest();
                    request.AddHeader("apikey", apikey);
                    var response = client.Get(request);
                    //Выводимый тип: RestSharp.RestResponse
                    return response;
                default:
                    return new RestResponse();
            }
        }
        /// <summary>
        /// Ресурс: rb.ru
        /// </summary>
        /// <param name="Action"></param>
        /// <returns></returns>
        public RestResponse RussiaBank(ActionsAPI Action)
        {
            string URL = "https://www.cbr.ru/scripts/XML_daily.asp";

            switch (Action)
            {
                case ActionsAPI.CURRENCY_VALUE:
                    RestClient client = new RestClient(URL);
                    var request = new RestRequest();
                    var response = client.Get(request);
                    //Выводимый тип: RestSharp.RestResponse
                    return response;
                default:
                    return new RestResponse(); 
            }
        }
    }
}
