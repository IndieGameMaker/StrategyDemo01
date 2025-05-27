using System;
using System.Collections.Generic;
using UnityEngine;

public enum WeaponType
{
    Melee,
    Ranged
}
public class Player : MonoBehaviour
{
    // 플레이어가 사용할 무기
    private Dictionary<WeaponType, IWeaponStrategy> _weapons = new();
    
    // 현재 무기
    [SerializeField] private IWeaponStrategy _currentWeapon;

    private void Start()
    {
        SetWeapon();
    }

    private void SetWeapon()
    {
        _weapons.Add(WeaponType.Melee, new MeleeWeapon() { damage = 10.0f, range = 1.0f });
        _weapons.Add(WeaponType.Ranged, new RangedWeapon() {damage = 20.0f, range = 10.0f});
        
        // 기본 무기 설정
        _currentWeapon = _weapons[WeaponType.Melee];
    }
}
