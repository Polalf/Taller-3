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
        if (moveX == 0 )
        {
            if(moveY < 0)
            {
                transform.rotation = Quaternion.Euler(0,0, 180);
            }
            else if (moveY > 0)
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
        }
        if (moveX > 0)
        { 
            if (moveY < 0)
            {
                transform.rotation = Quaternion.Euler(0, 0, 225);
            }
            else if (moveY > 0)
            {
                transform.rotation = Quaternion.Euler(0, 0, 315);
            }
            else
            {
                transform.rotation = Quaternion.Euler(0, 0, 270);
            }
        }
        if (moveX < 0)
        {
            if (moveY < 0)
            {
                transform.rotation = Quaternion.Euler(0, 0, 135);
            }
            else if (moveY > 0)
            {
                transform.rotation = Quaternion.Euler(0, 0, 45);
            }
            else
            {
                transform.rotation = Quaternion.Euler(0, 0, 90);
            }
        }
    }
    private void FixedUpdate()
    {
        playerRb.MovePosition(playerRb.position + moveInput * speed * Time.fixedDeltaTime);

    }
}

    