using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControlRegistro : MonoBehaviour 
{
	public Text nombre;
	public Text apellido;
	public Text correo;
	public Text error;
	public ControlBD miBD;


	// Use this for initialization
	void Start () 
	{
		error.text = "";
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
	public void SalirMenu()
	{
		SceneManager.LoadScene ("Invitacion");
	}
	public void RegistrarInvitado()
	{
		if (string.IsNullOrEmpty (nombre.text) || string.IsNullOrEmpty (apellido.text) || string.IsNullOrEmpty (correo.text)) {
			error.text = "Ingrese todos los campos";
		} else 
		{
			StartCoroutine(miBD.ConectarBD(nombre.text, apellido.text, correo.text));
		}			
	}

	void respuestaBD(string msj)
	{
		if (msj == "Ingresado") 
		{
			Debug.Log ("Cargar escena invitacion");
			SceneManager.LoadScene ("Invitacion");
		}
	}
}
