using UnityEngine;
using System.Collections;

public class KoopaTroopaControl : MonoBehaviour {
	private Animator animator;

	public bool flying;
	public bool walking;

	// Use this for initialization
	void Start () {
		this.animator = GetComponent<Animator> ();
	}
	
	void OnCollisionEnter2D(Collision2D collision) {
		if (collision.collider.tag == "Player") {
			animator.SetTrigger ("GotDamage");
		}
		if (collision.collider.tag == "Cenario") {
			animator.SetBool ("Grounded", true);
		}
	}

	void FixedUpdate() {
		if (flying) {
			this.rigidbody2D.velocity = new Vector2 (0, Mathf.Cos (Time.time) * 5);
		} else if (walking) {
			this.rigidbody2D.velocity = new Vector2 (-5f * this.transform.localScale.x, this.rigidbody2D.velocity.y);
		} else {
			this.rigidbody2D.velocity = new Vector2 (0, this.rigidbody2D.velocity.y);
		}
	}
}
