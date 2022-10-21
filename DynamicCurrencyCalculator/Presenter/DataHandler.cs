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
        // Использовать не заранее подготовленную модельку данных, а сам класс, в котором реализована логика, - как модель данных
        public void Handler()
        {
            APIController controller = new APIController();
            var L = controller.CurrencyLayer(ActionsAPI.CURRENCY_VALUE);
        }
    }
}
