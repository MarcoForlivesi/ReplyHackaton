using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using DG.Tweening;

public class FakeLoading : MonoBehaviour {
    public float duration;
    public float endSize;

    public string levelName;

    private void Start()
    {
        transform.DOScaleX(endSize, duration).OnComplete(LoadScene);
    }

    void LoadScene()
    {
        SceneManager.LoadScene(levelName, LoadSceneMode.Single);
    }
}
