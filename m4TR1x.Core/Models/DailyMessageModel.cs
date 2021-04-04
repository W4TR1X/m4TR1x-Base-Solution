using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4TR1x.Core.Models
{
    public class DailyMessageModel
    {
        public string Author { get; set; }
        public string Message { get; set; }

        public DailyMessageModel(string message, string author)
        {
            Message = message;
            Author = author;
        }

    }
}
