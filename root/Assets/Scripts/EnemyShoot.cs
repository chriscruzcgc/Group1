
using UnityEngine;
using System.Collections;

public class EnemyShoot : MonoBehaviour
{
    public float minShootDelay = 1.0f;
    public float maxShootDelay = 5.0f;
    private float nextShootTime = 2.0f;
    public float speed;
    public GameObject bullet;
    public float lifetime = 2.0f;
    private Vector3 target;
    public float timeS;
    void Start()
    {
         
        this.nextShootTime = Random.Range(minShootDelay, maxShootDelay);


    }

    void Update()
    {
        this.target = this.transform.position - Vector3.down;//new Vector3(0, -20, 0);
        /*Vector3 newVelocity = Vector3.down;
        newVelocity.y = speed;*/
        if (Time.timeSinceLevelLoad > nextShootTime)
        {
            GameObject bu =  Instantiate(bullet, this.transform.position, Quaternion.identity) as GameObject;
            bu.GetComponent<Rigidbody>().useGravity = true;
            nextShootTime = Time.time + Random.Range(minShootDelay, maxShootDelay);
            // EnemyBulletPrefab.GetComponent.<Rigidbody>().AddForce(Vector3.up * 115);
        }
        
        
    }
}
  