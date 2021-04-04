using m4TR1x.Business.Services;
using System;
using Xunit;

namespace m4TR1x.Business.Tests
{
    public class DailyMessageServiceTests
    {
        [Fact]
        public void GetDailyMessageShouldNotNull()
        {
            var dmservice = new DailyMessageService();

            var message = dmservice.GetDailyMessage();

            Assert.NotNull(message);
            Assert.NotNull(message.Author);
            Assert.NotNull(message.Message);
        }
    }
}
