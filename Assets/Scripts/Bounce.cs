using UnityEngine;

public class Bounce : MonoBehaviour {

	float lerpTime;
	float currentLerpTime;
	float completePercentage = 1;

	Vector3 startPos;
	Vector3 endPos;

	bool firstInput;
	public bool justJump;

	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
			if (completePercentage == 1)
			{
				lerpTime = 1;
				currentLerpTime = 0;
				firstInput = true;
				justJump = true;
			}

		startPos = gameObject.transform.position;

		if (Input.GetKeyDown(KeyCode.UpArrow) && gameObject.transform.position == endPos)
			endPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z + 1);
			
		if (Input.GetKeyDown(KeyCode.DownArrow) && gameObject.transform.position == endPos)
			endPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z - 1);
			
		if (Input.GetKeyDown(KeyCode.RightArrow) && gameObject.transform.position == endPos)
			endPos = new Vector3(gameObject.transform.position.x + 1, gameObject.transform.position.y, gameObject.transform.position.z);
			
		if (Input.GetKeyDown(KeyCode.LeftArrow) && gameObject.transform.position == endPos)
			endPos = new Vector3(gameObject.transform.position.x - 1, gameObject.transform.position.y, gameObject.transform.position.z);

		if (firstInput)
		{
			currentLerpTime += Time.deltaTime * 5.5F;
			completePercentage =  currentLerpTime / lerpTime;
			gameObject.transform.position = Vector3.Lerp(startPos, endPos, completePercentage);
		}

		if (completePercentage > 0.85)
			completePercentage = 1;
		if (Mathf.Round(completePercentage) == 1)
			justJump = false;
	}
}
