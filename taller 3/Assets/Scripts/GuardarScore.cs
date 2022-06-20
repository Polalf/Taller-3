using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GuardarScore : MonoBehaviour
{  
    string id = "score";
    [SerializeField] TextMeshProUGUI texto_ui;
    int score_actual;

    // Start is called before the first frame update
    void Start()
    {
         score_actual = PlayerPrefs.GetInt(id,0);

        texto_ui.text = "Score:" + score_actual;

        PlayerPrefs.SetFloat(id, score_actual);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int addScore)
    {
        score_actual = score_actual + addScore;
        Debug.Log("score adde" + addScore + "Score Final"+ score_actual);
        texto_ui.text = "Score:" + score_actual;
    }

   
}
