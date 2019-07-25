using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickWall : MonoBehaviour
{
	public Vector3 topPos;
	public Vector3 bottomPos;

	public bool up;


	// Start is called before the first frame update
	void FixedUpdate()
	{
		if (up == false)
		{
			transform.position = Vector3.Lerp(transform.position, bottomPos, 7 * Time.deltaTime);
		}
		if (up == true)
		{
			transform.position = Vector3.Lerp(transform.position, topPos, 7 * Time.deltaTime);
		}
		if (transform.position == topPos)
		{
			up = false;
		}
		if (transform.position == bottomPos)
		{
			up = true;
		}
	}
}