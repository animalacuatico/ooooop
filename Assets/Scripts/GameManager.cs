using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public enum InterfaceVariable { PLAYER_NAME, PLAYER_HEALTH, COMBAT_STATUS_PLAYER, COMBAT_STATUS_ENEMY, ENEMY_NAME, ENEMY_HEALTH }
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private void Awake()
    {
        if (!instance)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void SetPlayerType(int value)
    {
        if (value == 0)
        {
            // Hacer que en el playerBehavior, playerChar sea un Wizard
        }
        else
        {
            // Hacer que en el playerBehavior, playerChar sea un Cowboy
        }
    }
    public void SetPlayerName(string name)
    {
        // Método para recoger el nombre del jugador que ha puesto en el inputField y asignarlo al playerChar del PlayerBehavior
    }
}
