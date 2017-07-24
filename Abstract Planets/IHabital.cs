using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * name: mehul khosla
 * date:july 24, 2017
 * description: this is an interface that defines a habital property that
 * must be implmented in any class that subscribr to it
 * version:0.1- created interface IHabital.
 */
namespace Abstract_Planets
{
    /// <summary>
    /// this is IHabital interface
    /// </summary>
    public interface IHabital
    {
        //public property
        bool Habitable();
    }
}