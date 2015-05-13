using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour 
{
	public GameObject demonDoll;
    public GameObject teddybear;
	float moveSpeed = 5.0f;

	void Start()
	{
      
	}

	// Update is called once per frame
	void Update () 
	{
		this.transform.Translate (Vector3.up * Time.deltaTime * moveSpeed);
		//transform.Translate (0, 0, Time.deltaTime * 1);
	}

}