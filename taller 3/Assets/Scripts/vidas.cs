using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidas : MonoBehaviour
{
    public int vida = 5;
    

    void Start()
    {
        vida = 5;
    }

    
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            vida = vida -1;
            if (vida <= 0)
            {
                //game over
                

            }
        }
    }
}
