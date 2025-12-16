using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace calculator.frontend.Controllers
{
    public class SquareRootController : Controller
    {
      public IActionResult Index()
            {
                return View();
            }
        // the base_url is obtained from environment variable
        // CALCULATOR_BACKEND_URL. If it is not present, it uses
        // "https://master-ugr-ci-backend-uat.azurewebsites.net";
        private string base_url =
            Environment.GetEnvironmentVariable("CALCULATOR_BACKEND_URL") ??
            "https://i02recav-ugr-ci-backend-uat.azurewebsites.net";
         // "https://localhost:7012";
        const string api = "api/Calculator";
        private double ExecuteOperation( double num1)
        {
            var result = 0.0;
            var clientHandler = new HttpClientHandler();
            var client = new HttpClient(clientHandler);
            var url = $"{base_url}/{api}/SQRT?a={num1}";
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(url),
            };
            using (var response = client.Send(request))
            {
                response.EnsureSuccessStatusCode();
                var body = response.Content.ReadAsStringAsync().Result;
                var json = JObject.Parse(body);
                var result_json = json["result"];
                if (result_json != null)
                {
                    result = result_json.Value<double>();
                }
            }
            return result;
        }
        [HttpPost]
        public ActionResult Index(string firstNumber)
        {
            double num1 = Convert.ToDouble(firstNumber);
            ViewBag.Result = ExecuteOperation( num1);
            return View();
        }
    }
}
