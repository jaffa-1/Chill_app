using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    public float scrollSpeed;
    private Renderer rend;
    private float offset;
    private void Start()
    {
        rend = GetComponent<Renderer>();
    }
    private void Update()
    {
        offset += Time.deltaTime * scrollSpeed;
        rend.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
    }
}
