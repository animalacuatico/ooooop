using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum EnemyType { GOBLIN, SUKAMON }
public class EnemyBehavior : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Character enemyChar;
    private EnemyType typesOfEnemy;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        int chance = Random.Range(0, 2);
        if (chance == 0)
        {
            enemyChar = new Goblin();
        }
        else if (chance == 1)
        {
            enemyChar = new Sukamon();
        }
        spriteRenderer.sprite = enemyChar.GetSprite();
    }
}
