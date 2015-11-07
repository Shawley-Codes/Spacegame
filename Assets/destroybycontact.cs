using UnityEngine;
using System.Collections;

public class destroybycontact : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {


        if (other.tag == "Hazard")
        {
            return;
        }
        else if (other.tag == "Boundary")
        { Destroy(gameObject);
        }
        Destroy(other.gameObject);
        Destroy(gameObject);
        Debug.Log(other.name);
        
        
        
    }
}
