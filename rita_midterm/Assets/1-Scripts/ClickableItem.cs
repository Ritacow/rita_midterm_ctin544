using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableItem : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] Material outlineMaterial;
    [SerializeField] MeshRenderer meshRenderer;

    public void OnSelected()
    {
        meshRenderer.materials = new Material[] { meshRenderer.materials[0], outlineMaterial };
    }

    public void OnDeselected()
    {
        meshRenderer.materials = new Material[] { meshRenderer.materials[0]};
    }

    public void OnClick()
    {
        audioSource.Play();
    }

    private void OnMouseEnter()
    {
        InventoryManager.Instance.SetCurrentItem(this);
    }

    private void OnMouseExit()
    {
        InventoryManager.Instance.SetCurrentItem(null);
    }
}
