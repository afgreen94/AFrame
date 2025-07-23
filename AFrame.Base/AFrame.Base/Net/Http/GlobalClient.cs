using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;

namespace AFrame.Base.Net.Http
{
    public static class GlobalClient 
    {

        private static readonly SemaphoreSlim semaphore = new(1,1);
        public static async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request)
        {
            try
            {
                await semaphore.WaitAsync().ConfigureAwait(false);

                using var client = new HttpClient();
                    return await client.SendAsync(request).ConfigureAwait(false);
            }
            finally { semaphore.Release(); }

        }

        public static async Task<TResponse> SendAsync<TResponse>(HttpRequestMessage request)
        {
            try
            {
                await semaphore.WaitAsync().ConfigureAwait(false);

                HttpResponseMessage response;

                using var client = new HttpClient();
                    response = await client.SendAsync(request).ConfigureAwait(false);

                var responseStr = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                return JsonSerializer.Deserialize<TResponse>(responseStr);

            }
            finally { semaphore.Release(); }
        }

    }
}
