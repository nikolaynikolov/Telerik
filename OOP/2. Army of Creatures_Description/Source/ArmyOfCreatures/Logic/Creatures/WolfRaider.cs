namespace ArmyOfCreatures.Logic.Creatures
{
    using ArmyOfCreatures.Logic.Specialties;

    public class WolfRaider : Creature
    {
        public WolfRaider()
            : base(8, 5, 10, 3)
        {
            this.AddSpecialty(new DoubleDamage(7));
        }
    }
}
