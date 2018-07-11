using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mountainscript : MonoBehaviour {
	
	public GameObject mountain;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (-10, 0);
		}
	}

