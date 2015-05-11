using UnityEngine;
using System.Collections;
//using Assets.Scripts;

public class Movement : MonoBehaviour {
    private CharacterController controller;
    public Vector3 movement;
    public GameObject bullet;
    public Rigidbody bulletPrefab;
    public float cooldown = 30.0f;
    private float nextFire = 30.0f;
   
    
    
	// Use this for initialization
	void Start () {
        
        ShootBullets();
	}
	
	// Update is called once per frame
	void Update () {
        movement = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        movement = transform.TransformDirection(movement);
        movement *= 2;
        controller.Move(movement * Time.deltaTime);
	}

    void ShootBullets()
    {
        
          if (Input.GetKey("space") && Time.time >= nextFire)
       {
           nextFire += cooldown;
           Instantiate(bullet, transform.position, transform.rotation);
           //int spawn_bullet = Instantitate(bullet, Transform.position, Quaternion.identity);
           //spawn_bullet.GetComponent<Rigidbody>().AddForce(Vector3.up * 50);
       }
    }

   /* if(Input.GetKey("space"))
{
   int  spawn_bullet = Instantiate(bullet,Transform.position,Quaternion.identity);
    spawn_bullet.GetComponent.<Rigidbody>().AddForce(Vector3.up * 50);
}*/

}
