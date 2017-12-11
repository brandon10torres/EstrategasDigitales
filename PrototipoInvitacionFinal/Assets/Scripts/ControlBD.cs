using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBD : MonoBehaviour 
{
	private string URL = "http://localhost/invitaciones/index.php";
	//private string URL = "https://estrategasdigitales.com/InvitacionED/index.php";
	public GameObject respuestaGO;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public IEnumerator ConectarBD(string nombreInvitado, string apellidoInvitado, string correoInvitado)
	{
		WWWForm form = new WWWForm ();

		form.AddField ("nombre", nombreInvitado);
		form.AddField ("apellido", apellidoInvitado);
		form.AddField ("correo", correoInvitado);

		WWW llamadaBD = new WWW (URL, form);
		yield return llamadaBD;

		if(!string.IsNullOrEmpty(llamadaBD.error))
		{
			Debug.Log ("ERROR" + llamadaBD.error);
		}
		respuestaGO.SendMessage ("respuestaBD", llamadaBD.text);
	}
}
