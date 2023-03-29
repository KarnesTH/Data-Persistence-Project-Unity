using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public TextMeshProUGUI PlayerName;
    public TextMeshProUGUI PlayerHighscore;

    [System.Serializable]
    class SaveData
    {
        public TextMeshProUGUI PlayerName;
        public TextMeshProUGUI PlayerHighscore;
    }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
