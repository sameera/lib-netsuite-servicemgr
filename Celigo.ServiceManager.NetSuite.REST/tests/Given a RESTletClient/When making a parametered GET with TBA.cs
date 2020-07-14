using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using FakeItEasy;
using FluentAssertions;
using Xunit;

namespace _.Given_a_RestletClient
{
    public class When_making_a_parametered_GET_with_TBA : GivenRestletClient
    {
        [Fact]
        public async Task It_appends_the_parameters_to_the_url()
        {
            var response = await Client.Get("TSTDRV12345", 
                                "DUMMYTOKEN", 
                                "DUMMYSECRET", 
                                ("search", "foo"),
                                ("filter", "b")
                            );
            response.StatusCode.Should().Be(HttpStatusCode.OK);

            A.CallTo(() =>
                    this.MessageHandler.SendAsync(
                        A<HttpRequestMessage>.That.Matches(m => m.RequestUri.Query.Contains("search=foo") && m.RequestUri.Query.Contains("filter=b")),
                        A<CancellationToken>.Ignored
                    ))
                .MustHaveHappenedOnceExactly();
        }
    }
}