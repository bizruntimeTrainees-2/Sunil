using System;
using System.Threading.Tasks;
using System.Net.Http;

namespace ConsoleApp1
{
    class AsyncExample3
    {
        public async Task Method()
        {           
            Task<int> downloading = DownloadDocsMainPageAsync();
            Console.WriteLine($"{nameof(MainClass)}: Launched dowloading");

            int bytesLoaded = await downloading;
            Console.WriteLine($"{nameof(MainClass)}: Downloaded {bytesLoaded} bytes");
            Console.ReadKey();
        }
        public static async Task<int> DownloadDocsMainPageAsync()
        {
            Console.WriteLine($"{nameof(DownloadDocsMainPageAsync)}: About to start downloading");
            var client = new HttpClient();
            byte[] content = await client.GetByteArrayAsync("https://docs.microsoft.com/en-us/");

            Console.WriteLine($"{nameof(DownloadDocsMainPageAsync)}: Finished downloading");

            return content.Length;
        }
    }
}
