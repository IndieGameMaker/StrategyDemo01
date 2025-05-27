public interface IWeaponStrategy
{
    public float damage { get; set; }
    public float range { get; set; }

    public void Attack(ITarget target);
}