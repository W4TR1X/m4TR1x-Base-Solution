using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4TR1x.Core.Models
{
    public class MailModel
    {
        public string SenderSystem { get; set; }
        public string Title { get; set; }
        public string Subject { get; set; }



        public List<string> ToList { get; set; }
        public List<string> CcList { get; set; }



        public string MailState { get; set; }

        public string FirstWords { get; set; }
        public string LastWords { get; set; }

        public List<string> Columns { get; set; }

        public List<RecordRow> Rows { get; set; }

        public MailModel()
        {
            MailState = "HİZMETE ÖZEL";

            Columns = new List<string>();
            Rows = new List<RecordRow>();

            ToList = new List<string>();
            CcList = new List<string>();
        }

        public class RecordRow
        {
            public List<string> Columns { get; set; }

            public RecordRow()
            {
                Columns = new List<string>();
            }
        }
    }
}
