using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : Character
{
    public Goblin()
    {
        _dmg = 10;
    }
    public override float Attack()
    {
        if (health < 20)
        {
            _dmg *= 3;
        }
        return _dmg;
    }
    public override float Heal()
    {
        health = _dmg / 2;
        return health;
    }
}
