using UnityEngine;
using System.Collections;

public class LoadStageAsync : MonoBehaviour {
	public string levelName;

	void Start() {
		AsyncOperation async = Application.LoadLevelAsync (levelName);



	}
}
