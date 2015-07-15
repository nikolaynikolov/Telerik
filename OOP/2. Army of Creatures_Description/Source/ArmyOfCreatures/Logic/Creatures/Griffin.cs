namespace ArmyOfCreatures.Logic.Creatures
{
    using ArmyOfCreatures.Logic.Specialties;

    public class Griffin  : Creature
    {
        public Griffin()
            : base(17, 17, 160, 40)
        {
            this.AddSpecialty(new ReduceEnemyDefenseByPercentage(40));
        }
    }
}
