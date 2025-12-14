using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Windows;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace lab2_3.Request
{
    public class LikeRequest
    {
        private const string ServerAddress = "localhost";
        private const int ServerPort = 5000;

        public static async Task<bool> LikeAsync(int number, int tripId)
        {
            await Task.Delay(200);

            var fakeResponse = new ResponseWrapper
            {
                success = true,
                message = "rating added"
            };

            return true;
        }

        public class ResponseWrapper
        {
            public bool success { get; set; }
            public string message { get; set; }
        }
    }
}