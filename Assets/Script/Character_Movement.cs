using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Movement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidbody2d;
    [SerializeField] private float jump_Force;

    [SerializeField] private GameObject bulletPrefabs;

    void Start()
    {
        StartCoroutine(BulletSpawnning(0.7f));
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody2d.velocity = Vector2.up * jump_Force;
        }
    }
    IEnumerator BulletSpawnning(float seconds)
    {
        while (true)
        {
            yield return new WaitForSeconds(seconds);
            Instantiate(bulletPrefabs, this.transform.position, Quaternion.identity);
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("EndGame"))
        {
            Destroy(this.gameObject);
            PlayerPrefs.SetString("EndGame", "TRUE");

        }
    }
}
