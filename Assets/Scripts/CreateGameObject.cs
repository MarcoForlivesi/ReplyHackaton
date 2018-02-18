using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateGameObject : MonoBehaviour {
    public GameObject prefab;
    public Transform startingPosition;
    public float force = 10.0f;

	public void OnPress()
    {
        GameObject prefabOb = Instantiate(prefab, startingPosition, false);
        Rigidbody rigidbody = prefabOb.GetComponent<Rigidbody>();

        Vector3 forward = Camera.main.transform.TransformDirection(Vector3.forward);
        rigidbody.AddForce(forward * force);

    }
}
