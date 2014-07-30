using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
	public int speed;
	public int jumpForce;

	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update ()
	{

	}

	void OnCollisionStay2D (Collision2D coll)
	{
		bool move = false;
		foreach (ContactPoint2D cp in coll.contacts)
			if (cp.point.y < transform.position.y)
				move = true;
		if (move)
		{
			rigidbody2D.AddForce(Vector2.right * Input.GetAxis("X") * speed);
			if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow))
				rigidbody2D.AddForce(Vector2.up * jumpForce);
		}
	}
}
