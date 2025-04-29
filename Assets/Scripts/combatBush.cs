using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
[RequireComponent(typeof(BoxCollider2D))]
public class combatBush : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerBehavior>())
        {
            int randomChance = Random.Range(0, 10);
            Debug.Log("No se ha invocado un combate.");
            if (randomChance < 2)
            {
                Debug.Log("Se ha invocado un combate.");
                gameObject.AddComponent<CombatController>();
            }
        }
    }
}
