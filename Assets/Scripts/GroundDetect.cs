using UnityEngine;
using System.Collections;

public class GroundDetect : MonoBehaviour {
	void OnCollisionEnter2D(Collision2D coll) {
		SendMessageUpwards ("OnGroundedChange", true, SendMessageOptions.DontRequireReceiver);
	}
	void OnCollisionExit2D(Collision2D coll) {
		SendMessageUpwards ("OnGroundedChange", false, SendMessageOptions.DontRequireReceiver);
	}
}
