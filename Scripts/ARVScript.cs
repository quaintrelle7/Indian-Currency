using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ARVScript : MonoBehaviour,IVirtualButtonEventHandler
{
    // Start is called before the first frame update
    public GameObject RBI, MKG, Satya, Statue;

    void Start()
    {
       VirtualButtonBehaviour[] vrb = GetComponentsInChildren<VirtualButtonBehaviour>();
        for(int i=0; i<vrb.Length;i++)
        {
            vrb[i].RegisterEventHandler(this);
            //vrb[i].RegisterOnButtonReleased(OnButtonReleased);
        }

        RBI.SetActive(false);
        MKG.SetActive(false);
        Satya.SetActive(false);
      
    }

    // Update is called once per frame
    

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if(vb.VirtualButtonName == "RBI")
        {
        UnityEngine.Debug.Log("RBI Pressed");
        RBI.SetActive(true);
        MKG.SetActive(false);
        Satya.SetActive(false);
        }
        else if(vb.VirtualButtonName == "MKG")
        {
         RBI.SetActive(false);
        MKG.SetActive(true);
        Satya.SetActive(false);
        
        }
         else if(vb.VirtualButtonName == "Satya")
        {
         RBI.SetActive(false);
        MKG.SetActive(false);
        Satya.SetActive(true);
        }
        else
        {
            throw new UnityException(vb.VirtualButtonName + "Virtual Button not supported");

        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
         UnityEngine.Debug.Log(vb.VirtualButtonName + " released");
    }
}
