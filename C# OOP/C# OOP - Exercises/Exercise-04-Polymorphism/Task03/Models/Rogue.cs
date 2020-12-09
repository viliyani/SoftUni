namespace Raiding.Models
{
    public class Rogue : BaseHero
    {
        private const int DEFAULT_POWER = 80;

        public Rogue(string name) : base(name, DEFAULT_POWER)
        {
        }

        public override string CastAbility()
        {
            return $"{this.GetType().Name} – {Name} hit for {Power} damage";
        }
    }
}
