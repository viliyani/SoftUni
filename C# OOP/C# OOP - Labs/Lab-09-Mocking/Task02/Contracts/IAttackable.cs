namespace FakeAxeAndDummy.Contracts
{
    public interface IAttackable
    {

        int GiveExperience();

        void TakeAttack(int attackPoints);

        bool IsDead();
    }
}
