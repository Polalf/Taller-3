using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linterna : MonoBehaviour
{
    public bool encendido = false;
    
   public void encenderLinterna()
    {
        encendido = !encendido;
    }
}
