using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : Singleton<InventoryManager>
{
    public List<CollectableItem> collectableItemList;
    private List<CollectableItem> collectedItems = new();
    public List<Image> inventoryItemImages;

    public void AddToInventory(CollectableItem collectableItem)
    {
        if (!collectedItems.Contains(collectableItem))
        {
            int index = collectableItemList.IndexOf(collectableItem);
            inventoryItemImages[index].GetComponent<Image>().sprite =
                collectableItem.GetComponent<SpriteRenderer>().sprite;
            inventoryItemImages[index].GetComponent<Image>().DOFade(1f, 1f);
            collectedItems.Add(collectableItem);
        }
        
    }
}
