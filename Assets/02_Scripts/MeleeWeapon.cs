using UnityEngine;

public class MeleeWeapon : WeaponStrategyBase
{
    public override void Attack(ITarget target)
    {
        Logger.Log("근접 공격");
        target?.TakeDamage(damage);
    }
}
