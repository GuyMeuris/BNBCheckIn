using BnBCheckIn_Client.Service.IService;
using ModelsDTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BnBCheckIn_Client.Service
{
    public class StripePaymentService : IStripePaymentService
    {
        // First we need to include our 'HttpClient'-object using depency injection.
        private readonly HttpClient _client;

        public StripePaymentService(HttpClient client)
        {
            _client = client;
        }

        //*************************************************************************************

        // Here we can start detailing our 'CRUD'-operations in the form of actions (= methods).

        public async Task<SuccessResponseDTO> CheckOut(StripePaymentDTO model)
        {
            var content = JsonConvert.SerializeObject(model);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("api/stripepayment/create", bodyContent);
            var contentTemp = await response.Content.ReadAsStringAsync();
            response.EnsureSuccessStatusCode();
            var result = JsonConvert.DeserializeObject<SuccessResponseDTO>(contentTemp);
            return result;
        }
    }
}
