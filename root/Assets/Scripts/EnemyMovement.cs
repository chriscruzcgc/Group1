using UnityEngine;
using System.Collections;


public class EnemyMovement : MonoBehaviour
{
	Transform player;               // Reference to the player's position.
	NavMeshAgent nav;               // Reference to the nav mesh agent.

   
	void Update ()
	{
		
		player = GameObject.FindGameObjectWithTag ("Player").transform;	
		nav = GetComponent <NavMeshAgent> ();
		nav.SetDestination (player.position);    

	}
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Player")
        {
            Debug.Log("Hit");
        }
    }
}


  