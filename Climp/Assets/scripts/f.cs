using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class f : MonoBehaviour {
    public Rigidbody l, r;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "cont")
        {
            Destroy(this);

        }
    }
}
