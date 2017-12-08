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
			//Application.OpenURL("https://waze.com/ul?ll=19.4341805,-99.1466865,17z");
			Application.OpenURL("https://www.google.com.mx/maps/place/Museo+Memoria+y+Tolerancia/@19.4341805,-99.1468094,17z/data=!3m1!4b1!4m5!3m4!1s0x85d1fed5593d1a21:0x75489a9d103120f1!8m2!3d19.4341805!4d-99.1446207");
            //Application.OpenURL("https://www.waze.com/location?ll=19.3632738,-99.216202");    
            //System.Diagnostics.Process.Start((Application.dataPath) + "C:/Users/estrategas/AppData/Roaming/uTorrent");
            
        }
    }
    
    

}
