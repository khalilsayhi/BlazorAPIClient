using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazorAPIClient.Dtos;

namespace BlazorAPIClient.DataServices
{
    public class RestSpaceXDataService : ISpaceXDataService
    {
        private readonly HttpClient _httpclient;
        public RestSpaceXDataService(HttpClient httpclient)
        {
            _httpclient = httpclient;
        }
        public async Task<LaunchDto[]> GetAllLaunches()
        {
            return await _httpclient.GetFromJsonAsync<LaunchDto[]>("/rest/launches");
        }
    }
}