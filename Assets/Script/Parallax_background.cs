using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax_background : MonoBehaviour
{
    [SerializeField] private float offset;
    [SerializeField] private float background_Speed;
    private SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        offset += Time.deltaTime * background_Speed;
        spriteRenderer.material.SetTextureOffset("_MainTex",new Vector2(offset,0));
    }
}
