using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
	public float speed = 5f;
	public float jumpSpeed = 5f;
	private float movement = 0f;
	private Rigidbody2D rigidBody;

	public Transform groundCheckPoint;
	public float groundCheckRadius;
	public LayerMask groundLayer;
	private bool isTouchingGround;

	public int numLeft = 3;
	public Transform Player;
	public Transform launchpad;

	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody2D> ();
	}

	void Update() {
		isTouchingGround = Physics2D.OverlapCircle (groundCheckPoint.position, groundCheckRadius, groundLayer);
		movement = Input.GetAxis ("Horizontal");
		if (movement != 0f) {
			rigidBody.velocity = new Vector2 (movement * speed, rigidBody.velocity.y);
		}
		if(Input.GetButtonDown ("Jump") && isTouchingGround){
			rigidBody.velocity = new Vector2 (rigidBody.velocity.x, jumpSpeed);
		}

		Vector3 position = new Vector3 (Player.position.x - 1f, Player.position.y + 0.1f);
		Quaternion rotation = Quaternion.Euler(0, 0, 0);
		if (Input.GetKeyDown (KeyCode.Q) && isTouchingGround && numLeft > 0) {
			Instantiate(launchpad, position, rotation);
			numLeft--;
		}
	}
}
