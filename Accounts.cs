using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace MOFH_api
{
    public class Accounts
    {
        public static async void Create(String apiUsername, String apiPassword, String username, String password, String contactemail, String domain,String plan)
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://panel.myownfreehost.net/xml-api/createacct.php"))
                {
                    var base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes(apiUsername+":"+apiPassword));
                    request.Headers.TryAddWithoutValidation("Authorization", $"Basic {base64authorization}");

                    request.Content = new StringContent("username=" + username + "&password=" + password + "&contactemail=" + contactemail + "&domain=" + domain + "&plan=" + plan);
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/x-www-form-urlencoded");

                    var response = await httpClient.SendAsync(request);
                }
            }
        }
        public static async void Suspend(String apiUsername,String apiPassword,String user,String reason)
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://panel.myownfreehost.net/xml-api/suspendacct.php"))
                {
                    var base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes(apiUsername+":"+apiPassword));
                    request.Headers.TryAddWithoutValidation("Authorization", $"Basic {base64authorization}");

                    request.Content = new StringContent("user="+user+"&reason="+reason);
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/x-www-form-urlencoded");

                    var response = await httpClient.SendAsync(request);
                }
            }
        }
        public static async void Unsuspend(String apiUsername,String apiPassword, String user)
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://panel.myownfreehost.net/xml-api/unsuspendacct.php"))
                {
                    var base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes(apiUsername + ":" + apiPassword));
                    request.Headers.TryAddWithoutValidation("Authorization", $"Basic {base64authorization}");

                    request.Content = new StringContent("user="+user);
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/x-www-form-urlencoded");

                    var response = await httpClient.SendAsync(request);
                }
            }
        }
        public static async void ChangePassword(String apiUsername, String apiPassword, String user, String password)
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://panel.myownfreehost.net/xml-api/passwd.php"))
                {
                    var base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes(apiUsername + ":" + apiPassword));
                    request.Headers.TryAddWithoutValidation("Authorization", $"Basic {base64authorization}");

                    request.Content = new StringContent("user="+user+ "&pass="+ password);
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/x-www-form-urlencoded");

                    var response = await httpClient.SendAsync(request);
                }
            }
        }
    }
}
