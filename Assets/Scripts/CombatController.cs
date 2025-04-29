using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatController : MonoBehaviour
{
    public GameObject playerPrefab, enemyPrefab;
    private bool turn = true; // Si turn es verdadero, le toca al jugador. Si es falso, le toca al enemigo.
    private void Start()
    {
        playerPrefab = FindObjectOfType<PlayerBehavior>().gameObject;
        enemyPrefab = FindObjectOfType<EnemyBehavior>().gameObject;
    }
    private void Update()
    {
        GameManager.instance.SetCombatStatus(true);
        // Los turnos se alternan entre el jugador y el enemigo hasta que el enemigo es derrotado.
        if (turn)
        {
            Debug.Log("COMBATE EMPEZADO. Turno del jugador.");
            if (Input.GetMouseButtonDown(0))
            {
                playerPrefab.GetComponent<PlayerBehavior>().playerChar.Attack();
            }
            else if (Input.GetMouseButtonDown(1))
            {
                playerPrefab.GetComponent<PlayerBehavior>().playerChar.Heal();
            }
            turn = false;
        }
        else
        {
            Debug.Log("Turno del enemigo.");
            int enemyAction = Random.Range(0, 1);
            if (enemyAction == 0)
            {
                enemyPrefab.GetComponent<EnemyBehavior>().enemyChar.Attack();
            }
            else
            {
                enemyPrefab.GetComponent<EnemyBehavior>().enemyChar.Heal();
            }
            turn = true;
        }
        // Comprobar si el enemigo ha sido derrotado
        if (enemyPrefab.GetComponent<EnemyBehavior>().enemyChar.health <= 0)
        {
            Destroy(enemyPrefab);
            Debug.Log("Enemigo derrotado.");
            GameManager.instance.SetCombatStatus(false);
            Destroy(this); // Destruir el controlador de combate después de la victoria
        }
    }
}
