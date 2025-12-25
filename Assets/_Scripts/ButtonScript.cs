using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    [SerializeField] GameObject Template;
    [SerializeField] Button Button;

    private bool TemplateState = false;
    private void Awake()
    {
        Button.onClick.AddListener(() =>
        {
            TemplateState = !TemplateState;
            Template.SetActive(TemplateState);
        });
    }
}
