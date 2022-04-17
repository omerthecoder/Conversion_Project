using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion_Project.DTO
{
    public class DataTextDTO
    {
        public int DataId { get; set; }
        public string Text { get; set; }
        public string Translated { get; set; }
        public string Translation { get; set; }
        public DateTime? RecordDate { get; set; }

    }
}
