using System.Threading.Tasks;
using AWC_Platoon_Optimizer.Extensions;
using RestSharp;

namespace AWC_Platoon_Optimizer.Services
{
    public class ApiService
    {

        public virtual async Task<RestResponse> GetApiCategories(string token)
        {
            var client = new RestClient("https://api.swgoh.help/swgoh/data");
            var request = new RestRequest(Method.POST);            
            request.AddHeader("authorization", "Bearer " + token);
            request.AddHeader("content-type", "application/json");
            request.AddCookie("connect.sid", "s%3AbrLrBD4Mp2Rh83tT-Juf8hIzrItn-NLS.Xc7VTCgmFICfMb5YOt%2FovAg990D1Hm9M%2FTwLtEUuNWQ");
            request.AddParameter("application/json", "{\n    \"collection\": \"categoryList\",\n    \"language\": \"eng_us\",\n\t\"project\":{\n\t\t\"_id\":1,\n\t\t\"id\":1,\n\t\t\"descKey\":1,\n\t\t\"visible\":1\n\t\t\n\t}\n}", ParameterType.RequestBody);
            var response =  await client.ExecuteAsync(request);

            return response;
        }

        public virtual async Task<RestResponse> GetToken()
        {
            var client = new RestClient("https://api.swgoh.help/auth/signin");
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            request.AddCookie("connect.sid", "s%3AbrLrBD4Mp2Rh83tT-Juf8hIzrItn-NLS.Xc7VTCgmFICfMb5YOt%2FovAg990D1Hm9M%2FTwLtEUuNWQ");
            request.AddParameter("application/x-www-form-urlencoded", "username=ajvatter&password=captainlokie5&grant_type=password&client_id=abc&client_secret=123", ParameterType.RequestBody);
            var response = await client.ExecuteAsync(request);

            return response;
        }
    }
}
