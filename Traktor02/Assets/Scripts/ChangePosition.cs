using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePosition : MonoBehaviour {

    public float xOffset;
    public float yOffset;
    public float zOffset;

    private Vector3 myLocalPosition;
    private Vector3 myLocalRotation;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    Vector3 InitLocalPosition (float a, float b, float c)
    {
        myLocalPosition.x = transform.localPosition.x + a;
        myLocalPosition.y = transform.localPosition.y + b;
        myLocalPosition.z = transform.localPosition.z + c;
        return myLocalPosition;
    }

    public void GoUp()
    {
        transform.localPosition = InitLocalPosition(0, 0, 0.01f);
    }

    public void GoDown()
    {
        transform.localPosition = InitLocalPosition(0, 0, -0.01f);
    }

    public void GoRight()
    {
        transform.localPosition = InitLocalPosition(0.01f, 0, 0);
    }

    public void GoLeft()
    {
        transform.localPosition = InitLocalPosition(-0.01f, 0, 0);
    }

    public void GoFront()
    {
        transform.localPosition = InitLocalPosition(0, -0.01f, 0);
    }

    public void GoBack()
    {
        transform.localPosition = InitLocalPosition(0, 0.01f, 0);
    }

    public void RotateLeft()
    {
        myLocalRotation.x = transform.localEulerAngles.x - 0.1f;
        myLocalRotation.y = transform.localEulerAngles.y;
        myLocalRotation.z = transform.localEulerAngles.z;

        transform.localEulerAngles = myLocalRotation;
    }

    public void RotateRight()
    {
        myLocalRotation.x = transform.localEulerAngles.x + 0.1f;
        myLocalRotation.y = transform.localEulerAngles.y;
        myLocalRotation.z = transform.localEulerAngles.z;

        transform.localEulerAngles = myLocalRotation;
    }
}
