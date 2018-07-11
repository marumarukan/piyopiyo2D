using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linescript : MonoBehaviour {
	public GameObject Player;
	// Use this for initialization
	void Start () {
		//LineRenderer renderer = gameObject.GetComponent < LineRenderer> ();
		//renderer.SetVertexCount(2);
		//renderer.SetPosition(0, Player.transform.position);
		//renderer.SetPosition(1, this.gameObject.transform.position);
	}
	
	// Update is called once per frame
	void Update () {
		
		LineRenderer renderer = gameObject.GetComponent < LineRenderer> ();
		renderer.SetVertexCount(2);
		renderer.SetPosition(0, Player.transform.position);
		renderer.SetPosition(1, this.gameObject.transform.position);
	}
}
