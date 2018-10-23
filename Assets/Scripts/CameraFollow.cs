using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public GameObject player;
	Vector3 targetPos;

	void Update () {
		targetPos = Vector3.Lerp(gameObject.transform.position, player.transform.position, Time.deltaTime);
		gameObject.transform.position = new Vector3(targetPos.x, 1, targetPos.z);
	}
}
