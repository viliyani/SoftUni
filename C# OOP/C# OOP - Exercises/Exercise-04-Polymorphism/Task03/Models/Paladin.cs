namespace Raiding.Models
{
    public class Paladin : BaseHero
    {
        private const int DEFAULT_POWER = 100;

        public Paladin(string name) : base(name, DEFAULT_POWER)
        {
        }

        public override string CastAbility()
        {
            return $"{this.GetType().Name} – {Name} healed for {Power}";
        }
    }
}
