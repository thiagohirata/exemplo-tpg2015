using UnityEngine;
using System.Collections;

public class GameMenuHandler : MonoBehaviour {

	public void OnStartGame() {
		Application.LoadLevel ("StageSelect");
	}

	public void OnOptions() {
		Application.LoadLevel ("StageSelect");
	}

}
