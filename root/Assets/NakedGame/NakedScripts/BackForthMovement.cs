using UnityEngine;
using System.Collections;

public class BackForthMovement : MonoBehaviour {
	public float speed = 1;
	void Update() {

		transform.position = new Vector3(PingPong(Time.time*speed, -20, 17), transform.position.y, transform.position.z);
	}

	float PingPong(float t, float minLength, float maxLength) {
		return Mathf.PingPong(t, maxLength-minLength) + minLength;
	}
}