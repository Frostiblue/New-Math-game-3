using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
	float launchForce = 600;
	float charge = 10;
	public Rigidbody ballRB;

	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetMouseButtonUp(0))
		{
			LaunchBall();

		}
		if (Input.GetMouseButton(0))
		{
			charge += 10 * Time.deltaTime;
		}
	}
	public void LaunchBall()
	{

	 ballRB.AddForce(new Vector3(0, launchForce, launchForce));
		

	}
}
