using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirMaps : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnMouseDown()
	{
		Application.OpenURL("https://www.google.com.mx/maps/place/Museo+Memoria+y+Tolerancia/@19.4341805,-99.1468094,17z/data=!3m1!4b1!4m5!3m4!1s0x85d1fed5593d1a21:0x75489a9d103120f1!8m2!3d19.4341805!4d-99.1446207");
	}
}
