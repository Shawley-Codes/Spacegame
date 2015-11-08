using UnityEngine;
using System.Collections;

public class destroybycontact : MonoBehaviour {
    public GameObject GO;
    public SpriteRenderer gameoverscreen;
    void Start()
    {
        gameoverscreen.enabled = false;
        //rb = GetComponent<Rigidbody2D>();
        GO = GetComponent<GameObject>();
        
    }

    // Update is called once per frame
    
    void OnTriggerEnter2D(Collider2D other)
    {

        

        if (other.tag == "Hazard")
        {

            return;
        }
        else if (other.tag == "Boundary")
        {
            Destroy(gameObject);
        }
        else if (other.tag == "Player")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            Debug.Log(other.name);
            gameoverscreen.enabled = true;
        }
        else { 
            Destroy(other.gameObject);
            Destroy(gameObject);
            Debug.Log(other.name);
        }
    }
        
}

