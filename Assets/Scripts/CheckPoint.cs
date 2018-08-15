using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour {
	public bool isIn;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void onCollisonEnter2D(Collider2D other){
		if (other.gameObject.tag == "Player") {
			isIn = true;
			Debug.Log ("in");
		}
	}
}
