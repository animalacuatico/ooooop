using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum EnemyType { GOBLIN, SUKAMON }
public class EnemyBehavior : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Character enemyChar;
    public EnemyType typesOfEnemy;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        switch (typesOfEnemy)
        {
            case EnemyType.GOBLIN:
                enemyChar = new Goblin();
                break;
            case EnemyType.SUKAMON:
                enemyChar = new Sukamon();
                break;
        }
        spriteRenderer.sprite = enemyChar.GetSprite();
    }
}
