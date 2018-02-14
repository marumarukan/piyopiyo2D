using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscript : MonoBehaviour {
	public bool jump;
	public float power = 2f;
	public float speed = 1f;
	public float width = 2f;
	public float height = 2f;
	//float watch=0f;

	float x,y,now;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//watch = Time.time;
		//float x = Mathf.Cos(Time.time * speed) * width;
		//float y = Mathf.Sin(Time.time * speed) * height;
		//transform.position = new Vector2 (x, y);



		if (Input.GetKey ("space")) {

			now += Time.deltaTime;

			x = Mathf.Cos (now * speed) * width;
			y = Mathf.Sin (now * speed) * height;
			transform.position = new Vector2 (x, y);

			//jump = true;
		}
		if (Input.GetKeyUp ("space")) {

			now = 0;
		}
	}
	void FixedUpdate(){
		if (jump) {
			jump = false;
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 1) * power;
		}
	}
}
