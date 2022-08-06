using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Game_Manager : MonoBehaviour
{
    [SerializeField] private GameObject gameOverScene;
    [SerializeField] private int sceneIndex;

    [SerializeField] private TextMeshProUGUI currentScore;
    [SerializeField] private TextMeshProUGUI bestScore;

    private int score_temp;
    private int best_score_temp;

    [SerializeField] private ScoreManager scoreManager;
    void Start()
    {
        score_temp = 0;
        PlayerPrefs.SetString("EndGame", "FALSE");
    }
    public void onRestartClick()
    {
        SceneManager.LoadScene(sceneIndex);
    }
    private void Update()
    {
        if (PlayerPrefs.GetString("EndGame") == "TRUE")
        {
            gameOverScene.SetActive(true);
        }
        score_temp = scoreManager.GetComponent<ScoreManager>().score;
        best_score_temp = PlayerPrefs.GetInt("BestScore");
        
        if (score_temp > best_score_temp)
        {
            currentScore.text = score_temp.ToString();
            best_score_temp = score_temp;
            PlayerPrefs.SetInt("BestScore", best_score_temp);
            bestScore.text = PlayerPrefs.GetInt("BestScore").ToString();
        }
        else if (score_temp < best_score_temp)
        {
            currentScore.text = score_temp.ToString();
            bestScore.text = PlayerPrefs.GetInt("BestScore").ToString();
        }
    }
}
