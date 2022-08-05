using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coleccionables : MonoBehaviour
{
    public bool cuerda = false;
    public bool calaca = false;
    public bool oso = false;
    public bool atrapasue�o = false;
    public Image imgcuerda;
    public Image imgcalaca;
    public Image imgoso;
    public Image imgatrapasue�o;

    void Start()
    {
        cuerda = false;
        calaca = false;
        oso = false;
        atrapasue�o = false;
        imgcuerda.gameObject.SetActive(false);
        imgcalaca.gameObject.SetActive(false);
        imgoso.gameObject.SetActive(false);
        imgatrapasue�o.gameObject.SetActive(false);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("pentagrama") && cuerda == true && calaca == true && oso == true && atrapasue�o == true)// sirve sin poner el == true
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
        if (collision.gameObject.name == "atrapasue�o")
        {
            atrapasue�o = true;
            imgatrapasue�o.gameObject.SetActive(true);
            Destroy(collision.gameObject);
        }
    }

    public void setPlayerUi()
    {
        imgatrapasue�o = GameObject.Find("UIatrapasue�o").GetComponent<Image>();
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

        if (atrapasue�o)
        {
            imgatrapasue�o.gameObject.SetActive(true);
        }
        else
        {
            imgatrapasue�o.gameObject.SetActive(false);
        }
    }
}
