using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goetia.Items
{
    public interface IWearable
    {
        int Id { get; set; }
        string Name { get; set; }
        string Slot { get; set; }
    }
}
