using UnityEngine;

public class MeleeWeaponSO : WeaponStrategySO
{
    public override void Attack(ITarget target)
    {
        Logger.Log("근접 공격");
        target?.TakeDamage(damage);
    }
}
