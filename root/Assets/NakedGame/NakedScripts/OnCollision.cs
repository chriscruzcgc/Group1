using UnityEngine;
using System.Collections;


public class OnCollision : MonoBehaviour {
	
	public int health = 4;

	public GameObject shirt;
	public GameObject pants;
	public GameObject shoes;
	// Use this for initialization
	void Start () 
	{
		shirt.SetActive (false);
		pants.SetActive (false);
		shoes.SetActive (false);
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
		if (other.gameObject.tag != "bullet") return;

			Destroy (other.gameObject);
			//Destroy ();
		print ("other tag is " + other.gameObject.tag);
		health --;
		if (health <= 0) {
			Destroy (gameObject);
			Application.LoadLevel("NakedVictory");
	}

		if (health == 3)
		{
			shirt.SetActive(true);
			//activate the shirt
		}
		if(health == 2)
		{
			pants.SetActive(true);
			//activate the pants
		}
		if(health == 1)
		{
			shoes.SetActive(true);
			//activate the shoes
		}


  }

}