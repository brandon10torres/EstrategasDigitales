using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControl : MonoBehaviour {

    public MeshRenderer mallaCubo;
    public Color colorClick;

    private Color colorCubo;
    private bool clickCubo = false;

    public Animator animCubo;


	// Use this for initialization
	void Start ()
    {
        colorCubo = mallaCubo.material.color;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    public void ClickColorCubo()
    {
        clickCubo = !clickCubo;
        if(clickCubo)
        {
            mallaCubo.material.color = colorClick;
            animCubo.SetTrigger("Acercado");
            animCubo.SetTrigger("Info");
        }
        else
        {
            colorCubo = mallaCubo.material.color;
        }
    }
}
