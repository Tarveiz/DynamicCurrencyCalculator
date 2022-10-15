using DynamicCurrencyCalculator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;


namespace DynamicCurrencyCalculator.Presenter
{
    internal class DataHandler
    {
        public RestResponse MyMainMethod()
        {
            APIRussiaBank russiaBank = new APIRussiaBank();

            //APIFixerIO fixer = new APIFixerIO();
            return russiaBank.GetAllActualCurrency();
            
        }
    }
}
