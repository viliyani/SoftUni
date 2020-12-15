using System;
using FakeAxeAndDummy.Contracts;

namespace FakeAxeAndDummy.Fakes
{
    public class IAttackableFake : IAttackable
    {
        public int GiveExperience()
        {
            return 20;
        }

        public bool IsDead()
        {
            return true;
        }

        public void TakeAttack(int attackPoints)
        {
            // do nothing
        }
    }
}
