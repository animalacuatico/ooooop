using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sukamon : Character
{
    public Sukamon()
    {
        _dmg = 1;
    }
    public override float Attack()
    {
        if (health < 5)
        {
            _dmg = 100;
        }
        return _dmg;
    }

    public override float Heal()
    {
        health += _dmg / 3;
        return health;
    }   
}
