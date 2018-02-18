using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObjectOnMesh : MonoBehaviour {
    public GameObject prefab;
    private GameObject prefabObj;

	public void OnTouch()
    {
        if (prefabObj == null)
        {
            prefabObj = Instantiate(prefab);
        }
        else
        {
            prefabObj = null;
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (prefabObj)
        {
            RaycastHit info;
            Ray ray = Camera.main.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
            bool hit = Physics.Raycast(ray, out info, 2000);

            if (hit && info.collider.gameObject != prefabObj)
            {
                prefabObj.transform.position = info.point;
            }
        }
	}
}
