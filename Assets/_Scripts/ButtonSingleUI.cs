using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonSingleUI : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    Vector3 shrinkScale = Vector3.one;
    [SerializeField]Vector3 expandScale = new Vector3(1.1f,1.1f,1.1f);

    RectTransform rectTransform;

    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        rectTransform.localScale = expandScale;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        rectTransform.localScale = shrinkScale;
    }
}
