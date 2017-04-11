using OmniSharp.Mef;
using OmniSharp.Models;

namespace OmniSharp.DotNetTest.Models
{
    [OmniSharpEndpoint(OmnisharpEndpoints.V2.GetTestStartInfo, typeof(GetTestStartInfoRequest), typeof(GetTestStartInfoResponse))]
    public class GetTestStartInfoRequest : Request
    {
        public string MethodName { get; set; }
        public string TestFrameworkName { get; set; }
    }
}