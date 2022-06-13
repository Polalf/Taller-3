using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");

        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update"+transform.position);
        transform.rotation = Quaternion.Euler(0,0,(1 * Time.deltaTime) + transform.rotation.eulerAngles.z);
        if (Input.GetKey("KeyD")
              {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
            spriteRenderer.flipX = false;
        }
        else if (Input.GetKey("KeyA"))
        {
            transform.position += Vector3.right * -moveSpeed * Time.deltaTime;
            spriteRenderer.flipX = true;
        }
    }
}
}
