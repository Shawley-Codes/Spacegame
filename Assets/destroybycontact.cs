using UnityEngine;
using System.Collections;

public class destroybycontact : MonoBehaviour {
    //public GameObject GO;
    public SpriteRenderer gameoverscreen;
    public SpriteRenderer Restart;
    public SpriteRenderer quit;
    void Start()
    {
        //GO = GetComponent<GameObject>();
       // gameoverscreen.enabled = false; //these activate when they spawn again.
       // Restart.enabled = false;
       // quit.enabled = false;
        
       
        
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
            Debug.Log("Ship is dead");
            gameoverscreen.enabled = true;
            Restart.enabled = true;
            quit.enabled = true;
        }
        else { 
            Destroy(other.gameObject);
            Destroy(gameObject);
            Debug.Log(other.name);
        }
    }
        
}

