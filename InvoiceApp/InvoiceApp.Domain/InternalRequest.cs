using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceApp.Domain
{
    public class InternalRequest
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Project { get; set; }
    }
}
