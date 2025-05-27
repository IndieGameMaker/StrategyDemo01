using UnityEngine;

public abstract class WeaponStrategySO : ScriptableObject
{
    public float damage;
    public float range;
    
    public abstract void Attack(ITarget target);
}
