using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallsprict : MonoBehaviour {


	public GameObject wallPrefab;



//	float nextSpwnTime=0;
//	float interval = 2;
//	public float speed = 2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		/*if (nextSpwnTime < Time.timeSinceLevelLoad) {
			nextSpwnTime = Time.timeSinceLevelLoad + interval;
			LocalInstantate ();
		}*/

	}
	void FixedUpdate(){
		
	}
//	void LocalInstantate(){
//		GameObject obj = (GameObject)GameObject.Instantiate (wallObject);
//		obj.transform.parent = transform;
//
//		float y = Random.Range (3f, 10f);
//		obj.transform.localPosition = new Vector2 (0, y);
//
//	}
	void OnTriggerEnter2D(Collider2D collison2D){
		if (collison2D.gameObject.tag == "Player") {
			Instantiate (wallPrefab, this.gameObject.transform.position += new Vector3 (7, 0, 0), Quaternion.identity);
			Destroy (this.gameObject);
		}
	}
}
