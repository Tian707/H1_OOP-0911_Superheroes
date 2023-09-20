using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_AnimalFarm.Model.Interface
{
    /// <summary>
    /// A method for female
    /// </summary>
    internal interface IReproduction
    {
        //ESex GetGender { get; }
        //EType GetType { get; }


        string LayEggOrGiveBirth();
    }
}
