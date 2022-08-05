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
        currentPlayer = GameObject.FindGameObjectWithTag("Player");
        if (currentPlayer == null)
        {
            currentPlayer = Instantiate(playerPrefab,respawnPosition,Quaternion.identity);
            currentPlayer.GetComponent<coleccionables>().setPlayerUi();
        }
        else
        {
            //Setear datos player
            currentPlayer.transform.position = respawnPosition;
            currentPlayer.GetComponent<coleccionables>().setPlayerUi();
            currentPlayer.GetComponent<coleccionables>().checkUIcollectables();
        }
    }
}
