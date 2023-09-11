using H2_OOP_Superheroes.Modul;

namespace H2_OOP_Superheroes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SuperHero superman = new SuperHero();
            superman.Name = "Superman";
            superman.SecretIdentity = "Clark Kent";
            superman.Costume = "Blue suit and red cape";
            superman.LifePercentage = 100;

            superman.HeroSkill = new Skill();
            superman.HeroSkill.Name = "Flight";
            superman.HeroSkill.Description = "Can fly at super speeds";
            superman.HeroSkill.Equipment = null; ;
            superman.HeroSkill.SkillLevel = 10;
            superman.HeroSkill.DamagePercentage = 30;
            superman.HeroSkill.ConsumptionPercentage = 5;

            superman.PresentSuperHero();
            superman.Attack();

            Console.ReadKey();
        }
    }
}