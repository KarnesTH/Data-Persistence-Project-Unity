using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIManager : MonoBehaviour
{
    public TextMeshProUGUI highscoreText;
    public TextMeshProUGUI playerNameText;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.LoadName();
    }

    // Update is called once per frame
    void Update()
    {
        highscoreText.text = $"Best Score: {GameManager.Instance.PlayerName}: {GameManager.Instance.PlayerHighscore}";
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
