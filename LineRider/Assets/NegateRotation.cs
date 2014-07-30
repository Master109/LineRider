using UnityEngine;
using System.Collections;

public class NegateRotation : MonoBehaviour
{
	Quaternion initRota;

	// Use this for initialization
	void Start ()
	{
		initRota = transform.rotation;
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.rotation = initRota;
	}
}
