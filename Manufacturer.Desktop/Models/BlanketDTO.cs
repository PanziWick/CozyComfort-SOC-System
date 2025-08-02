using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manufacturer.Desktop.Models
{
    public class BlanketDTO
    {
        public int Id { get; set; }
        public string ModelName { get; set; }
        public string Material { get; set; }
        public int ProductionCapacity { get; set; }
        public int InStock { get; set; }
    }
}
