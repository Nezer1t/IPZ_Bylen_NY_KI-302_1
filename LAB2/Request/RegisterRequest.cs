using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Windows;
using lab2_3.Entity;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace lab2_3.Request
{
    public class RegisterRequest
    {
        private const string ServerAddress = "localhost";
        private const int ServerPort = 5000;

        public static async Task<bool> RegisterAsync(string username, string password, string passwordConfirmation)
        {
            await Task.Delay(200);

            var fakeResponse = new ResponseWrapper
            {
                success = true,
                message = "98765"
            };

            AuthEntity.userId = int.Parse(fakeResponse.message);
            return true;
        }

        public class ResponseWrapper
        {
            public bool success { get; set; }
            public string message { get; set; }
        }
    }
}