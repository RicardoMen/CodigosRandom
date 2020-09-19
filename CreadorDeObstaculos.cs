using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreadorDeObstaculos : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] Obstaculos;
    
    public float PosXIni;
    public float PosXFinal;


    public float PosYIni;
    public float PosYFinal;

    public float PosZini;
    public float PosZFinal;

    public float TiempoDeCreacion;
     float timer;

    
    void Start()
    {
        timer = 0 ;
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;

        if (timer >= TiempoDeCreacion) 
        {

            CreadorDeTropiezos();
            timer = 0;
        
        }

    }
    public void CreadorDeTropiezos() 
    {
        GameObject ObstaculoGenerado;
        int index;

        float RandomX;
        float randomY;
        float randomZ;


        index = Random.Range(0, Obstaculos.Length);
        RandomX = Random.Range(PosXIni, PosXFinal);
        randomY = Random.Range(PosYIni, PosYFinal);
        randomZ = Random.Range(PosZini, PosZFinal);
        ObstaculoGenerado = Obstaculos[index];



        Instantiate(ObstaculoGenerado, new Vector3(RandomX, randomY, randomZ), Quaternion.identity);
    
    }
}
