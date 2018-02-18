using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
	public string levelName;

	public void Load ()
	{
		if (!string.IsNullOrEmpty(levelName))
		{
			SceneManager.LoadScene(levelName, LoadSceneMode.Single);
            SceneManager.sceneLoaded += OnSceneLoaded;
		}
	}

    virtual public void OnSceneLoaded(Scene scene, LoadSceneMode mode) { }
}