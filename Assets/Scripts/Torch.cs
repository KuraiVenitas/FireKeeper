using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class Torch : MonoBehaviour
{
    public Sprite newSprite;    
    public SpriteRenderer sr;

    private bool isLit;
    private int lightCount;
    public Door door;


    private void Start()
    {
        
        lightCount = 0;
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        sr = GetComponent<SpriteRenderer>();

        if(sr == null)
        {
            sr = gameObject.AddComponent<SpriteRenderer>();
        }

        if (collision.CompareTag("Player")) {
            sr.sprite = newSprite;
            isLit = true;
            if(lightCount == 0)
            {
                door.litObjects.Add(true);
                lightCount++; // Prevents the player from using the same instance of torch to open the doorway
            }
        }
        else
        {
            isLit = false;
        }
    }
}
