using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;
using UnityEngine.UI;

public class JoystickInput : MonoBehaviour
{

    ControlOfInputs ControlOfInputsScript;

    private InputAction test;
    private InputActionReference Actionreference;
   
    public float[] Contadores;
    public int BotonesPresionados;
    public float SumaTotal;
    public Text[] TextosPorcentajes; 
    void Awake()
    {
        ControlOfInputsScript = new ControlOfInputs();
     
        // ControlOfInputsScript.Gameplay.abajo.started += ctx => Fire2();
    }
    private void Start()
    {
        ResetContador();
    }
    private void OnEnable()
    {
        ControlOfInputsScript.Enable();
    }
    private void OnDisable()
    {
        ControlOfInputsScript.Disable();
    }
    // Update is called once per frame
 

    
 
     void Update()
    {

        ControlBotones();
        Cronometros();
  
  

    }
    public void ControlBotones()
    {
        //Boton Cursor Arriba
        if (ControlOfInputsScript.Gameplay.Arriba.WasPressedThisFrame())
        {
            Debug.Log("Press");

            BotonesPresionados++;
        }
        if (ControlOfInputsScript.Gameplay.Arriba.WasReleasedThisFrame())

        {
            Debug.Log("Release");
            BotonesPresionados--;
        }
        //Boton Cursor Abajo
        if (ControlOfInputsScript.Gameplay.abajo.WasPressedThisFrame())
        {
            Debug.Log("Press");
            BotonesPresionados++;

        }
        if (ControlOfInputsScript.Gameplay.abajo.WasReleasedThisFrame())
        {
            Debug.Log("Release");
            BotonesPresionados--;
        }
        //Boton izquierda
        if (ControlOfInputsScript.Gameplay.Izquierda.WasPressedThisFrame())
        {
            Debug.Log("Press");
            BotonesPresionados++;

        }
        if (ControlOfInputsScript.Gameplay.Izquierda.WasReleasedThisFrame())
        {
            Debug.Log("Release");
            BotonesPresionados--;
        }
        //Boton Derecha
        if (ControlOfInputsScript.Gameplay.Derecha.WasPressedThisFrame())
        {
            Debug.Log("Press");
            BotonesPresionados++;

        }
        if (ControlOfInputsScript.Gameplay.Derecha.WasReleasedThisFrame())
        {
            Debug.Log("Release");
            BotonesPresionados--;
        }
        //Boton A
        if (ControlOfInputsScript.Gameplay.A.WasPressedThisFrame())
        {
            Debug.Log("Press");
            BotonesPresionados++;

        }
        if (ControlOfInputsScript.Gameplay.A.WasReleasedThisFrame())
        {
            Debug.Log("Release");
            BotonesPresionados--;
        }
        //Boton B
        if (ControlOfInputsScript.Gameplay.B.WasPressedThisFrame())
        {
            Debug.Log("Release");
            BotonesPresionados++;
        }
        if (ControlOfInputsScript.Gameplay.B.WasReleasedThisFrame())
        {
            Debug.Log("Release");
            BotonesPresionados--;
        }
        //Boton Y
        if (ControlOfInputsScript.Gameplay.Y.WasPressedThisFrame())
        {
            Debug.Log("Press");

            BotonesPresionados++;
        }
        if (ControlOfInputsScript.Gameplay.Y.WasReleasedThisFrame())

        {
            Debug.Log("Release");
            BotonesPresionados--;
        }
        //Boton X
        if (ControlOfInputsScript.Gameplay.X.WasPressedThisFrame())
        {
            Debug.Log("Press");

            BotonesPresionados++;
        }
        if (ControlOfInputsScript.Gameplay.X.WasReleasedThisFrame())

        {
            Debug.Log("Release");
            BotonesPresionados--;
        }
        //Boton L1
        if (ControlOfInputsScript.Gameplay.L1.WasPressedThisFrame())
        {
            Debug.Log("Press");

            BotonesPresionados++;
        }
        if (ControlOfInputsScript.Gameplay.L1.WasReleasedThisFrame())

        {
            Debug.Log("Release");
            BotonesPresionados--;
        }
        //Boton L2
        if (ControlOfInputsScript.Gameplay.L2.WasPressedThisFrame())
        {
            Debug.Log("Press");

            BotonesPresionados++;
        }
        if (ControlOfInputsScript.Gameplay.L2.WasReleasedThisFrame())

        {
            Debug.Log("Release");
            BotonesPresionados--;
        }
        //Boton L3
        if (ControlOfInputsScript.Gameplay.L3.WasPressedThisFrame())
        {
            Debug.Log("Press");

            BotonesPresionados++;
        }
        if (ControlOfInputsScript.Gameplay.L3.WasReleasedThisFrame())

        {
            Debug.Log("Release");
            BotonesPresionados--;
        }
        //Boton R1
        if (ControlOfInputsScript.Gameplay.R1.WasPressedThisFrame())
        {
            Debug.Log("Press");

            BotonesPresionados++;
        }
        if (ControlOfInputsScript.Gameplay.R1.WasReleasedThisFrame())

        {
            Debug.Log("Release");
            BotonesPresionados--;
        }
        //Boton R2
        if (ControlOfInputsScript.Gameplay.R2.WasPressedThisFrame())
        {
            Debug.Log("Press");

            BotonesPresionados++;
        }
        if (ControlOfInputsScript.Gameplay.R2.WasReleasedThisFrame())

        {
            Debug.Log("Release");
            BotonesPresionados--;
        }
        //Boton R3
        if (ControlOfInputsScript.Gameplay.R3.WasPressedThisFrame())
        {
            Debug.Log("Press");

            BotonesPresionados++;
        }
        if (ControlOfInputsScript.Gameplay.R3.WasReleasedThisFrame())

        {
            Debug.Log("Release");
            BotonesPresionados--;
        }
        //Boton Select
        if (ControlOfInputsScript.Gameplay.Select.WasPressedThisFrame())
        {
            Debug.Log("Press");

            BotonesPresionados++;
        }
        if (ControlOfInputsScript.Gameplay.Select.WasReleasedThisFrame())

        {
            Debug.Log("Release");
            BotonesPresionados--;
        }
        //Boton Start
        if (ControlOfInputsScript.Gameplay.Start.WasPressedThisFrame())
        {
            Debug.Log("Press");

            BotonesPresionados++;
        }
        if (ControlOfInputsScript.Gameplay.Start.WasReleasedThisFrame())

        {
            Debug.Log("Release");
            BotonesPresionados--;
        }
        //Boton StickIzquierdo

        if (ControlOfInputsScript.Gameplay.RuedaIzqueirda.WasPressedThisFrame())
        {
            Debug.Log("Press");

            BotonesPresionados++;
        }
        if (ControlOfInputsScript.Gameplay.RuedaIzqueirda.WasReleasedThisFrame())

        {
            Debug.Log("Release");
            BotonesPresionados--;
        }
        //Boton StickDrrecho
        if (ControlOfInputsScript.Gameplay.RuedaDerecha.WasPressedThisFrame())
        {
            Debug.Log("Press");

            BotonesPresionados++;
        }
        if (ControlOfInputsScript.Gameplay.RuedaDerecha.WasReleasedThisFrame())

        {
            Debug.Log("Release");
            BotonesPresionados--;
        }

    }
    public void ResetContador()
    {
        for (int i = 0; i < Contadores.Length; i++)
        {
            Contadores[i] = 0;
        }
    }
    public void Cronometros() 
    {

        if (BotonesPresionados == 1)
        {
            Contadores[0] += Time.deltaTime;
            

        }
        if (BotonesPresionados == 2)
        {

            Contadores[1] += Time.deltaTime;
        }
        if (BotonesPresionados == 3)
        {
            Contadores[2] += Time.deltaTime;

        }
        if (BotonesPresionados == 4)
        {
            Contadores[3] += Time.deltaTime;

        }
        if (BotonesPresionados == 5)
        {
            Contadores[4] += Time.deltaTime;
        }

    }

  public  float Porcentaje(float Parte, float Total) 
    {
        float a = (Parte / Total) * 100;

        return a;
    
    }
    public void CalcularTodasLasSumas() 
    {
        
        for (int i = 0; i < Contadores.Length; i++)
        {
            SumaTotal += Contadores[i];
        }
        for (int i = 0; i <Contadores.Length; i++)
        {
            TextosPorcentajes[i].text = Porcentaje(Contadores[i], SumaTotal).ToString("F2") + "%";
        }
      
    }
}
