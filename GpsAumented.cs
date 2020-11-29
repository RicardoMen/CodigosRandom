using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using Assets.SimpleAndroidNotifications;

public class GpsAumented : MonoBehaviour


{

    // Use this for initialization
    public static GpsAumented Instance { set; get; }
    public Assets.SimpleAndroidNotifications.Notification NotificacionScript;

    public float latitude;
    public float longitude;
    public Text texto;
    public Text metros;
    public Text metros2;
    public Text metros3;
    public Text metros4;
    public Text mensaje1;
    public Text mensaje2;
    public Text mensaje3;
    public Text mensaje4;
    public GameObject[] botones;
    public GameObject[] imagenes;

    public float distanceEstatua;
    public float ditanciaPeruanidad;
    public float distance28Julio;
    public float distancefuture;

    bool activador1;
    bool activador2;
    bool activador3;
    bool activador4;
    public float tiempo;

    void Start()
    {
        activador1 = false;
        activador2 = false;
        activador3 = false;
        activador4 = false;
        Instance = this;
        DontDestroyOnLoad(gameObject);
        StartCoroutine(starLocationService());
    }

    // Update is called once per frame
    void FixedUpdate()
    {


        latitude = Input.location.lastData.latitude;
        longitude = Input.location.lastData.longitude;
        //texto.text = "Lat:" + Instance.latitude.ToString() + " Long:" + Instance.longitude.ToString();
        distanceEstatua = CalculateDistance(latitude, -12.068526f, longitude, -77.04095f);
        ditanciaPeruanidad = CalculateDistance(latitude, -12.065397f, longitude, -77.039732f);
        distance28Julio = CalculateDistance(latitude, -12.064847f, longitude, -77.039551f);
        distancefuture = CalculateDistance(latitude, -12.067972f, longitude, -77.040372f);


        metros.text = "Distancia para llegar al monumento de los heroes: " + System.Math.Round(distanceEstatua, 2).ToString();
        metros2.text = "Distancia para llegar a av la peruanidad: " + System.Math.Round(ditanciaPeruanidad, 2).ToString();
        metros3.text = "Distancia para llegar a 28 de julio: " + System.Math.Round(distance28Julio, 2).ToString();
        metros4.text = "Distancia para llegar a Future Park " + System.Math.Round(distancefuture, 2).ToString();
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        if (distanceEstatua <= 25)
        {


            mensaje1.text = "Bienvenido al monumento de los heroes";
            botones[0].SetActive(true);

            if (activador1 == false)
            {
                notificacion("Destino capturado", "Bienvenido al monumento de los heroes");
                activador1 = true;
                Handheld.Vibrate();
            }
        }
        if (distanceEstatua >= 25) { activador1 = false; }

        //////////////////////////////////////////////////////


        if (ditanciaPeruanidad <= 25)
        {

            mensaje2.text = "Estas camino a Av de la peruanidad";
            botones[1].SetActive(true);

            if (activador2 == false)
            {
                notificacion("Destino capturado", "Estas camino a Av de la peruanidad");
                activador2 = true;
                Handheld.Vibrate();
            }
        }
        if (ditanciaPeruanidad >= 25) { activador2 = false; }
        if (distance28Julio <= 25)
        {
            mensaje3.text = "Estas camino a Av 28 de Julio";
            botones[2].SetActive(true);


            if (activador3 == false)
            {
                notificacion("Destino capturado", "Estas camino a Av 28 de Julio");
                activador3 = true;
                Handheld.Vibrate();
            }
        }
        if (distance28Julio >= 25) { activador3 = false; }
        if (distancefuture <= 25)
        {
            mensaje4.text = "Bienvenido a Future Park";
            botones[3].SetActive(true);

            if (activador4 == false)
            {
                notificacion("Destino capturado", "Bienvenido a Future Park");
                activador4 = true;
                Handheld.Vibrate();
            }
        }
        if (distancefuture >= 25) { activador4 = false; }
    }
    public void notificacion(string Titulo, string Mensaje)
    {
    NotificacionScript.sendNotif(1, Titulo, Mensaje);
    }


    private IEnumerator starLocationService()
    {

        if (!Input.location.isEnabledByUser)
        {
            yield break;
        }
        Input.location.Start();
        int maxWait = 20;
        while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
        {
            yield return new WaitForSeconds(1);
            maxWait--;
        }
        if (maxWait <= 0)
        {
            Debug.Log("Time out");
            yield break;
        }

        if (Input.location.status == LocationServiceStatus.Failed)
        {
            yield break;
        }
        latitude = Input.location.lastData.latitude;
        longitude = Input.location.lastData.latitude;
        yield break;

    }
    private float CalculateDistance(float lat_1, float lat_2, float long_1, float long_2)
    {
        int R = 6371;
        var lat_rad_1 = Mathf.Deg2Rad * lat_1;
        var lat_rad_2 = Mathf.Deg2Rad * lat_2;
        var d_lat_rad = Mathf.Deg2Rad * (lat_2 - lat_1);
        var d_long_rad = Mathf.Deg2Rad * (long_2 - long_1);
        var a = Mathf.Pow(Mathf.Sin(d_lat_rad / 2), 2) + (Mathf.Pow(Mathf.Sin(d_long_rad / 2), 2) * Mathf.Cos(lat_rad_1) * Mathf.Cos(lat_rad_2));
        var c = 2 * Mathf.Atan2(Mathf.Sqrt(a), Mathf.Sqrt(1 - a));
        var total_dist = R * c * 1000; // convert to meters
        return total_dist;
    }

    public void botonclick(int x)
    {
        if (x == 0)
        {
            imagenes[0].SetActive(true);
        }
        if (x == 1)
        {
            imagenes[1].SetActive(true);
        }
        if (x == 2)
        {
            imagenes[2].SetActive(true);
        }
        if (x == 3)
        {
            imagenes[3].SetActive(true);
        }
    }
    public void cerrar(GameObject button)
    {
        button.SetActive(false);

    }



}
