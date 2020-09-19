using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreadorInstantaneo: MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] Obstaculos;
    public float CantidadDeobjetos;

  

    GameObject ObstaculoGenerado;

    public float Salto;
    public float DistanciaEntre;


    void Start()
    {
        for (int i = 0; i < CantidadDeobjetos; i++)
        {
            int index;
            index = Random.Range(0, Obstaculos.Length);
            ObstaculoGenerado = Obstaculos[index];

            Instantiate(ObstaculoGenerado, new Vector3(Random.Range(gameObject.transform.position.x - DistanciaEntre, gameObject.transform.position.x + DistanciaEntre), gameObject.transform.position.y, gameObject.transform.position.z),Quaternion.identity);
            gameObject.transform.position += new Vector3(0, 0, Salto);
        }
    }

    // Update is called once per frame
    void Update()
    {
      /*  if (CantidadDeobjetos > 0) 
        {
            CreadorDeTropiezos();
            CantidadDeobjetos--;
        }*/
    }
   
}
