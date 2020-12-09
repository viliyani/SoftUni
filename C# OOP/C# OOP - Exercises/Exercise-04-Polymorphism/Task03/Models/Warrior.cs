namespace Raiding.Models
{
    public class Warrior : BaseHero
    {
        private const int DEFAULT_POWER = 100;

        public Warrior(string name) : base(name, DEFAULT_POWER)
        {
        }

        public override string CastAbility()
        {
            return $"{this.GetType().Name} – {Name} hit for {Power} damage";
        }
    }
}
