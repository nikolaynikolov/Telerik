namespace ArmyOfCreatures.Logic.Creatures
{
    using ArmyOfCreatures.Logic.Specialties;

    public class AncientBehemoth : Creature
    {
        public AncientBehemoth()
            : base(17, 17, 160, 40)
        {
            this.AddSpecialty(new ReduceEnemyDefenseByPercentage(40));
        }
    }
}
