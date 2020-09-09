using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButton : MonoBehaviour, IVirtualButtonEventHandler
{
    // Start is called before the first frame update
    public GameObject MKG, plane;
    VirtualButtonBehaviour vrb;

    void Start()
    {
        vrb = GetComponentInChildren<VirtualButtonBehaviour>();
        vrb.RegisterEventHandler(this);
        MKG.SetActive(false);
        plane.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        MKG.SetActive(true);
        plane.SetActive(true);

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        MKG.SetActive(false);
        plane.SetActive(false);

    }
}
