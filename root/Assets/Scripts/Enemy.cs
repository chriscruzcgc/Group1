using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
    {
       //this.nextShootTime = Random.Range(minShootDelay, maxShootDelay);
	}
	
 
    void OnTriggerEnter(Collider col)
    {
        moveDir = !moveDir;
        transform.position = new Vector3(transform.position.x, transform.position.y - .5f, transform.position.z);

         

    }

    void OnCollisionEnter(Collision col)
    {
       

    }


    bool moveDir = true;
    private Vector3 left = Vector3.left;
    private Vector3 right = Vector3.right;
   // public float speed = 10.5f;
    [SerializeField]
    private int moveSpeed;// = 2;
    private int timer = 300;
    public GameObject wallR;
    public GameObject wallL;
   /* public GameObject bullet;
    public Rigidbody EnemyBulletPrefab;
    public float minShootDelay = 1.0f;
    public float maxShootDelay = 5.0f;
    private float nextShootTime = 0.0f;*/
   
     Vector3 dir;
    //public GameObject box;
    

    void Update()
    {
       // transform.Translate(direction * Time.deltaTime);
       
        if (moveDir)
            dir = Vector3.left;
        else
            dir = Vector3.right;

        transform.Translate(moveSpeed * Time.deltaTime * dir);

       /* if (Time.time > nextShootTime)
        {
            Instantiate(EnemyBulletPrefab, this.transform.position, Quaternion.identity);
            nextShootTime = Time.time + Random.Range(minShootDelay, maxShootDelay);
        }*/

        /*timer -= 1;
        if (timer < 2)
        {
            var rand_num = Random.RandomRange(0, 4);
            var num_chosen = rand_num;

            if (num_chosen == 2)
            {
                var fire_bullet = Instantiate(enemy_bullet, transform.position, Quaternion.identity);
                fire_bullet.AddForce(-Vector3.up * 500);
            }
            timer = 300;*/
        }

        /*
        if (movingLeft && transform.localPosition.x <= -30)
        {
            moveDirection = new Vector3(1, 0, 0);
            movingLeft = false;
        }
       
        if (!movingLeft && transform.localPosition.x <= -30)
        {
            moveDirection = new Vector3(1, 0, 0);
            movingLeft = false;
        }

       */
        
        
 
    }


/*

var direction = Vector3(1, 0, 0);
var speed : float = 0.1f;

function Update ()
{
	transform.Translate(direction * Time.deltaTime);
}

function OnTriggerEnter(collisionInfo : Collider)
{
	var bump = collisionInfo.gameObject.tag; 
	if( bump == "wallX");
	direction.x *= -1;
}
 
 function OnCollisionEnter(col : Collision)
 {
 	print("collision");
 }*/