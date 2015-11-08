using UnityEngine;
using System.Collections;

public class startbutton : MonoBehaviour {

    public void startbuttonpressed(string levelname)
    {
        Application.LoadLevel(levelname);
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
