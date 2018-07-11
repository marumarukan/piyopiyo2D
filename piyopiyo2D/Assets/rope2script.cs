using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rope2script : MonoBehaviour {
	public GameObject ropeposition;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Instantiate (ropeposition, new Vector2(this.gameObject.transform.position.x,this.gameObject.transform.position.y), Quaternion.identity);
		}
		if (Input.GetMouseButtonUp (0)) {
			ropeposition.GetComponent<Ropeposition> ().Destroy ();
		}
	}

}
