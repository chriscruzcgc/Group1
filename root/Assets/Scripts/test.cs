using UnityEngine;
using System.Collections;

public class test : MonoBehaviour
{
 
    void OnTriggerEnter(Collider c)
	{

		if (c.CompareTag ("Player")) 
		{
			GameObject.FindGameObjectWithTag("Player").GetComponent<UnityStandardAssets.Characters.ThirdPerson.AICharacterControl>().SetTarget(dest);
		

		}
	} 
	public Transform dest;
}
