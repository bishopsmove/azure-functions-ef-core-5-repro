using Microsoft.Azure.WebJobs;
using System.Net.Http;

namespace EfCore5Reproduction
{
    public class TestFunction
    {
        [FunctionName("TestFunction")]
        public void Exec([HttpTrigger] HttpRequestMessage req)
        {

        }
    }
}
