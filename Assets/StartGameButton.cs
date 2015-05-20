using UnityEngine;
using System.Collections;

public class StartGameButton : MonoBehaviour {

	public void OnStartButtonClick() {
		Application.LoadLevel ("Main");
	}
}
