using HoloToolkit.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ToggleVuforiaScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StopVuforia()
    {
        ToggleVuforia(true);
    }

    public void StartVuforia()
    {
        ToggleVuforia(false);
    }

    bool VuforiaOn = true;
    public DefaultTrackableEventHandler ImageTracker;

    public void ToggleVuforia(bool Lock)
    {
        if (Lock && VuforiaOn)
        {
            ImageTracker.Found = true;
            VuforiaBehaviour.Instance.enabled = false;
            ImageTracker.enabled = false;
            VuforiaOn = false;
            AttachWorldAnchor();
        }
        else if (!Lock && !VuforiaOn)
        {
            VuforiaBehaviour.Instance.enabled = true;
            ImageTracker.enabled = true;
            VuforiaOn = true;
            ImageTracker.Found = false;
            RemoveWorldAnchor();
        }
    }

    private void AttachWorldAnchor()
    {
        if (WorldAnchorManager.Instance != null)
        {
            WorldAnchorManager.Instance.AttachAnchor(gameObject,"door_anchor");
        }
    }

    private void RemoveWorldAnchor()
    {
        if (WorldAnchorManager.Instance != null)
        {
            WorldAnchorManager.Instance.RemoveAnchor(gameObject);
        }
    }

}
