using UnityEngine;
using System.Collections;

public class EnemyGhostController : MonoBehaviour {
	public float ghostDuration = 1;
	private float ghostTime = -1;
	private Renderer renderer;
	void Awake() {
		this.renderer = GetComponent<Renderer> ();
	}

	void ReceivedDamage() {
		ghostTime = 0;
		gameObject.layer = LayerMask.NameToLayer ("EnemyGhost");
	}

	void FixedUpdate() {
		if (ghostTime >= 0) {
			ghostTime += Time.deltaTime;

			if(renderer != null) 
				renderer.enabled = Time.frameCount % 3 == 0;

			if(ghostTime > ghostDuration) {
				ghostTime = -1;
				gameObject.layer = LayerMask.NameToLayer ("Enemy");
				if(renderer != null) 
					renderer.enabled = true;
			}
		}
	}
}
