using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MOFH_api
{
    public class Domains
    {
        public static async void CheckAvailable(String apiUsername, String apiPassword, String domain)
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://panel.myownfreehost.net/xml-api/checkavailable.php"))
                {
                    var base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes(apiUsername + ":" + apiPassword));
                    request.Headers.TryAddWithoutValidation("Authorization", $"Basic {base64authorization}");

                    request.Content = new StringContent("api_user=" + apiUsername + "&api_key=" + apiPassword + "&domain=" + domain);
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/x-www-form-urlencoded");

                    var response = await httpClient.SendAsync(request);
                }
            }
        }
        public static async void GetUserDomains(String apiUsername, String apiPassword, String username)
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://panel.myownfreehost.net/xml-api/getuserdomains.php"))
                {
                    var base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes(apiUsername + ":" + apiPassword));
                    request.Headers.TryAddWithoutValidation("Authorization", $"Basic {base64authorization}");
                    
                    request.Content = new StringContent("api_user=" + username + "&api_key=" + apiPassword + "&username=" + username);
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/x-www-form-urlencoded");

                    var response = await httpClient.SendAsync(request);
                }
            }
        }
        public static async void GetUserByDomain(String apiUsername, String apiPassword, String domain)
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://panel.myownfreehost.net/xml-api/getdomainuser.php"))
                {
                    var base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes(apiUsername + ":" + apiPassword));
                    request.Headers.TryAddWithoutValidation("Authorization", $"Basic {base64authorization}");

                    request.Content = new StringContent("api_user=" + domain + "&api_key=" + apiPassword + "&username=" + domain);
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/x-www-form-urlencoded");

                    var response = await httpClient.SendAsync(request);
                }
            }
        }
    }
}
