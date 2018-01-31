using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rope2script : MonoBehaviour {
	public GameObject ropeprefab;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D (Collider2D collider){

		Debug.Log ("a");
		if (collider.gameObject.tag == "wall") {
//			foreach (ContactPoint2D point in collider.contacts) {
//				
//				ropeprefab.transform.position = (Vector3)point.point;
//
//			}
		}
	}
}
