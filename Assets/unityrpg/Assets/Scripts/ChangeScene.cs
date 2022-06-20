using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ChangeScene : MonoBehaviour {

	public void loadNextScene(string Town) {
		SceneManager.LoadScene (Town);
	}
}
