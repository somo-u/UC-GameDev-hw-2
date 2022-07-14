using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool player1;
    public float speed;
    public Rigidbody2D rb;
    private float steps; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player1)
        {
            steps = Input.GetAxis("Vertical");
        } else
        {
            steps = Input.GetAxis("Vertical2");
        }
        rb.velocity = new Vector2(rb.velocity.x, steps * speed);
    }
}
