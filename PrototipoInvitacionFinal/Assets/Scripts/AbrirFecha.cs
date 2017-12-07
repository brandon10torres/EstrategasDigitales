using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirFecha : MonoBehaviour {

	public Animator animFecha;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnMouseDown()
	{
		animFecha.SetTrigger ("Acercado");
		animFecha.SetTrigger ("Info");
	}
}
