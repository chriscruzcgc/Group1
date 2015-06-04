using UnityEngine;
using System.Collections;

public class ShootNew : MonoBehaviour
{
    public Rigidbody projectile;
    public float speed = 0.5f;
    public float ammo = 0f;
    public float maxAmmo = 10f;
    public GUIText ammoText;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonUp("Fire1") && ammo < maxAmmo)
        {

            GameObject clone = Instantiate(projectile, transform.position, transform.rotation) as GameObject;
           // clone.transform = transform.TransformDirection(0, 0, speed);
            ammo++;

            Destroy(clone.gameObject, 5);
            //GetComponent.<ParticleSystem>().Play();
            ParticleSystem particle = (ParticleSystem)gameObject.GetComponent("ParticleSystem");
            particle.enableEmission = true;
        }
        if (ammo == maxAmmo)
        {
            Application.LoadLevel("NakedEnd");
        }
    }

    void OnGUI()
    {
        ammoText.text = "Ammo: " + ammo + "/" + maxAmmo;
    }
}