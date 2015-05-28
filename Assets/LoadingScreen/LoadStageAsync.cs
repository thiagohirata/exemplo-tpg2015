using UnityEngine;
using System.Collections;

public class LoadStageAsync : MonoBehaviour {
	public string levelName;

	IEnumerator Start() {
		AsyncOperation async = Application.LoadLevelAsync (levelName);
		yield return async;


	}
}
