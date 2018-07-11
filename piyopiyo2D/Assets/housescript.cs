using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class housescript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (-4.5f, 0);
	}
}
