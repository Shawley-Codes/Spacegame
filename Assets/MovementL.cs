using UnityEngine;
using System.Collections;

public class MovementL : MonoBehaviour
{

    public Texture2D button1l; //depressed
    public Texture2D button2l; //pressed
    private GUITexture guiTexture1l;

   
    // Use this for initialization

    void Start()
    {
        guiTexture1l = GetComponent<GUITexture>();
        guiTexture1l.texture = button1l; //depressed

    }

    // Update is called once per frame
    void Update()
    {
        foreach (Touch touch in Input.touches)
        {
            if (guiTexture1l.HitTest(touch.position) && touch.phase != TouchPhase.Ended)
            {
                guiTexture1l.texture = button2l;

                transform.Translate(Vector2.left * 30 * Time.smoothDeltaTime);


            }
            else if (guiTexture1l.HitTest(touch.position) && touch.phase == TouchPhase.Ended)
            {
                guiTexture1l.texture = button1l;
            }

        }
    }
    
}
