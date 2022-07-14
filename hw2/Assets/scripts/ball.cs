using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Steps();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Steps()
    {
        int direction;
        direction = Random.Range(0, 2);
        if (direction == 0)
        {
            rb.velocity = new Vector2(5f, -3f);
        }
        else
        {
            rb.velocity = new Vector2(-5f, 3f);
        }
    }

}
