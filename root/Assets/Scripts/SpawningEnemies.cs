using UnityEngine;
using System.Collections;

public class SpawningEnemies : MonoBehaviour {

	// Use this for initialization
	void Start () 
    {
        SpawnEnemies();
	}
	
	// Update is called once per frame
	void Update () {

        if (numberOfEnemies == 0)
        {
            gameOver = true;
        }
	}

    [ContextMenu ("Populate")]
    void SpawnEnemies()
    {
        Vector3 xOffset = new Vector3(8, -4, 0);
        Vector3 yOffset = new Vector3(-5, 5.5f, -3);
        for (int i = 0; i < numberOfEnemies; i++)
        {

           
            //makeadude
            GameObject dude = Instantiate(enemyPrefab) as GameObject;
            dude.transform.parent = this.gameObject.transform;
            //sethisposition
            dude.transform.position += xOffset + yOffset;
            if (i % numberOfColumns == 0)
            {
                xOffset = Vector3.zero;
                yOffset += Vector3.down; 
            }

            if (numberOfEnemies <= 0)
            {
                gameOver = true;
            }
            xOffset += Vector3.right;

            //go to next dude
            dude.SetActive(true);
        }

       
    }

    [ContextMenu("UnPopulate")]
    void DeSpawn()
    {
        foreach (Transform t in transform)
            DestroyImmediate(t.gameObject);

    }

    public GameObject enemyPrefab;
    public int numberOfEnemies;
    public int numberOfColumns;
    private bool gameOver;
    //public Rigidbody EnemyBulletPrefab;
}
