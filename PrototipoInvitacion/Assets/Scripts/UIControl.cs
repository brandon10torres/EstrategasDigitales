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
            animCubo.SetTrigger("Acercado");
            animCubo.SetTrigger("Info");
            print("sirve?");
        }
        else
        {
            animCubo.SetTrigger("Inicio");
        }
    }
    public void ClickInicio()
    {
        animCubo.SetTrigger("Inicio");
        print("sirve?");
    }
}
