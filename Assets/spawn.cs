using UnityEngine;
using System.Collections;

public class spawn : MonoBehaviour {
    private Rigidbody2D rb;
    public float speed;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }
    void Update()
    {
        Vector2 movement = new Vector2(0f, -1f);
        rb.velocity = movement * speed;
        /*
        rb.position = new Vector2
        (
        Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax),
        Mathf.Clamp(rb.position.y, boundary.yMin, boundary.yMax)
        );*/
    }
}
