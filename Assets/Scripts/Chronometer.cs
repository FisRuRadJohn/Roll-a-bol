using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chronometer : MonoBehaviour
{

    public Text chrono;
    private float seg = 0f;
    public float tiemporestante = 120f;

    void Start()
    {
        chrono.text = "0.0";
    }

    // Update is called once per frame
    void Update()
    {
        seg += Time.deltaTime;                  //crono hacia alante
        chrono.text = "TIME : " + seg;

        seg = Time.deltaTime;                   // crono hacia atras 
        tiemporestante -= seg;

        chrono.text = "time :" + Mathf.Floor(tiemporestante); 


    }
}
