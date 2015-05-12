#pragma strict
var lifetime = 2;
function OnTriggerEnter (col : Collider)
{
	if (col.gameObject.tag == "Enemy")
	{
		gameObject.Find("Main Camera").GetComponent(Stats).current_score += 250;
		Destroy(gameObject);
		Destroy(col.gameObject);
	}
	else if (col.gameObject.name != "bed1")
	{
		Destroy(gameObject);
	}
}

function Awake()
{
    Destroy(gameObject, lifetime);
}