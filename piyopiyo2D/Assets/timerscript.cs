using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timerscript : MonoBehaviour {
	float duration;
	public Text text;
	// Use this for initialization
	void Start () {
		duration = 0;
	}
	
	// Update is called once per frame
	void Update () {
		duration += Time.deltaTime;
	
	}
}
