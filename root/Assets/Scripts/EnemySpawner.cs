using UnityEngine;
using System.Collections;


public class EnemySpawner : MonoBehaviour
{
    public int numenemy = 10;
    public GameObject enemy;                // The enemy array prefab to be spawned.
    public float spawnTime = 3f;            // How long between each spawn.

    void Start()
    {
        for (int i = 0; i < numenemy; i++)
        {
            Spawn();
        }

        // Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
        //InvokeRepeating ("Spawning", spawnTime, spawnTime);
    }

    private int xBounds = 500;
    private int zBounds = 500;

    void Spawn()
    {
        int x = Random.Range(0, xBounds);
        int y = 0;
        int z = Random.Range(0, zBounds);

        Vector3 randomAssPosition = new Vector3(x, y, z);
        GameObject bro = Instantiate(enemy, randomAssPosition, Quaternion.identity) as GameObject;
        //bro.transform.localScale *= 15;
    }
}