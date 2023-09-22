using BoGodtApartmentRenovationSystem.Model.WorkingPersons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtApartmentRenovationSystem.Model.Interface
{
    internal interface IApprentice
    {
        Journeyman GetMyJourneyman();
        string WorkAlongsideJourneyman();
    }
}
