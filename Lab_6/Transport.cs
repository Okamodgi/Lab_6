using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

public abstract class Transport
{
    public abstract int Speed { get; set; }
    public abstract int LoadCapacity { get; set; }
    public abstract int DistanceRange { get; set; }

    public abstract string GetDescription();

}
