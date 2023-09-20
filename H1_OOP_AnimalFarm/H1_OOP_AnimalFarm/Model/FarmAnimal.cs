using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_AnimalFarm.Model
{
    internal class FarmAnimal : Animal
    {
        protected ESpecie specie;

        internal ESpecie Specie { get; }
        protected FarmAnimal(EType type, ESex sex, EReproduction reproduction, ELegCount legCount, EAppearanceType appearanceType, int ageInMonths, ESpecie specie) : base(type, sex, reproduction, legCount, appearanceType, ageInMonths)
        {
            this.specie = specie;
        }

        public override string LayEggOrGiveBirth()
        {
            if (Sex == ESex.Male)
            {
                return $"This {Specie} is a male.";
            }
            else if (Sex == ESex.Female && Type == EType.Bird)
            {
                return $"This {Specie} is laying egg.";
            }
            else if (Sex == ESex.Female && Type == EType.Mammal)
            {
                return $"This {Specie} is giving birth.";
            }
            else
                return "Unable to define reproduction process";
        }
        public override string ToString()
        {
            return $"Type: {Type}, Specie: {Specie}, LegCount: {legCount}, sex: {Sex},\nReproduction: {reproduction}, Appearance: {appearanceType}, Age: {AgeInMonths} months";
        }
    }
}
