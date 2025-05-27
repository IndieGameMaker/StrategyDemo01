using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


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
    // 적 타겟
    public Enemy target;

    private void Start()
    {
        SetWeapon();
    }

    private void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame) // Input.GetMouseButtonDown(0)
        {
            _currentWeapon?.Attack(target);
        }

        if (Keyboard.current.digit1Key.wasPressedThisFrame) // Input.GetKeyDown(KeyCode.Alpha1)
        {
            SwitchWeapon(WeaponType.Melee);
        }
        if (Keyboard.current.digit2Key.wasPressedThisFrame) // Input.GetKeyDown(KeyCode.Alpha2)
        {
            SwitchWeapon(WeaponType.Ranged);
        }
    }

    private void SetWeapon()
    {
        _weapons.Add(WeaponType.Melee, new MeleeWeapon() { damage = 10.0f, range = 1.0f });
        _weapons.Add(WeaponType.Ranged, new RangedWeapon() {damage = 20.0f, range = 10.0f});
        
        // 기본 무기 설정
        _currentWeapon = _weapons[WeaponType.Melee];
    }

    private void SwitchWeapon(WeaponType weaponType)
    {
        _currentWeapon = _weapons[weaponType];
        Logger.Log($"무기 변경: {weaponType}");
    }
}
