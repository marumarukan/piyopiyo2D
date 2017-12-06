using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscript : MonoBehaviour {
	public bool jump;
	public float power = 2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			jump = true;
		}
		if (Input.GetKeyDown ("right")) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (3, 0);
		}
	}
	void FixedUpdate(){
		if (jump) {
			jump = false;
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 1) * power;
		}
	}
}
