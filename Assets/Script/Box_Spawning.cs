using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box_Spawning : MonoBehaviour
{
    [SerializeField] private GameObject boxPrefabs;
    [SerializeField] private GameObject spawnLocation;

    [SerializeField] private GameObject starPrefabs;
    [SerializeField] private float miny, maxy;
    void Start()
    {
        StartCoroutine(boxSpawning(7f));
        StartCoroutine(starSpawning(14f));
    }
    IEnumerator boxSpawning(float seconds)
    {
        while (true)
        {
            yield return new WaitForSeconds(seconds);
            Instantiate(boxPrefabs,spawnLocation.transform.position, Quaternion.identity);
        }
    }
    IEnumerator starSpawning(float seconds)
    {
        while (true)
        {
            yield return new WaitForSeconds(seconds);
            Instantiate(starPrefabs, new Vector2(3.5f, Random.Range(miny,maxy)), Quaternion.identity);
        }
    }
}
