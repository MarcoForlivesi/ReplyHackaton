using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour {
    public GameObject water;
    public float zOffset;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit info;
        Ray ray = Camera.main.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
        bool hit = Physics.Raycast(ray, out info, 2000);
        Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.position - ray.direction * 1000);
        Debug.Log("Water direction" + ray.direction);

        if (hit && info.collider.gameObject)
        {
            water.transform.position = info.point + Vector3.up * zOffset;
        }
    }

    public void OnTouch()
    {
        RaycastHit info;
        Ray ray = Camera.main.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
        bool hit = Physics.Raycast(ray, out info, 2000);


        if (hit)
        {
            GameObject hitObject = info.collider.gameObject;
            Debug.Log(hitObject.name + " ");
            if (hitObject.tag == "Plant")
            {
                Plant plant = hitObject.GetComponent<Plant>();
                plant.Grow();
            }
        }
    }
}
