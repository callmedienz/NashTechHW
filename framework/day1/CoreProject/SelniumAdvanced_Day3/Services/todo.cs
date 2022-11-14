using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelniumAdvanced_day3.Services
{
    public partial class Todo
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public bool DoneStatus { get; set; }
        public string Description { get; set; }
    }
}
