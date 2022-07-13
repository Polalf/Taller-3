using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move8 : MonoBehaviour
{ 
    [SerializeField]private float speed = 3f;
    private Rigidbody2D playerRb;
    private Vector2 moveInput;
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        moveInput = new Vector2(moveX, moveY).normalized;

        if (moveX == 1 && moveY == 1)
        {
            //diagonal derecha arriba
            Debug.Log("diagonal derecha arriba");
            transform.rotation = Quaternion.Euler(0, 0, 315);
        }
        if (moveX == 1 && moveY == 0)
        {
            // derecha
            Debug.Log("derecha");
            transform.rotation = Quaternion.Euler(0, 0, 270);
        }
        if (moveX == 1 && moveY == -1)
        {
            //diagonal derecha abajo
            Debug.Log("diagonal derecha abajo");
            transform.rotation = Quaternion.Euler(0, 0, 225);
        }
        if (moveX == 0 && moveY == -1)
        {
            //abajo
            Debug.Log("abajo");
            transform.rotation = Quaternion.Euler(0, 0, 180);
        }
        if (moveX == -1 && moveY == -1)
        {
            //diagonal izq anajo
            Debug.Log("diagonal izq anajo");
            transform.rotation = Quaternion.Euler(0, 0, 135);
        }
        if (moveX == -1 && moveY == 0)
        {
            //izq
            Debug.Log("izq");
            transform.rotation = Quaternion.Euler(0, 0, 90);
        }
        if (moveX == -1 && moveY == 1)
        {
            //diagonal izq arriba
            Debug.Log("diagonal izq arriba");
            transform.rotation = Quaternion.Euler(0, 0, 45);
        }
        if (moveX == 0 && moveY == 1)
        {
            // arriba
            Debug.Log("arriba");
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
    private void FixedUpdate()
    {
        playerRb.MovePosition(playerRb.position + moveInput * speed * Time.fixedDeltaTime);

    }
}

    