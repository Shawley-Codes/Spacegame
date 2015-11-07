using UnityEngine;
using System.Collections;
[System.Serializable]
public class Boundary
{
	public float xMin, xMax, yMin, yMax;
}

public class control : MonoBehaviour {
	public float speed; //shown in unity ui
	public float tilt;
	public Boundary boundary;
	// Use this for initialization
	private Rigidbody2D rb;
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update () {
		float moveHorizontal = Input.GetAxis ("Horizontal"); //uses arrow keys
		float moveVertical = Input.GetAxis ("Vertical");
		
		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
		rb.velocity = movement * speed;

			rb.position = new Vector2 
			(
			Mathf.Clamp (rb.position.x, boundary.xMin, boundary.xMax),  
			Mathf.Clamp (rb.position.y, boundary.yMin, boundary.yMax)
			);
	
		//rb.rotation = Quaternion.Euler (0.0f, 0.0f, rb.velocity.x * -tilt);
	}
}

