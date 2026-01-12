using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TaskTemplate : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI taskText;
    [SerializeField] private Button priorityButton;
    [SerializeField] Button deleteButton;
    [SerializeField] Button CompleteButton;

    public static event EventHandler OnTaskCompleted;
    public static event EventHandler OnTaskRemoved;

    int priority = 0;
    private void Awake()
    {
        CompleteButton.onClick.AddListener(() =>
        {
            OnTaskCompleted?.Invoke(this, EventArgs.Empty);
            Destroy(gameObject);
        });
        deleteButton.onClick.AddListener(() =>
        {
            OnTaskRemoved?.Invoke(this, EventArgs.Empty);
            Destroy(gameObject);
        });
        priorityButton.onClick.AddListener(() => {
            updatePriority();
        });
    }
    private void updatePriority()
    {
        if (priority < 3)
            priority++;
        else
            priority = 0;
            switch (priority)
            {
                case 0:
                    priorityButton.image.color = Color.white;
                    break;
                case 1:
                    priorityButton.image.color = Color.green;
                    break;
                case 2:
                    priorityButton.image.color = Color.yellow;
                    break;
                case 3:
                    priorityButton.image.color = Color.red;
                    break;
                default:
                    priorityButton.image.color = Color.white;
                    break;
            }
    }
    public void setText(string text)
    {
        taskText.text = text;
    }
}
