using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4TR1x.Core.Models.Results
{
    public class ObjectResult<T> where T : class, new()
    {
        public T Result { get; set; }
        public bool IsSuccess { get; set; }
        public List<string> Errors { get; set; }

        public ObjectResult()
        {
            Errors = new List<string>();
        }

        public ObjectResult(T model)
        {
            Result = model;
            IsSuccess = true;
            Errors = new List<string>();
        }


        public ObjectResult<T> AddError(string errorText)
        {
            Errors.Add(errorText);

            return this;
        }
    }
}
