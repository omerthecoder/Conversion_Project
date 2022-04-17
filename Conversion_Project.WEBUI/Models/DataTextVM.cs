using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conversion_Project.WEBUI.Models
{
    public class DataTextVM
    {
        public int DataId { get; set; }
        public string Text { get; set; }
        public string Translated { get; set; }
        public string Translation { get; set; }
        public DateTime? RecordDate { get; set; }
    }
}
