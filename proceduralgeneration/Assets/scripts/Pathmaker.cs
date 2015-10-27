using UnityEngine;
using System.Collections;

public class Pathmaker : MonoBehaviour {

	private int counter = 0;
	public Transform floorPrefab;
	public Transform wallPrefab;
	public Transform pathmakerPrefab;

	float x;
	float y;
	float z;
	Vector3 pos;

	void Start()
	{
		x = Random.Range(-10, 10);
		y = 1;
		z = Random.Range(-10, 10);
		pos = new Vector3(x, y, z);
		transform.position = pos;
	}

	// Update is called once per frame
	void Update ()
	{

		// if counter is less than 50, then
		if (counter < 50)
		{
			// Generate a random number from 0.0f to 1.0f
			float randomNumber;
			randomNumber = Random.Range (0.0f, 1.0f);

			// If random number is less than 0.25f, then rotate 90 degrees;
			if (randomNumber < 0.25f)
			{
				transform.Rotate(0f, 90f, 0f);
			}

			// Else if number is 0.25f-0.5f, then rotate -90 degrees;
			else if (randomNumber > 0.25f && randomNumber < 0.5f)
			{
				transform.Rotate(0f, -90f, 0f);
			}
			else if (randomNumber > 0.70f && randomNumber < 0.80f)
			{
				Instantiate (wallPrefab, transform.position, transform.rotation);
			}
			else if (randomNumber > 0.50f && randomNumber < 0.60f)
			{
				Instantiate (wallPrefab, transform.position, transform.rotation);
			}
			// Else if number is 0.95f-1.0f, then instantiate a pathmakerPrefab clone at current position;
			else if (randomNumber > 0.99f && randomNumber < 1.0f)
			{
				Instantiate (pathmakerPrefab, transform.position, transform.rotation);
			} 

			//Instantiate a floorPrefab clone at current position;
			Instantiate (floorPrefab, transform.position, transform.rotation);

			// move forward in local space by 5 units
			transform.Translate(0f, 0f, 5f);

			// Increment counter
			counter++;
		}

		else
		{
			// destroy self
			Destroy (this.gameObject);
		}
	}
}
