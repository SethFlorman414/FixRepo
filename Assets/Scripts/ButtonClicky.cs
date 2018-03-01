using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonClicky : MonoBehaviour {

	// Use this for initialization
	public string levelToLoad;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ButtonClick () {
		SceneManager.LoadScene (levelToLoad);
	}
}
