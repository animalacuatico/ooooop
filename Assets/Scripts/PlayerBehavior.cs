using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum PlayerType { COWBOY, WIZARD }

public class PlayerBehavior : MonoBehaviour
{
    private Rigidbody2D rb2D;
    private Vector2 dirVector;
    public float playerSpeed = 10;
    private PlayerType typesOfPlayer;
    public Character playerChar;
    private SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rb2D = GetComponent<Rigidbody2D>();
        switch (typesOfPlayer)
        {
            case PlayerType.WIZARD:
                playerChar = new Wizard(1, "Wizardo");
                break;
            case PlayerType.COWBOY:
                playerChar = new Cowboy("Cowboyardo");
                break;
        }
        spriteRenderer.sprite = playerChar.GetSprite();
        Debug.Log(playerChar.GetName());
    }
    void Update()
    {
        dirVector = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }
    private void FixedUpdate()
    {
        rb2D.velocity = dirVector * playerSpeed;
    }
}
