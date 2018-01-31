using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ropescript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			this.transform.localScale = new Vector3 (1, 9, 1);
		}
	}
}
