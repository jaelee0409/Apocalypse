using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GoombaController : MonoBehaviour
{
    public GameObject Player;
    public Rigidbody2D rb;
    public float moveSpeed;
    public float health;
    public float damage;

    private Vector2 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        chasePlayer();
    }

    void chasePlayer()
    {
        float xmove = Player.transform.position.x - this.transform.position.x;
        float ymove = Player.transform.position.y - this.transform.position.y;
        moveDirection = new Vector2(xmove, ymove).normalized;

        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }
}
