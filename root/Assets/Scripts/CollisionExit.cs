using UnityEngine;
using System.Collections;

public class CollisionExit : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }
    
    /// <summary>
    /// Precondition: object that this script is attached to must have a rigid body and a collider 
    /// Postcondition: an object must touch this object
    /// Description: when this object is  touched we will transition to a new scene given by the _lvlname parameter
    /// </summary>
    /// <param name="col"></param>
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Player")
        {
            Debug.Log("Win");
            Application.LoadLevel(_lvlName);
        }
    }

    /// <summary>
    /// this is the name of the level that we want to transition to 
    /// this value must b3e set in the inspector
    /// </summary>
    public string _lvlName;
    //public Event d = new Event();
}