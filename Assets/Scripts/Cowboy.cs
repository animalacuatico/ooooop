using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cowboy : Character
{
    public Cowboy(string inputName) : base(100, Resources.Load<Sprite>("Resources/Sprites/Cowboy"), inputName) 
    {
        _dmg = 15;
    }
    public override float Attack()
    {
        _dmg *= Random.Range(1, 1.5f);
        return _dmg;
    }
    public override float Heal()
    {
        health += 10;
        return health;
    }
}
