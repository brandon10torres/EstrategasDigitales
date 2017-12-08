using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirWaze : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnMouseDown()
	{
		Application.OpenURL ("https://waze.com/ul?ll=19.4341805,-99.1466865,17z");
	}
}
