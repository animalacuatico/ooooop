using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Toolbars;
using UnityEngine;

public class buttonManager : MonoBehaviour
{
    public void MenuButton()
    {
        GameManager.instance.ChangeScene("MenuScene");
    }
    public void PlayButton()
    {
        GameManager.instance.ChangeScene("GameScene");
    }
    public string InputName()
    {
        // Método para recoger el nombre del jugador que ha puesto en el inputField
        return "Placeholder"; // Cambiar por el nombre del jugador que ha puesto en el inputField
    }
    public void CharChosen()
    {
        // Método para recoger el tipo de personaje que ha elegido el jugador en el dropdownText y asignarlo en el gameManager
        // Si el valor es 0, el personaje es Wizard. Si el valor es 1, el personaje es Cowboy.

    }
}
