using UnityEngine;
using System.Collections;

public class OnDead : MonoBehaviour {
    public SpriteRenderer gameoverscreen;
    //public Rigidbody2D rb;
    public GameObject GO;
	// Use this for initialization
	void Start () {
        gameoverscreen.enabled = false;
        //rb = GetComponent<Rigidbody2D>();
        GO = GetComponent<GameObject>();
        Debug.Log("OnDead is running;");
    }
	
	// Update is called once per frame
	void Update () {
        if (GO == null)
        {
            Debug.Log("THE SHIP IS DEAD");
            gameoverscreen.enabled = true; //gameover
        }
        else
        {
            gameoverscreen.enabled = false;
        }
	}
}
