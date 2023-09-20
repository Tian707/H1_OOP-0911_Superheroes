using H1_OOP_AnimalFarm.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_AnimalFarm.Model
{
    internal abstract class Animal : IReproduction
    {
        // fields
        protected EType type;
        protected ESex sex;
        protected EReproduction reproduction;
        protected ELegCount legCount;
        protected EAppearanceType appearanceType;
        protected int ageInMonths;

        // properties
        protected ESex Sex { get { return sex; } }
        protected EType Type { get { return type; } }
        internal int AgeInMonths { get { return ageInMonths; } private set { } }

        //constructor
        protected Animal(EType type, ESex sex, EReproduction reproduction, ELegCount legCount, EAppearanceType appearanceType, int ageInMonths)
        {
            this.type = type;
            this.sex = sex;
            this.reproduction = reproduction;
            this.legCount = legCount;
            this.appearanceType = appearanceType;
            AgeInMonths = ageInMonths;
        }

        //methods:
        public abstract string LayEggOrGiveBirth();

    }

    internal enum ESpecie
    {
        Chicken, Dog, Rabbit
    }
    internal enum EType
    {
        Bird, Mammal
    }
    internal enum ESex
    {
        Male, Female
    }
    internal enum EReproduction
    {
        Oviparity, Viviparity
    }
    internal enum ELegCount
    {
        two, four
    }
    internal enum EAppearanceType
    {
        Feathered, ShortHaired, LongHaired
    }
}
