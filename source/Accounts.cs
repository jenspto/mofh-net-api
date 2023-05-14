using System.Net.Http.Headers;
using System.Text;

namespace MOFH_api
{
    public class Accounts
    {
        public static async void Create(string apiUsername, string apiPassword, string username, string password, string contactemail, string domain, string plan)
        {
            try
            {
                using var httpClient = new HttpClient();
                using var request = new HttpRequestMessage(new HttpMethod("POST"), "https://panel.myownfreehost.net/xml-api/createacct.php");
                var base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes(apiUsername + ":" + apiPassword));
                request.Headers.TryAddWithoutValidation("Authorization", $"Basic {base64authorization}");
                request.Content = new StringContent("username=" + username + "&password=" + password + "&contactemail=" + contactemail + "&domain=" + domain + "&plan=" + plan);
                request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/x-www-form-urlencoded");
                var response = await httpClient.SendAsync(request);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception while creating account: " + ex.Message);
            }
        }
        public static async void Suspend(string apiUsername, string apiPassword, string user, string reason)
        {
            try
            {
                using var httpClient = new HttpClient();
                using var request = new HttpRequestMessage(new HttpMethod("POST"), "https://panel.myownfreehost.net/xml-api/suspendacct.php");
                var base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes(apiUsername + ":" + apiPassword));
                request.Headers.TryAddWithoutValidation("Authorization", $"Basic {base64authorization}");

                request.Content = new StringContent("user=" + user + "&reason=" + reason);
                request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/x-www-form-urlencoded");

                var response = await httpClient.SendAsync(request);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception while suspending account: " + ex.Message);
            }
        }
        public static async void Unsuspend(string apiUsername, string apiPassword, string user)
        {
            try
            {
                using var httpClient = new HttpClient();
                using var request = new HttpRequestMessage(new HttpMethod("POST"), "https://panel.myownfreehost.net/xml-api/unsuspendacct.php");
                var base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes(apiUsername + ":" + apiPassword));
                request.Headers.TryAddWithoutValidation("Authorization", $"Basic {base64authorization}");
                request.Content = new StringContent("user=" + user);
                request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/x-www-form-urlencoded");
                var response = await httpClient.SendAsync(request);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception while unsuspending account: " + ex.Message);
            }
        }
        public static async void ChangePassword(string apiUsername, string apiPassword, string user, string password)
        {
            try
            {
                using var httpClient = new HttpClient();
                using var request = new HttpRequestMessage(new HttpMethod("POST"), "https://panel.myownfreehost.net/xml-api/passwd.php");
                var base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes(apiUsername + ":" + apiPassword));
                request.Headers.TryAddWithoutValidation("Authorization", $"Basic {base64authorization}");
                request.Content = new StringContent("user=" + user + "&pass=" + password);
                request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/x-www-form-urlencoded");
                var response = await httpClient.SendAsync(request);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception while changing password: " + ex.Message);
            }
        }
    }
}