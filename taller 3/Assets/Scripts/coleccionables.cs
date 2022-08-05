using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coleccionables : MonoBehaviour
{
    public bool cuerda = false;
    public bool calaca = false;
    public bool oso = false;
    public bool atrapasueño = false;
    public Image imgcuerda;
    public Image imgcalaca;
    public Image imgoso;
    public Image imgatrapasueño;

    void Start()
    {
        cuerda = false;
        calaca = false;
        oso = false;
        atrapasueño = false;
        imgcuerda.gameObject.SetActive(false);
        imgcalaca.gameObject.SetActive(false);
        imgoso.gameObject.SetActive(false);
        imgatrapasueño.gameObject.SetActive(false);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("pentagrama") && cuerda == true && calaca == true && oso == true && atrapasueño == true)// sirve sin poner el == true
        {
            //ending
        }

        if (collision.gameObject.name == "cuerda")
        {
            cuerda = true;
            imgcuerda.gameObject.SetActive(true);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.name == "calaca")
        {
            calaca = true;
            imgcalaca.gameObject.SetActive(true);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.name == "oso")
        {
            oso = true;
            imgoso.gameObject.SetActive(true);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.name == "atrapasueño")
        {
            atrapasueño = true;
            imgatrapasueño.gameObject.SetActive(true);
            Destroy(collision.gameObject);
        }
    }

    public void setPlayerUi()
    {
        imgatrapasueño = GameObject.Find("UIatrapasueño").GetComponent<Image>();
        imgcalaca = GameObject.Find("UIcraneo").GetComponent<Image>();
        imgoso = GameObject.Find("UIoso").GetComponent<Image>();
        imgcuerda = GameObject.Find("UIcuerda").GetComponent<Image>();
    }

    public void checkUIcollectables()
    {
        if (cuerda)
        {
            imgcuerda.gameObject.SetActive(true);
        }
        else
        {
            imgcuerda.gameObject.SetActive(false);
        }

        if (calaca)
        {
            imgcalaca.gameObject.SetActive(true);
        }
        else
        {
            imgcalaca.gameObject.SetActive(false);
        }

        if (oso)
        {
            imgoso.gameObject.SetActive(true);
        }
        else
        {
            imgoso.gameObject.SetActive(false);
        }

        if (atrapasueño)
        {
            imgatrapasueño.gameObject.SetActive(true);
        }
        else
        {
            imgatrapasueño.gameObject.SetActive(false);
        }
    }
}
