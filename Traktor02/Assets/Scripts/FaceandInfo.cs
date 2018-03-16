using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceandInfo : MonoBehaviour {

    public GameObject TrackedObject;
    public GameObject PositionX;
    public GameObject PositionY;
    public GameObject PositionZ;
    public GameObject RotationX;
    public GameObject RotationY;
    public GameObject RotationZ;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        PositionX.GetComponent<TextMesh>().text = (System.Math.Round((decimal)TrackedObject.transform.localPosition.x * 100) / 100).ToString();
        PositionY.GetComponent<TextMesh>().text = (System.Math.Round((decimal)TrackedObject.transform.localPosition.y * 100) / 100).ToString();
        PositionZ.GetComponent<TextMesh>().text = (System.Math.Round((decimal)TrackedObject.transform.localPosition.z * 100) / 100).ToString();

        RotationX.GetComponent<TextMesh>().text = (TrackedObject.transform.localRotation.x * 100).ToString();
        //RotationY.GetComponent<TextMesh>().text = (System.Math.Round((decimal)TrackedObject.transform.localRotation.y * 100) / 100).ToString();
        //RotationZ.GetComponent<TextMesh>().text = (System.Math.Round((decimal)TrackedObject.transform.localRotation.z * 100) / 100).ToString();


    }
}
