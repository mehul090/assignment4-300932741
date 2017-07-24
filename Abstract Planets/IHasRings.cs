using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * name: mehul khosla
 * date:july 20, 2017
 * description: this is an interface that defines a RingCount  property that
 * must be implmentes in any class that subscribr to it
 * version:0.1- created interface iHasRings
 */
namespace Abstract_Planets
{
    /// <summary>
    /// this is IHasRings interface
    /// </summary>
    public interface IHasRings
    {
        //public property
        bool HasRings();
    }
}