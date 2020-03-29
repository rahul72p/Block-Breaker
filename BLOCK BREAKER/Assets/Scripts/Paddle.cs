using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	public float paddleSpeed = 3f;


	private Vector3 playerPos = new Vector3 (0, 0, 1f);

	void Update () 
	{
		float xPos = transform.position.x + (Input.GetAxis("Horizontal") * paddleSpeed);
		playerPos = new Vector3 (Mathf.Clamp (xPos, -7f, 7f), 0f, 1f);
		transform.position = playerPos;

	}
}