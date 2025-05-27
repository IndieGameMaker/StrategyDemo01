using UnityEngine;

public class RangedWeapon : WeaponStrategyBase
{
    public override void Attack(ITarget target)
    {
        Logger.Log("원거리 공격");
        target?.TakeDamage(damage);
    }
}
