using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance { get; private set; }
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private ClickableItem currentItem;

    public void SetCurrentItem(ClickableItem item)
    {
        if(currentItem != null)
        {
            currentItem.OnDeselected();
        }
        currentItem = item;
        currentItem?.OnSelected();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if(currentItem != null)
            {
                currentItem.OnClick();
                Destroy(currentItem.gameObject);
                currentItem = null;
            }
        }
    }
}
