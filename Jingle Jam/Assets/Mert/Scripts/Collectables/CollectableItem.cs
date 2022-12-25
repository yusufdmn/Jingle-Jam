using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class CollectableItem : MonoBehaviour
{
    [SerializeField] private string itemName;
    [SerializeField] private Sprite itemSprite;

    private void Start()
    {
        GetComponent<SpriteRenderer>().sprite = itemSprite;
    }
}
