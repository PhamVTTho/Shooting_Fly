using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreCount;
    [SerializeField] public int score;

    void Update()
    {
        scoreCount.text = (int) score + "";
    }
}
