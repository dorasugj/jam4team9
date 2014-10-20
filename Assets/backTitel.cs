using UnityEngine;
using System.Collections;

public class backTitel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//  mouse click load Titel;
	void OnMouseDown()
	{
		Application.LoadLevel("Title");
	}
}
