using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorescript : MonoBehaviour {
	public GameObject gameobject;
	public Text scoretext;
	public Text highscoretext;
	public int score2;
	public int highscore;
	// Use this for initialization
	void Start () {
		score2 = 0;

	}
	
	// Update is called once per frame
	void Update () {
		
		int num = gameobject.GetComponent<playerscript> ().score;
		score2 = num;
		scoretext.text = "" + score2;

		if (highscore < score2)
			highscore = score2;

		//ikhighscoretext = "" + highscore;
	}
	public void save(){
		
	}

}
