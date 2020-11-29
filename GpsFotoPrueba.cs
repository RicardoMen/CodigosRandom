using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class GpsFotoPrueba : MonoBehaviour {
 public RawImage img;

	string url;

	public float lat;
	public float lon;

	LocationInfo li;

	public int zoom = 14;
	public int mapWidth =640;
	public int mapHeight = 640;

	public enum mapType {roadmap,satellite,hybrid,terrain}
	public mapType mapSelected;
	public int scale;



	// Use this for initialization
	void Start () {
		img = gameObject.GetComponent<RawImage> ();
		StartCoroutine (Map());
	}
	
	// Update is called once per frame
	void Update () 
    {
        if(Input.GetKeyDown(KeyCode.K))
        {
            zoom--;
        }  
        if(Input.GetKeyDown(KeyCode.L))
        {
            zoom++;
        }

	}

    	IEnumerator Map()
	{
		url = "https://maps.googleapis.com/maps/api/staticmap?center=" + lat + "," + lon +
			"&zoom=" + zoom + "&size=" + mapWidth + "x" + mapHeight + "&scale=" + scale 
			+"&maptype=" + mapSelected +
            //"&path=color:0xff0000ff|weight:5|-12.068433,-77.041384|-12.068565, -77.041460"+
			"&markers=color:blue%7Clabel:S%7C"+"-12.068433"+",-77.041384"+
            "&key=AIzaSyAv0a36zOVO41qDLwhqV1lY4g1-ynVr9do";
		WWW www = new WWW (url);
		yield return www;
		img.texture = www.texture;
	}

}