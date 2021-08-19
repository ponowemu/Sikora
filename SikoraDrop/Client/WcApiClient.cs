using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using WooCommerceNET;
using WooCommerceNET.WooCommerce.v3;
using WooCommerceNET.WooCommerce.v3.Extension;


namespace SikoraDrop.Client
{
    public interface IWcApiClient
    {
        Task CreateOrder(Order orderModel);
    }
    public class WcApiClient : IWcApiClient
    {
        private const string _apiHost = "https://drop.postergaleria.pl/wp-json/wc/v3/";
        private const string _clientCode = "ck_70b38752919aea3e1f2ee6657f8815b48987367f";
        private const string _apiKey = "cs_2e622b410e030b04322273b1c458fd0833afe93e";

        private readonly ILogger<IWcApiClient> _logger;

        public WcApiClient(ILogger<IWcApiClient> logger)
        {
            _logger = logger;
        }

        public async Task CreateOrder(Order orderModel)
        {
            if (orderModel == null)
                throw new ArgumentNullException();

            if (orderModel.total == null || orderModel.total == 0)
            {
                _logger.LogWarning($"Próba utworzenia zamówienia z 0 zł wartością: {orderModel.id}");
                throw new ArgumentException("You cannot create an order for 0");
            }

            RestAPI rest = new RestAPI(_apiHost, _clientCode, _apiKey);
            WCObject wc = new WCObject(rest);

            var result = await wc.Order.Add(orderModel);
        }
    }
}
