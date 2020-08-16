using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using Chams.AFS.Api.Extensions;
using Newtonsoft.Json;
using RemitaAPIWrapper.Models.Requests;
using RemitaAPIWrapper.Models.Response;
using RemitaDirectDebit.Resources;
using System.Linq;
using RemitaAPIWrapper.Resources;
using System.Globalization;

namespace RemitaDirectDebit
{
    public class RemitaHttpClient
    {
        private string _remitaBaseUrl;
        private readonly HttpClient _client;
        private readonly string _merchantId;
        private readonly string _serviceTypeId;
        private readonly string _requestId;
        private readonly string _mandateSetUpUrl;
        private readonly string _apiKey;
        private string _hash;
        private string _mandateType;
        StatusCodes _statusCodes;

        /// <summary>
        /// Instantiate the Remita Http Client Class by passing the merchantId, serviceTypedId and apikey obtained from remita. 
        /// 
        /// If your mandate type id direct debit, you don't need toc hange 
        /// </summary>
        /// <param name="merchantId"></param>
        /// <param name="serviceTyeId"></param>
        /// <param name="apiKey"></param>
        /// <param name="mandateType"></param>
        /// <param name="remitaBaseUrl"></param>
        /// <param name="mandateSetUpUrl"></param>
        public RemitaHttpClient(string merchantId,string serviceTyeId,string apiKey, string mandateType = "DD", string remitaBaseUrl = "https://remitademo.net/remita/exapp/api/v1/send/api/echannelsvc/echannel/mandate", string mandateSetUpUrl = "/setup")
        {
            _remitaBaseUrl = remitaBaseUrl;
            _requestId = DateTime.Now.Ticks.ToString();
            _merchantId = merchantId;
            _serviceTypeId = serviceTyeId;
            _mandateSetUpUrl = mandateSetUpUrl;
            _apiKey = apiKey;
            _mandateType = mandateType;

            _client = new HttpClient();
            _statusCodes = new StatusCodes();

        }

        /// <summary>
        /// Returns MandateSetupResponse and string that represents the meaning of the status code returned from the remita API
        /// 
        /// If the HTTP response Status Code returned from Remita is not 200, you'll receieve a tuple value of null and the HTTP response code received from remita
        /// 
        /// The hash value is also automatically handled from the code.
        /// 
        /// The mandate Type sepcified in the contructor.
        /// 
        /// </summary>
        /// <param name="mandate"></param>
        /// <returns></returns>
        public async Task<MandateSetupResponse> SetUpMandateStandingOrder(SetupMandate mandate)
        {
            try
            {
                _hash = Util.SHA512Hash(_merchantId + _serviceTypeId + _requestId + mandate.amount + _apiKey);

                mandate.hash = _hash;
                mandate.mandateType = _mandateType;
                mandate.requestId = _requestId;
                mandate.serviceTypeId = _serviceTypeId;
                mandate.mandateType = _mandateType;
                mandate.merchantId = _merchantId;
                mandate.startDate = Convert.ToDateTime(mandate.startDate).ToString("dd/M/yyyy", CultureInfo.InvariantCulture);
                mandate.endDate = Convert.ToDateTime(mandate.endDate).ToString("dd/M/yyyy", CultureInfo.InvariantCulture);

                _client.BaseAddress = new Uri($"{_remitaBaseUrl}{_mandateSetUpUrl}");

                var payLoad = JsonConvert.SerializeObject(mandate);
                var content = new StringContent(payLoad, Encoding.UTF8, "application/json");

                var response = await _client.PostAsync("", content);

                if (response.IsSuccessStatusCode)
                {
                    var resultStream = await response.Content.ReadAsStreamAsync();
                    var returnResult = JsonExtensions.DeserializeEmbeddedJsonP<MandateSetupResponse>(resultStream);

                    return returnResult;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
