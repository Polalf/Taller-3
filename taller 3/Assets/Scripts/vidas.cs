using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class vidas : MonoBehaviour
{
    public int vida = 5;
    public float timer = 0;
    public float timetotakeHP = 5f;
    public Image[] vidaUI = new Image[5];
    public int vidaIndex = 5;
    void Start()
    {
        vida = 5;
        for (int i = 0; i < vidaUI.Length; i++)
        {
            vidaUI[i].enabled = true;
        }
    }

    
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= timetotakeHP)
        {
            vida = vida - 1;
            timer = 0;
            vidaUI[vidaIndex].enabled = false;
            vidaIndex--;


        }
        if (vida <= 0)
        {
            //game over
            //SceneManager.LoadScene(sceneIndex);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            vida = vida -1;
            
        }
    }
}
