using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : Character
{
    private float _damageMultiplier;

    public Wizard(float damageMultiplier, string inputName) : base (100, Resources.Load<Sprite>("Resources/Sprites/Wizard"), inputName)
    {
        _dmg = 20;
        _damageMultiplier = damageMultiplier;
    }
    public override float Attack()
    {
        return _dmg * _damageMultiplier;
    }
    public override float Heal()
    {
        float healingResult = Random.Range(_dmg, _dmg * _damageMultiplier);
        health += healingResult;
        return health;
    }
}
