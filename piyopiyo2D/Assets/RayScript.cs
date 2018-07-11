using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayScript : MonoBehaviour {
	public GameObject ropeposition;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetMouseButtonDown(0)) {
			//NowPosition = ropeposition.transform.localPosition;
		}
		if (Input.GetMouseButton(0)) {
			LineRenderer line = GameObject.Find ("linerenderer").GetComponent<LineRenderer> ();
			line.SetPosition (0, this.gameObject.transform.position);
			line.SetPosition (1, ropeposition.transform.position);
		}

		//Debug.Log(hit);
	}
}
