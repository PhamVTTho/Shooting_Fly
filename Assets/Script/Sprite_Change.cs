using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Sprite_Change : MonoBehaviour
{
    [SerializeField] private SpriteRenderer text_Combo;
    [SerializeField] private Sprite[] countDown;
    [SerializeField] private GameObject Box;


    void Start()
    {
        int RandomSprite = Random.Range(1,countDown.Length);
        text_Combo = gameObject.GetComponent<SpriteRenderer>();
        text_Combo.sprite = countDown[RandomSprite];
    } 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Player"));
            PlayerPrefs.SetString("EndGame", "TRUE");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            Debug.Log("Bonk !!!");
            for (int i = 1; i < countDown.Length; i++)
            {
                if (text_Combo.sprite == countDown[0])
                {
                    Destroy(Box.gameObject);
                }
                if (text_Combo.sprite == countDown[i])
                {
                    text_Combo.sprite = countDown[i - 1];
                }
            }
        }
        if (collision.CompareTag("Player"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Player"));
            PlayerPrefs.SetString("EndGame", "TRUE");
        }
    }
}
