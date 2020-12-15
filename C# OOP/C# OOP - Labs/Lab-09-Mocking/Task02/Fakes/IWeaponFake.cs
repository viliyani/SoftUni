using System;
using FakeAxeAndDummy.Contracts;

namespace FakeAxeAndDummy.Fakes
{
    public class IWeaponFake : IWeapon
    {
        public int AttackPoints
        {
            get
            {
                return 10;
            }
        }

        public int DurabilityPoints
        {
            get
            {
                return 10;
            }
        }

        public void Attack(IAttackable target)
        {
            // nothing
        }
    }
}
