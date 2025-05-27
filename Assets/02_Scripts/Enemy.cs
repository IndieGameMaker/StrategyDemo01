using UnityEngine;

public class Enemy : MonoBehaviour, ITarget
{
    [SerializeField] private float _health = 100.0f;
    
    public void TakeDamage(float damage)
    {
        _health -= damage;
        Debug.Log($"피격 : 데미지 {damage} , 남은 HP {_health}");
    }
}
