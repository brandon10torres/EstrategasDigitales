using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CerrarFecha : MonoBehaviour {

	public Animator animFecha;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnMouseDown()
	{
		animFecha.SetTrigger ("Alejandose");
		animFecha.SetTrigger ("Inicio");
	}
}
