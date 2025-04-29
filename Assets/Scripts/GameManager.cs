using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public enum InterfaceVariable { PLAYER_NAME, PLAYER_HEALTH, COMBAT_STATUS_PLAYER, COMBAT_STATUS_ENEMY, ENEMY_NAME, ENEMY_HEALTH }
public enum PlayerType { COWBOY, WIZARD }
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private PlayerType playerType;
    private Character Character;
    private string playerName = "SinNombre";
    private bool inCombat = false;
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
    public Character SetPlayerType()
    {
        string chosenname = playerName;
        Character = new Wizard(1, playerName);
        Character = new Cowboy(playerName);
        return Character;
    }
    public void SetCombatStatus(bool status)
    {
        inCombat = status;
    }
    public bool GetCombatStatus()
    {
        return inCombat;
    }
}
