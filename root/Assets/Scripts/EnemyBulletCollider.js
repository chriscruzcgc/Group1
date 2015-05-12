#pragma strict
var lifetime = 2;

    function OnTriggerEnter(col : Collider)
        {
            if(col.gameObject.tag == "Player")
            {
                GameObject.Destroy(col.gameObject);
                GameObject.Destroy(this.gameObject);
                Application.LoadLevel(0);
            }
            else if (col.gameObject.tag != "Enemy")
            {
                Destroy(gameObject);
                Application.LoadLevel(2);
            }
        }
        function Awake()
        {
            Destroy(gameObject, lifetime);
        }
     
       