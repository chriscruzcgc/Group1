using UnityEngine;
using System.Collections;

public class jankyassbehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void printjankstars()
    {

        print("eric is a bawsss");
    }

    void OnCollisionEnter(Collision col)
    {
        Destroy(col.gameObject);

    }
}
