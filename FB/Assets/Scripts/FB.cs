using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting;


public class FB : MonoBehaviour
{
    private void OnMouseDown()
    {
        AbrirFB();
        Debug.Log("Prueba");
    }
    void AbrirFB()
    {
        float startTime;
        startTime = Time.timeSinceLevelLoad;
        Application.OpenURL("GoogleMapsAPP");
        if(Time.timeSinceLevelLoad - startTime <= 1f)
        {
            Application.OpenURL("https://waze.com/ul?ll=19.3632738,-99.216202");
            //Application.OpenURL("https://www.waze.com/location?ll=19.3632738,-99.216202");    
            //System.Diagnostics.Process.Start((Application.dataPath) + "C:/Users/estrategas/AppData/Roaming/uTorrent");
            
        }
    }
    
    

}
