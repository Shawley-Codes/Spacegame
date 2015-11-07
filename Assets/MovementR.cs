using UnityEngine;
using System.Collections;

public class MovementR : MonoBehaviour {

    public Texture2D button1r; //depressed
    public Texture2D button2r; //pressed
    private GUITexture guiTexture1r;
    // Use this for initialization
    void Start () {
        guiTexture1r = GetComponent<GUITexture>();
        guiTexture1r.texture = button1r; //depressed
    }
	
	// Update is called once per frame
	void Update () {
        foreach (Touch touch in Input.touches)
        {
            if (guiTexture1r.HitTest(touch.position) && touch.phase != TouchPhase.Ended)
            {
                guiTexture1r.texture = button2r;

                transform.Translate(Vector2.right * 30 * Time.smoothDeltaTime);


            }
            else if (guiTexture1r.HitTest(touch.position) && touch.phase == TouchPhase.Ended)
            {
                guiTexture1r.texture = button1r;
            }
        }
    }
}
