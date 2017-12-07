using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CerrarRegistro : MonoBehaviour {

	public Animator animRegistro;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnMouseDown()
	{
		animRegistro.SetTrigger ("Alejandose");
		animRegistro.SetTrigger ("Inicio");
	}
}
