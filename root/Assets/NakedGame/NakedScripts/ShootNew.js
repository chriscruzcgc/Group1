
var projectile : Rigidbody;
var speed = 0.5;
var ammo : int = 0;
var maxAmmo : int = 10;
var ammoText : GUIText;




function Update ()
{	
	if(Input.GetButtonUp ("Fire1") && ammo < maxAmmo)
	{
	
		clone = Instantiate(projectile, transform.position, transform.rotation);
		clone.velocity = transform.TransformDirection(Vector3 (0, 0, speed));
		ammo++;
		
	Destroy (clone.gameObject, 5);
	GetComponent.<ParticleSystem>().Play();
	}
	if( ammo == maxAmmo ) {
	Application.LoadLevel("NakedEnd");
	}
}

function OnGUI()
{
	ammoText.text = "Ammo: " + ammo + "/" + maxAmmo;
	}