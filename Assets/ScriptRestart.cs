using UnityEngine;
using System.Collections;

public class ScriptRestart : MonoBehaviour {

	void OnMouseDown()
	{
		Debug.Log ("asdf");
		Application.LoadLevel (Application.loadedLevelName);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
