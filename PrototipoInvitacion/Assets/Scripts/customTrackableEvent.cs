using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.SceneManagement;

public class customTrackableEvent : MonoBehaviour,
                                                ITrackableEventHandler
{


    public TrackableBehaviour mTrackableBehaviour;
    public MeshRenderer mallaCubo;
    public Color colorCubo;



    // Use this for initialization
    void Start ()
    {        
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnTrackableStateChanged(
                                        TrackableBehaviour.Status previousStatus,
                                        TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            OnTrackingFound();
        }
        else
        {
            OnTrackingLost();
        }
    }
    private void OnTrackingFound()
    {
        mallaCubo.material.color = colorCubo;
        print("Encontrado");
    }
    private void OnTrackingLost()
    {
        print("Perdido");
    }
    void OnMouseDown()
    {
        
        SceneManager.LoadScene("Invitacion");               
    }
}
