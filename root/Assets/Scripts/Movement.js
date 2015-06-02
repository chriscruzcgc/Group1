
#pragma strict
private var movement : Vector3 = Vector3.zero;
private var controller : CharacterController;

var bullet : GameObject;
var fireRate = 0.5;
var nextFire = 0;
var lives : int;
var lifetime = 2.0;





function Start () 
{
    controller = GetComponent(CharacterController);
}


function OnTriggerEnter(col : Collider)
    {
        if(col.gameObject.tag == "Enemy")
        {
            GameObject.Destroy(col.gameObject);
            GameObject.Destroy(this.gameObject);
            Application.LoadLevel("map_layout");
        }
    }


    /*function OnDestroy()
    {
        transform.parent.gameObject.AddComponent<GameLose>();
    }*/

    function Update () 
    {
        movement = Vector3(Input.GetAxis("Horizontal"), 0, 0);
	
        movement = transform.TransformDirection(movement);
	
        movement *= 7;
	
        controller.Move(movement * Time.deltaTime);

      //  print(GameObject.FindGameObjectsWithTag("Enemy").Length);
        if(GameObject.FindGameObjectsWithTag("Enemy").Length==0)
        {
            Application.LoadLevel("map_layout");
        }

        

    //print(GameObject.FindGameObjectsWithTag("Enemy"));
    /*if(GameObject.FindGameObjectsWithTag("Enemy") == 0);
    {
        Application.LoadLevel(0);
    }*/

   


    if (Input.GetKeyUp("up") && Time.time > nextFire)
        {
            var spawn_bullet = Instantiate (bullet, transform.position, Quaternion.identity);
            spawn_bullet.GetComponent.<Rigidbody>().AddForce(Vector3.up * 115);
            nextFire = Time.time + fireRate;
           // var clone = Instantiate (bullet, transform.position, transform.rotation);

    }
  
    
}