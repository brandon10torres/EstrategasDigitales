﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CerrarMesa : MonoBehaviour {

	public Animator animMesa;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnMouseDown()
	{
		animMesa.SetTrigger ("Alejandose");
		animMesa.SetTrigger ("Inicio");
	}
}
