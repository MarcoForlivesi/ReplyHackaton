using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using DG.Tweening;

public class Plant : MonoBehaviour {
    public float endValue = 3;
    public float duration = 4;

	// Use this for initialization
	void Start () {
		
	}
	
	public void Grow()
    {
        transform.DOScaleZ(endValue, duration);
    }
}
