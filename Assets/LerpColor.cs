using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class LerpColor : MonoBehaviour
{
    SpriteRenderer spriteRend;
    [SerializeField] [Range(0f, 1f)] float lerpTime;
    [SerializeField] Color[] myColors;

    private int colorIndex = 0;

    int len;

    float t = 0f;
    void Start()
    {
        spriteRend = GetComponent<SpriteRenderer>();
        len = myColors.Length;
    }

    // Update is called once per frame
    void Update()
    {
        spriteRend.color = Color.Lerp(spriteRend.color, myColors[colorIndex], lerpTime * Time.deltaTime);
        t = Mathf.Lerp(t, 1f, lerpTime * Time.deltaTime);
        if (t > .9f) {
            t = 0f;
            colorIndex++;
            colorIndex = (colorIndex >= len) ? 0 : colorIndex;
        }
    }
}
