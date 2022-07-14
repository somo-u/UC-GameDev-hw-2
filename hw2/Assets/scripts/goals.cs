using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goals : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        collider.GetComponent<ball>().Steps();
        collider.transform.position = new Vector2(0f, 0f);
    }
}
