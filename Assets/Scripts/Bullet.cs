using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float lifeTime = 5f;
    public float bulletSpeed = 10f;

    private void Start()
    {
    }

    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * bulletSpeed * Time.deltaTime);

        lifeTime -= Time.deltaTime;
        if (lifeTime <= 0)
        {
            Debug.Log("no hit");
            DestroyBullet();
        }
    }

     void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Wall")
        {
            Wall wall = collider.GetComponent<Wall>();

            wall.TakeDamage();
          
        }
        if (collider.gameObject.tag != "Player")
        {
            Debug.Log("i hit");
            DestroyBullet();
        }
    }

    void DestroyBullet()
    {

        GameObject playerObject = GameObject.FindWithTag("Player");
        Player playerValues = playerObject.GetComponent<Player>();

        playerValues.shotsFired = false;

        Destroy(this.gameObject);
    }
}
    