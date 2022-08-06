using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score_Colider : MonoBehaviour
{
    private GameObject scoreText;
    void Start()
    {
        scoreText = GameObject.FindGameObjectWithTag("ScoreManager");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Score++");
            scoreText.GetComponent<ScoreManager>().score++;
            Destroy(this.gameObject);
        }
    }
}
