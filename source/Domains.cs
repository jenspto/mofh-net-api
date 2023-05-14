using System.Net.Http.Headers;
using System.Text;

namespace MOFH_api
{
    public class Domains
    {
        public static async void CheckAvailable(string apiUsername, string apiPassword, string domain)
        {
            try
            {
                using var httpClient = new HttpClient();
                using var request = new HttpRequestMessage(new HttpMethod("POST"), "https://panel.myownfreehost.net/xml-api/checkavailable.php");
                var base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes(apiUsername + ":" + apiPassword));
                request.Headers.TryAddWithoutValidation("Authorization", $"Basic {base64authorization}");
                request.Content = new StringContent("api_user=" + apiUsername + "&api_key=" + apiPassword + "&domain=" + domain);
                request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/x-www-form-urlencoded");
                var response = await httpClient.SendAsync(request);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception while checking domain: " + ex.Message);
            }
        }
        public static async void GetUserDomains(string apiUsername, string apiPassword, string username)
        {
            try
            {
                using var httpClient = new HttpClient();
                using var request = new HttpRequestMessage(new HttpMethod("POST"), "https://panel.myownfreehost.net/xml-api/getuserdomains.php");
                var base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes(apiUsername + ":" + apiPassword));
                request.Headers.TryAddWithoutValidation("Authorization", $"Basic {base64authorization}");
                request.Content = new StringContent("api_user=" + username + "&api_key=" + apiPassword + "&username=" + username);
                request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/x-www-form-urlencoded");
                var response = await httpClient.SendAsync(request);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception getting user domains: " + ex.Message);
            }
        }
        public static async void GetUserByDomain(string apiUsername, string apiPassword, string domain)
        {
            try
            {
                using var httpClient = new HttpClient();
                using var request = new HttpRequestMessage(new HttpMethod("POST"), "https://panel.myownfreehost.net/xml-api/getdomainuser.php");
                var base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes(apiUsername + ":" + apiPassword));
                request.Headers.TryAddWithoutValidation("Authorization", $"Basic {base64authorization}");
                request.Content = new StringContent("api_user=" + domain + "&api_key=" + apiPassword + "&username=" + domain);
                request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/x-www-form-urlencoded");
                var response = await httpClient.SendAsync(request);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception while getting user by domain: " + ex.Message);
            }
        }
    }
}
