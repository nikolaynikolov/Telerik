namespace ArmyOfCreatures.Logic.Creatures
{
    using ArmyOfCreatures.Logic.Specialties;

    public class Angel : Creature
    {
        public Angel()
            : base(20, 20, 200, 50)
        {
            this.AddSpecialty(new Hate(typeof(Gobin)));
            this.AddSpecialty(new Hate(typeof(ArchDevil)));
        }
    }
}