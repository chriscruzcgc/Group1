#pragma strict
var lifetime = 2;
var numberOfEnemies : int;



function OnTriggerEnter (col : Collider)
    {
        if (col.gameObject.tag == "Enemy")
        {
            gameObject.Find("Main Camera").GetComponent(Stats).current_score += 250;
           
          
            Destroy(gameObject);
            Destroy(col.gameObject);
            /*if(GameObject.FindGameObjectsWithTag("Enemy")==0);
            {
                Application.LoadLevel(0);
            }*/
        
           
        
        }
    
    
	    
        else if (col.gameObject.name == "Enemy Bullet")
        {
            Destroy(gameObject);
        }
        else if (col.gameObject.name != "bed1")
        {
            Destroy(gameObject);
        }
}

function OnCollisionStay (col : Collider)
   {
        if(col.gameObject.tag == "Enemy")
        {
            numberOfEnemies--;
            if(numberOfEnemies == 30)
                Application.LoadLevel(0);
        }
    }
    
function Awake()
{
    Destroy(gameObject, lifetime);
}