using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class catScript : MonoBehaviour
{
    // tonteria de script
    private Rigidbody2D RB2D;
    private Vector2 randomDirVector;
    private SpriteRenderer spriteRenderer;
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        RB2D = GetComponent<Rigidbody2D>();
        RB2D.drag = 2;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            randomDirVector = new Vector2(Random.Range(-2, 2), Random.Range(-2, 2));
            RB2D.AddForce(randomDirVector * 10, ForceMode2D.Impulse);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<BoxCollider2D>())
        {
            spriteRenderer.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        }
    }
}
