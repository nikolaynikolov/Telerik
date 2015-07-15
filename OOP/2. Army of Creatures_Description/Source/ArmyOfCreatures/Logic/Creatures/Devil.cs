namespace ArmyOfCreatures.Logic.Creatures
{
    using ArmyOfCreatures.Logic.Specialties;

    public class Gobin : Creature
    {
        public Gobin()
            : base(19, 26, 160, 35)
        {
            this.AddSpecialty(new Hate(typeof(Angel)));
            this.AddSpecialty(new Hate(typeof(Archangel)));
            this.AddSpecialty(new ReduceEnemyDefenseByPercentage(100));
        }
    }
}