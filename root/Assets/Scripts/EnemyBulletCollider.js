#pragma strict

/*function OnTriggerEnter ( col : Collider)
    {
        if(col.gameObject.name == "bed1")
        {
            Destroy(gameObject);
            Destroy(col.gameObject);
        }
        else if (col.gameObject.tag != "Enemy")
        {
            Destroy(gameObject);
        }
    }*/

    function OnTriggerEnter(col : Collider)
        {
            if(col.gameObject.tag == "Player")
            {
                GameObject.Destroy(col.gameObject);
                GameObject.Destroy(this.gameObject);
            }
            else if (col.gameObject.tag != "Enemy")
            {
                Destroy(gameObject);
            }
        }

       