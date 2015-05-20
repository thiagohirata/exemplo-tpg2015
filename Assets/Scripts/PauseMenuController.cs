using UnityEngine;
using System.Collections;

public class PauseMenuController : MonoBehaviour {
	private GameObject player;
	public GameObject enemy;
	public GameObject pauseMenu;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Princess");
		pauseMenu = GameObject.Find ("PauseMenu");
		pauseMenu.SetActive (false);
	}

	void Update() {
		if(Input.GetButtonDown("Pause")) {
			if(pauseMenu.activeInHierarchy) {
				//Ja esta pausado
				ResumeGame();
			} else {
				//Nao esta pausad
				pauseMenu.SetActive(true);
				Time.timeScale=0;
			}

		}
	}

	public void ResumeGame() {
		pauseMenu.SetActive(false);
		Time.timeScale=1;

	}

	public void ExitGame() {
		Application.LoadLevel ("MainMenu");
	}

}
