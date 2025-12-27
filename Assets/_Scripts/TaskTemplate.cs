using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TaskTemplate : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI taskText;
    [SerializeField] private Button priorityButton;

    public void setText(string text)
    {
        taskText.text = text;
    }
}
