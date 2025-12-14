using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Windows;
using lab2_3.Entity;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace lab2_3.Request
{
    public class AuthRequest
    {
        private const string ServerAddress = "localhost";
        private const int ServerPort = 5000;

        public static async Task<bool> AuthAsync(string username, string password)
        {
            await Task.Delay(200);

            var fakeResponse = new ResponseWrapper
            {
                success = true,
                message = "12345"
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