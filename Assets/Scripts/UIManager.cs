using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public InterfaceVariable varToUpdate;
    private TMP_Text textComp;
    private bool inCombat = false;
    private void Start()
    {
        textComp = GetComponent<TMP_Text>();
    }
    private void Update()
    {
        if (inCombat)
        {
            switch (varToUpdate)
            {
                case InterfaceVariable.PLAYER_NAME:
                    textComp.text = "Jugador: " + GetComponent<PlayerBehavior>().playerChar.GetName();
                    break;
                case InterfaceVariable.PLAYER_HEALTH:
                    textComp.text = "Vida: " + GetComponent<PlayerBehavior>().playerChar.health;
                    break;
                case InterfaceVariable.COMBAT_STATUS_PLAYER:
                    textComp.text = "Jugador hace: " + GetComponent<PlayerBehavior>().playerChar.GetDamage() + " de daño.";
                    break;
                case InterfaceVariable.COMBAT_STATUS_ENEMY:
                    textComp.text = GetComponent<EnemyBehavior>().enemyChar.GetName() + "hace " + GetComponent<EnemyBehavior>().enemyChar.GetDamage() + " de daño.";
                    break;
                case InterfaceVariable.ENEMY_NAME:
                    textComp.text = "Enemigo: " + GetComponent<EnemyBehavior>().enemyChar.GetName();
                    break;
                case InterfaceVariable.ENEMY_HEALTH:
                    textComp.text = "Vida: " + GetComponent<EnemyBehavior>().enemyChar.health;
                    break;
            }
        }
        else
        {
            textComp.text = "";
        }
    }
    public void SetCombatStatus(bool status)
    {
        inCombat = status;
    }
}
