using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GripManger : MonoBehaviour {
    public Rigidbody player;
    public climp left, right;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void FixeedUpdate()
    {
        var ldevice = SteamVR_Controller.Input((int)left.controller.index);
        var rdevice = SteamVR_Controller.Input((int)left.controller.index);
        bool isgrip = left.cangrip || right.cangrip;
        if (isgrip)
        {
            if (left.cangrip && ldevice.GetTouch(SteamVR_Controller.ButtonMask.Trigger))
            {
                player.useGravity = false;
                player.isKinematic = true;
                player.transform.position += (left.prevpos - left.controller.transform.localPosition);
            }
            else if (left.cangrip && ldevice.GetTouchUp(SteamVR_Controller.ButtonMask.Trigger))
            {
                player.useGravity = true;
                player.isKinematic = false;
                player.velocity = 2f * (left.prevpos - left.controller.transform.localPosition) / Time.deltaTime;
            }
            //////////////////// RIght
            if (right.cangrip && rdevice.GetTouch(SteamVR_Controller.ButtonMask.Trigger))
            {
                player.useGravity = false;
                player.isKinematic = true;
                player.transform.position += (right.prevpos - right.controller.transform.localPosition);
            }
            else if (right.cangrip && rdevice.GetTouchUp(SteamVR_Controller.ButtonMask.Trigger))
            {
                player.useGravity = true;
                player.isKinematic = false;
                player.velocity = 2f * (right.prevpos - right.controller.transform.localPosition) / Time.deltaTime;
            }
        }
        else
        {
            player.useGravity = true;
            player.isKinematic = false;
        }
        left.prevpos = left.controller.transform.localPosition;
        right.prevpos = right.controller.transform.localPosition;
        if (ldevice.GetTouch(SteamVR_Controller.ButtonMask.Grip) || rdevice.GetTouch(SteamVR_Controller.ButtonMask.Grip))
        {
            player.transform.position = new Vector3(30.68f, 1.05f, 50.73f);
        }
    }
       
    }

