#pragma strict
var lifetime = 2;

    function OnTriggerEnter(col : Collider)
        {
            if(col.gameObject.tag == "Player")
            {
                GameObject.Destroy(col.gameObject);
                GameObject.Destroy(this.gameObject);
                Application.LoadLevel("map_layout");
            }
            else if(col.gameObject.tag == "bullet")
            {
                Destroy(gameObject); 
            }
            else if (col.gameObject.tag != "Enemy")
            {
                Destroy(gameObject);
                
            }
        }
        function Awake()
        {
            Destroy(gameObject, lifetime);
        }
     
       