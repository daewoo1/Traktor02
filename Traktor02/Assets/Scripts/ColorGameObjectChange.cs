using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorGameObjectChange : MonoBehaviour {

   GameObject auto;
    public Material[] material;
    Renderer rend;
 
	void Start () {
        
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
		
	}

    public void ColorGreen() {
        rend.sharedMaterial = material[0];
    }

    public void ColorBlue() {
        rend.sharedMaterial = material[1];
    }

    public void ChangeYellow()
    {
        rend.sharedMaterial = material[2];
    }

    public void ChangeRed()
    {
        rend.sharedMaterial = material[3];
    }

    public void ChangeGreen()
    {
        rend.sharedMaterial = material[4];
    }

    public void ChangeBlue()
    {
        rend.sharedMaterial = material[5];
    }

}
