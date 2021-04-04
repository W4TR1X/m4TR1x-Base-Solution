using m4TR1x.Core.Models;
using m4TR1x.Core.Models.DailyMessageService;

namespace m4TR1x.Business.Interfaces
{
    public interface IDailyMessageService
    {
        DailyMessageModel GetDailyMessage();
    }
}
