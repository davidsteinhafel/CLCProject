using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProject
{
    public class Part: CustomList<Part>
    {
        public int PartId { get; set; }
    }
}
