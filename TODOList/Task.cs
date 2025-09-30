using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODOList
{
    public class Task
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool Done { get; set; }
        public DateTime Data { get; set; }
    }
}
