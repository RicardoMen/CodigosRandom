using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updateGps : MonoBehaviour
{
    public Text coordinates;
    public Text distance;

    // Update is called once per frame
    private void Update()
    {
        coordinates.text = "Lat:" + GpsAumented.Instance.latitude.ToString() + " Long:" + GpsAumented.Instance.longitude.ToString();

        
    }
}
