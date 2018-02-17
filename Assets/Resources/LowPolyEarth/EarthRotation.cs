using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthRotation : MonoBehaviour {
    public float speed = 100;
    public Rigidbody rigidbody;
    public float threshold = 0.1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown(0))
        {
            float move = Input.GetAxis("Mouse X");

            Debug.Log("Move " + move);
            if (Mathf.Abs(move) < threshold)
            {
                rigidbody.angularVelocity = Vector3.zero;
            }
            else
            {
                Debug.Log("rotate ");
                rigidbody.AddTorque(transform.up * move * speed);
            }
        }
	}
}
