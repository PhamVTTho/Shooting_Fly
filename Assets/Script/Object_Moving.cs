using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Moving : MonoBehaviour
{
    [SerializeField] private float object_Speed;
    void Update()
    {
        this.transform.Translate(-object_Speed * Time.deltaTime,0,0);
        Destroy(this.gameObject,20f);
    }
}
