using m4TR1x.Core.Models.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4TR1x.Core.Api.Interfaces
{
    public interface IApiHelperService<T> where T: class,new()
    {
        public ObjectResult<T> Get(string queryUrl);
    }
}
