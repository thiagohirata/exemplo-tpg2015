﻿using UnityEngine;
using System.Collections;

public class KoopaTroopaMovement : MonoBehaviour {
	private bool grounded;
	private Animator animator;

	public bool flying;
	public bool walking;
	public float horizontalSpeed = 1;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (flying) {
			this.rigidbody2D.velocity = new Vector2(0, 1  * Mathf.Cos (Time.time));
		}
		if (walking) {
			this.rigidbody2D.velocity = new Vector2(this.transform.localScale.x * -1f * horizontalSpeed, this.rigidbody2D.velocity.y);
		}
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.layer == LayerMask.NameToLayer ("Platform")) {
			grounded = true;
			animator.SetBool("Grounded", true);
		}

		if (coll.gameObject.layer == LayerMask.NameToLayer ("Wall")) {
			//inverte sentido
			this.transform.localScale = new Vector2(-1 * this.transform.localScale.x, this.transform.localScale.y);
		}

		//COLIDIU COM PLAYER - LEVOU DANO
		if (coll.gameObject.layer == LayerMask.NameToLayer ("Player")) {
		}
	}

	void OnWeakSpotHit(GameObject other) {

		//Toca o AudioClip do componente AudioSource conectado ao Koopa
		GetComponent<AudioSource>().Play ();

		this.transform.localScale = new Vector2(-1 * this.transform.localScale.x, this.transform.localScale.y);
		animator.SetTrigger("ReceivedDamage");
		this.gameObject.SendMessage("ReceivedDamage"); //Warns EnemyGhostController
		if (other.rigidbody2D != null) {
			other.rigidbody2D.velocity = (new Vector2 (other.rigidbody2D.velocity.x, 5)); //empurra para cima
		}

	}

	void OnCollisionExit2D(Collision2D coll) {
		if (coll.gameObject.layer == LayerMask.NameToLayer ("Platform")) {
			grounded = false;
			animator.SetBool("Grounded", false);
		}
	}
}
