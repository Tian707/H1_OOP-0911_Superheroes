using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_AnimalFarm.Model
{
    internal class Rabbit : FarmAnimal
    {
        protected string? furColor;

    internal string? FurColor { get; }

    internal Rabbit(EType type, ESex sex, EReproduction reproduction, ELegCount legCount, EAppearanceType appearanceType, int ageInMonths, ESpecie specie, string? furColor) : base(type, sex, reproduction, legCount, appearanceType, ageInMonths, specie)
    {
        FurColor = furColor;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Color: {FurColor}";
    }


}
}
