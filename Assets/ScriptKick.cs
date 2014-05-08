using UnityEngine;
using System.Collections;

public class ScriptKick : MonoBehaviour {

	void OnMouseDown()
	{
		rigidbody.AddForce (transform.forward * 5, ForceMode.Impulse);
		Debug.Log ("kick");
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
