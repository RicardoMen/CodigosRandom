using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GPSPlayer : MonoBehaviour {
    //public static GPSPlayer Instance { set; get; }
    public float latitude;
    public float longitude;
    public Text TextoCord;
    public GameObject target;

    public GameObject Sensor;
    void Start () {
        //Instance = this;
        //DontDestroyOnLoad(gameObject);
        StartCoroutine (starLocationService ());
        Input.compass.enabled = true;

    }

    // Update is called once per frame
    void FixedUpdate () {
        latitude = Input.location.lastData.latitude;
        longitude = Input.location.lastData.longitude;
        TextoCord.text = "Latitude = " + latitude + " Longitude=" + longitude;

        if (Input.compass.enabled == true) {
            Sensor.SetActive (true);
        }
       Sensor.SetActive(false);
    }
    private IEnumerator starLocationService () {
        if (!Input.location.isEnabledByUser) {
            yield break;
        }
        Input.location.Start ();
        int maxWait = 20;
        while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0) {
            yield return new WaitForSeconds (1);
            maxWait--;
        }
        if (maxWait <= 0) {
            Debug.Log ("Time out");
            yield break;
        }

        if (Input.location.status == LocationServiceStatus.Failed) {
            yield break;
        }
        latitude = Input.location.lastData.latitude;
        longitude = Input.location.lastData.latitude;
        yield break;
    }
    private float CalculateDistance (float lat_1, float lat_2, float long_1, float long_2) {
        int R = 6371;
        var lat_rad_1 = Mathf.Deg2Rad * lat_1;
        var lat_rad_2 = Mathf.Deg2Rad * lat_2;
        var d_lat_rad = Mathf.Deg2Rad * (lat_2 - lat_1);
        var d_long_rad = Mathf.Deg2Rad * (long_2 - long_1);
        var a = Mathf.Pow (Mathf.Sin (d_lat_rad / 2), 2) + (Mathf.Pow (Mathf.Sin (d_long_rad / 2), 2) * Mathf.Cos (lat_rad_1) * Mathf.Cos (lat_rad_2));
        var c = 2 * Mathf.Atan2 (Mathf.Sqrt (a), Mathf.Sqrt (1 - a));
        var total_dist = R * c * 1000; // convert to meters
        return total_dist;
    }
}