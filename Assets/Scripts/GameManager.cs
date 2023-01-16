using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour {
    public TMP_Text fpsText;
    public float deltaTime;
	public static GameManager instance;

	public GameObject gameOverUI;

	void Awake ()
	{
		instance = this;
		Application.targetFrameRate = 30;
	}

	void Update() {
		deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
        float fps = 1.0f / deltaTime;
        fpsText.text = "FPS: " + Mathf.Ceil (fps).ToString();
	}

	public void EndGame ()
	{
		gameOverUI.SetActive(true);
	}

	public void Restart ()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

}
