using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leveloaded : MonoBehaviour
{
    public GameObject currentPlayer = null;
    public GameObject playerPrefab = null;
    public Vector3 respawnPosition;

    // Start is called before the first frame update
    void Start()
    {
        currentPlayer = GameObject.Find("pl");
        if (currentPlayer == null)
        {
            Instantiate(playerPrefab);
        }
        else
        {
            //Setear datos player
            currentPlayer.transform.position = respawnPosition;
        }
    }


}
