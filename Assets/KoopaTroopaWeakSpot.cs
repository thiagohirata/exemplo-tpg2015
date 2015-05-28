using UnityEngine;
using System.Collections;

public class KoopaTroopaWeakSpot : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) {
		SendMessageUpwards ("OnWeakSpotHit", other.gameObject);
	}
}
