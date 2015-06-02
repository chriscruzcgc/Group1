using UnityEngine;
using System.Collections;

public class LightCollider : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Player")
        {
            Debug.Log("Win");
            Application.LoadLevel("DarknessWin");
        }
    }
}