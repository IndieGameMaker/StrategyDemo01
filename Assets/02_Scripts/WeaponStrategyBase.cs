public abstract class WeaponStrategyBase : IWeaponStrategy
{
    public float damage { get; set; }
    public float range { get; set; }

    public abstract void Attack(ITarget target);
}
