using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BlenderDrop : MonoBehaviour, IDropHandler
{
    public Image blenderImage;
    public Sprite[] blenderStages; // multiple fill images

    private int currentStage = 0;

    public void OnDrop(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;

        if (dropped != null && dropped.CompareTag("fruta"))
        {
            // Hide fruit
            dropped.SetActive(false);

            // Increase blender stage
            if (currentStage < blenderStages.Length)
            {
                blenderImage.sprite = blenderStages[currentStage];
                currentStage++;
            }
        }
    }
}