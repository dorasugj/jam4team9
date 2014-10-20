using UnityEngine;
using System.Collections;

public class PlayerTime : MonoBehaviour {

	private float Timer;
	private float ran;
	
	private bool hayaosi;
	// Use this for initialization
	void Start () {
		Timer = 0;
		ran = 0;
	
	}
	
	// Update is called once per frame
	void Update () {

		Timer += Time.deltaTime;
		ran = Random.Range (7, 10);

		if (Timer > ran)
		{
			hayaosi=true;
		}

	
	}
}
