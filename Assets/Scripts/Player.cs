using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float movementSpeed = 10f;
    public float rotateSpeed = 10f;

    public GameObject bullet;

    public bool  shotsFired = false;
    

   
    void FixedUpdate()
    {
        // K��nt� Inputit
        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * rotateSpeed * Time.deltaTime);
        }
        

        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
        }
        // Liikutus Inputit
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
        }


        else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * movementSpeed * Time.deltaTime);
        }

        // Ampuminen
        if (Input.GetKey(KeyCode.Space) && shotsFired == false)
        {
            Shoot();
            //Debug.Log("Pam");
            
        }
    }

    public void Shoot()
    {
        shotsFired = true;
        Debug.Log("Pam");
        Transform firePosition = this.transform;
        Instantiate(bullet, new Vector3(firePosition.position.x, firePosition.position.y, firePosition.position.z), firePosition.rotation);
    }

    }

