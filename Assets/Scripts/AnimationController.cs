using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour {

	Animator playerAnimator;
	public GameObject player;

	void Start ()
	{
		playerAnimator = gameObject.GetComponent<Animator>();
	}
	
	void Update ()
	{
		Bounce bounceScript = player.GetComponent<Bounce>();
		if (bounceScript.justJump)
			playerAnimator.SetBool("Jump", true);
		else	
			playerAnimator.SetBool("Jump", false);

		

		if (Input.GetKeyDown(KeyCode.UpArrow))
			gameObject.transform.rotation = Quaternion.Euler(0, -90, 0);
			
		if (Input.GetKeyDown(KeyCode.DownArrow))
			gameObject.transform.rotation = Quaternion.Euler(0, 90, 0);
			
		if (Input.GetKeyDown(KeyCode.RightArrow))
			gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
			
		if (Input.GetKeyDown(KeyCode.LeftArrow))
			gameObject.transform.rotation = Quaternion.Euler(0, 180, 0);

	}
}
