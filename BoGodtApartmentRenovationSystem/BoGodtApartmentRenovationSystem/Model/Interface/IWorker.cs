﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtApartmentRenovationSystem.Model.Interface
{
    internal interface IWorker
    {
       string TearDown();
        string CleanUp();
        string IncidentalWork();
    }
}
