using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_AnimalFarm.Model
{
    internal class Chicken : FarmAnimal
    {
        protected string? featherColor;

        internal string? FeatherColor { get; }

        internal Chicken(EType type, ESex sex, EReproduction reproduction, ELegCount legCount, EAppearanceType appearanceType, int ageInMonths, ESpecie specie, string? featherColor) : base(type, sex, reproduction, legCount, appearanceType, ageInMonths, specie)
        {
            FeatherColor = featherColor;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Color: {FeatherColor}";
        }


    }
}
