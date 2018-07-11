using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backscript : MonoBehaviour {
	public float timeleft;
	public float timeleft2;
	public float timeleft3;
	public float timeleft4;
	public GameObject mountain;
	public GameObject player;
	public GameObject bill;
	public GameObject house;
	public GameObject house2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timeleft += Time.deltaTime;
		timeleft2 += Time.deltaTime;
		timeleft3 += Time.deltaTime;
		timeleft4 += Time.deltaTime;
		float time = Random.Range (2.0f, 5.0f);

		float time3 = Random.Range (1.0f, 2.0f);
		if (timeleft >= time3) {
			Instantiate (mountain, new Vector3 (player.transform.position.x+18, -1, 0), Quaternion.identity);
			timeleft = 0;
		}
		/*if (timeleft2 >= time3) {
			Instantiate (house, new Vector3 (player.transform.position.x+18, -2.3f, 0), Quaternion.identity);
			timeleft2 = 0;
		}*/
		if (timeleft4 >= time3) {
			Instantiate (bill, new Vector3 (player.transform.position.x+18, -1.6f, 0), Quaternion.identity);
			timeleft4 = 0;
		}
	}
}
