using UnityEngine;
using System.Collections;
//using System.Collections.Generic;

public class Cloud : MonoBehaviour
{
	public GameObject neutralPrefab;
    public int numberOfNeutral;

	private Vector3 initialPos;

	public float speed = 3.0f;
	public float life = 4.0f;

	float timeToDie = 4.0f;
	float startTime = 0.0f;
    public int min, max;

	//Lifetime of clouds
	void OnEnable()
	{
		timeToDie = life + Time.timeSinceLevelLoad;
        PlaceNeutral();
	}

    void PlaceNeutral()
    {
        GameObject neutralCloudParent = new GameObject("ntrlParent");
        for (int i = 0; i < numberOfNeutral; i++)
        {
            neutralCloudParent.transform.parent = this.gameObject.transform;
            GameObject neutralCloud = Instantiate(neutralPrefab, GeneratedPosition(), Quaternion.AngleAxis(180, Vector3.up)) as GameObject;
            neutralCloud.transform.parent = neutralCloudParent.transform;

        }
    }

    Vector3 GeneratedPosition()
    {
        int x, y, z;
        x = UnityEngine.Random.Range(min, max);
        y = UnityEngine.Random.Range(min, 0);
        z = UnityEngine.Random.Range(min, max);
        return new Vector3(x, y, z);
    }
    
	// Use this for initialization
	void Start () 
	{
		initialPos = transform.position;
	}

	// Update is called once per frame
	void Update () 
	{
		startTime += Time.deltaTime;
		//Moves the clouds in an upward position
		this.transform.Translate (Vector3.up * Time.deltaTime * speed);

		//Reset clouds position if they are past their lifetime
		if(startTime > timeToDie)
		{
			startTime = 0.0f;
            transform.position = initialPos;
		}
	}
}
