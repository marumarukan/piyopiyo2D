using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerscript : MonoBehaviour {
	public bool jump;
	public float power = 2f;
	public float speed = 3.5f;
	public float width = 4f;
	public float height = 4f;
	public int score=0;


	public void OnTriggerEnter2D(Collider2D Collision2D){
		if (Collision2D.gameObject.tag == "wall") {
			score++;
		}
		if (Collision2D.gameObject.tag == "Wall") {
			Debug.Log ("a");

			SceneManager.LoadScene ("gameover");
		}
	}

	//float watch=0f;

	float x,y,now;

	// Use this for initialization
	void Start () {
		score = 0;

	}
	
	// Update is called once per frame
	void Update () {
		//Ray ray = new Ray (this.transform.position, new Vector2 (5, 5));




		if (Input.GetMouseButton(0)) {

			now += Time.deltaTime;

			x = Mathf.Cos (now * speed) * width;
			y = Mathf.Sin (now * speed) * height;
			//transform.position = new Vector2 (x, y);
			GetComponent<Rigidbody2D>().velocity=new Vector2(x,y);
			//jump = true;

		}

		if (Input.GetMouseButtonUp(0)) {

			now = 2.7f;
		}
	}
	void FixedUpdate(){
		if (jump) {
			jump = false;
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 1) * power;
		}
	}
	void ray(){
		
	}
}
