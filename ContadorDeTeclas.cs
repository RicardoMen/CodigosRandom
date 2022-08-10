using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Events;


public class ContadorDeTeclas : MonoBehaviour
{

    // Start is called before the first frame update
     private static readonly KeyCode[] keyCodes = Enum.GetValues(typeof(KeyCode))
        .Cast<KeyCode>()
        .Where(k => ((int)k < (int)KeyCode.Mouse0))
        .ToArray();
    public int NroPress;

    public float[] Contadores;


    // Update is called once per frame
    private void Start()
    {
        ResetContador();
    }
    private void Update()
    {
        foreach (var key in keyCodes)
        {
            if (Input.GetKeyDown(key)) NroPress++;

            if (Input.GetKeyUp(key)) NroPress--;
        }

        if (NroPress == 1) 
        {
            Contadores[0] += Time.deltaTime;
        
        }
        if (NroPress == 2)
        {

            Contadores[1] += Time.deltaTime;
        }
        if (NroPress == 3)
        {
            Contadores[2] += Time.deltaTime;

        }
        if (NroPress == 4)
        {
            Contadores[3] += Time.deltaTime;

        }
        if (NroPress == 5)
        {
            Contadores[4] += Time.deltaTime;


        }

    }
    public void ResetContador()
    {
        for (int i = 0; i < Contadores.Length; i++)
        {
            Contadores[i] = 0;
        }
    }

}
