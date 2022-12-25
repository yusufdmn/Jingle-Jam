using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public List<CollectableItem> collectableItemList;
    private List<CollectableItem> collectedItems;
    public List<Image> inventoryItemImages;

    public void AddToInventory(CollectableItem collectableItem)
    {
        if (!collectedItems.Contains(collectableItem))
        {
            int index = collectableItemList.IndexOf(collectableItem);
            inventoryItemImages[index].transform.GetChild(0).transform.gameObject
                .SetActive(true);
            collectedItems.Add(collectableItem);
        }
        
    }
}
