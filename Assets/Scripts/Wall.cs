using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public bool breakable = false;
    public int health = 0;

    void Start()
    {
        
    }


  public  void TakeDamage()
    {
        if (breakable == true)
        {
            health--;
            if(health <= 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
    
    
        
    }

