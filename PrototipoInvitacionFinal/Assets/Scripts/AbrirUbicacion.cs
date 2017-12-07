using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirUbicacion : MonoBehaviour {

	public Animator animUbicacion;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnMouseDown()
	{
		animUbicacion.SetTrigger ("Acercado");
		animUbicacion.SetTrigger ("Info");
	}
}
