using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
	private float speed = 5;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float axisX = Input.GetAxis ("Horizontal");

		transform.Translate (new Vector2(axisX, 0) * Time.deltaTime * speed);
	}
}
