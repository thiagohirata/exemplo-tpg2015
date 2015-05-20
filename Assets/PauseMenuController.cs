using UnityEngine;
using System.Collections;

public class PauseMenuController : MonoBehaviour {

	public GameObject pauseMenuCanvas;

	void Awake() {
		Time.timeScale = 1;
	}

	public void ExitButton() {
		Application.LoadLevel ("StartMenu");
	}

	public void ResumeGameButton() {
		Time.timeScale = 1;
		pauseMenuCanvas.SetActive(false);

	}

	void Update() {
		if (Input.GetButtonDown ("Cancel")) {
			if(Time.timeScale == 0) {
				//DESPAUSAR
				Time.timeScale = 1;
				pauseMenuCanvas.SetActive(false);
			} else {
				//PAUSAR
				Time.timeScale = 0;
				pauseMenuCanvas.SetActive(true);
			}
		}
	}
}
