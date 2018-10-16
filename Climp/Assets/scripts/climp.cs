using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class climp : MonoBehaviour
{
    public SteamVR_TrackedObject controller;
    [HideInInspector]
    public Vector3 prevpos;
    [HideInInspector]
    public bool cangrip;
    // Use this for initialization
    void Start()
    {
      
        prevpos = controller.transform.localPosition;
    }

   
    private void OnTriggerEnter(Collider other)
    {
        cangrip = true;
    }
    private void OnTriggerExit(Collider other)
    {
        cangrip = false;
    }
}
