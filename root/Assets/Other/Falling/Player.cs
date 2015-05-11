using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float speed = 3.0f;
	public float score = 0f;
    
    public void OnGUI()
    {
        GUIStyle myStyle = new GUIStyle();
        myStyle.fontSize = 30;
        myStyle.normal.textColor = Color.green;
        //Display the score
        string text = "Score: " + score;
        GUI.Label(new Rect(700, 10, 60, 20), text, myStyle);
    }

	//Collision with player
	void OnTriggerEnter(Collider collision)
	{
		//If player collides with 'Evil', score decreases & enemy is destroyed
		if (collision.gameObject.tag == "evilcloud")
		{
			score -= 5;
            print("Lost points");
			Destroy (collision.gameObject);
		}
		//If player collides with 'Good', score increases & good is destroyed
		else if (collision.gameObject.tag == "goodcloud")
		{
			score += 5;
            print("Points gained");
			Destroy (collision.gameObject);
		}
	}
	// Use this for initialization
	void Start () 
	{
		
	}

	// Update is called once per frame
	void Update () 
	{
		float x = Input.GetAxis ("Horizontal") * Time.smoothDeltaTime * speed;
		float y = Input.GetAxis ("Vertical") * Time.smoothDeltaTime * speed;

        Vector3 pos = transform.position;

		//pos.x = Mathf.Clamp (pos.x + x, -5, 5);
		//pos.z = Mathf.Clamp (pos.z + y, -5, 5);

        if (pos.x >= 10 || pos.x <= -10) { pos.x = -pos.x; }
        if (pos.z >= 10 || pos.z <= -10) { pos.z = -pos.z; }

		transform.position = pos;
		transform.Translate (x, 0, y, Space.Self);
	}
}
