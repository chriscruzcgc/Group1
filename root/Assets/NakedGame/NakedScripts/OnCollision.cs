using UnityEngine;
using System.Collections;


public class OnCollision : MonoBehaviour {
	
	public int health = 4;
	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () 
	{
	}

	/*void OnDamage() {
		health --;
		if (health <= 0) {
			Destroy (gameObject);
		}
	}
*/
	void OnCollisionEnter(Collision other)
	{

		print ("shot");
		if (other.gameObject.tag == "bullet")
			Destroy (other.gameObject);
			//Destroy ();
		print ("other tag is " + other.gameObject.tag);
		health --;
		if (health <= 0) {
			Destroy (gameObject);
			Application.LoadLevel("NakedVictory");
	}

  }

}