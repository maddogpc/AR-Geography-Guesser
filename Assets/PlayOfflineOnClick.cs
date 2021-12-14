using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayOfflineOnClick : MonoBehaviour
{
	public Button yourButton;

	void Start()
	{
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	public void TaskOnClick()
	{
		GameObject panel = transform.parent.gameObject;
		
		SceneManager.LoadScene("GlobeDemo", LoadSceneMode.Additive);
		Destroy(panel);
	}
}