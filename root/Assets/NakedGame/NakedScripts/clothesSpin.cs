using UnityEngine;
using System.Collections;

public class clothesSpin : MonoBehaviour 
{
    public int spinx = 0;
    public int spiny = 0;
    public int spinz = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        transform.Rotate(spinx, spiny, spinz);
	
	}
}
