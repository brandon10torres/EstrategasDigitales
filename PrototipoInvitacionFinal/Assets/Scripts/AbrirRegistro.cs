using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirRegistro : MonoBehaviour {

	public Animator animRegistro;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnMouseDown()
	{
		animRegistro.SetTrigger ("Acercado");
		animRegistro.SetTrigger ("Info");
	}
}
