using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character
{
    public float health;
    private Sprite _sprite;
    private string _name;
    protected float _dmg;
    public Character()
    {

    }
    public Character(float health, Sprite sprite, string name)
    {
        this.health = health;
        this._sprite = sprite;
        this._name = name;
    }
    public abstract float Attack(); // Obliga a los hijos a definir este método

    public virtual float Heal() // No obliga a los hijos a usar el método, y también pueden modificarlo y complementarlo con override.
    {
        if (health > 101)
        {
            health = 100;
        }
        return health;
    }
    public string GetName()
    {
        return this._name;
    }
    public Sprite GetSprite()
    {
        return this._sprite;
    }
    public float GetDamage()
    {
        return this._dmg;
    }
}
