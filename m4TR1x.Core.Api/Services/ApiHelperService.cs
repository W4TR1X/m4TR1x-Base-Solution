using m4TR1x.Core.Api.Interfaces;
using m4TR1x.Core.Models.Results;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4TR1x.Core.Api.Services
{
    public class ApiHelperService<T> : IApiHelperService<T> where T : class, new()
    {
        public ApiHelperService()
        {
        }

        public ObjectResult<T> Get(string queryUrl)
        {
            try
            {
                var client = new RestClient(queryUrl);

                var request = new RestRequest(Method.GET);
                IRestResponse response = client.ExecuteAsync(request).Result;

                if (response.IsSuccessful)
                {
                    var content = JsonConvert.DeserializeObject<T>(response.Content);

                    return new ObjectResult<T>(content);
                }
                else
                {
                    return new ObjectResult<T>()
                        .AddError(response.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                return new ObjectResult<T>()
                         .AddError(ex.Message);
            }         
        }
    }
}
