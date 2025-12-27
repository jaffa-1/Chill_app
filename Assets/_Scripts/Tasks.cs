using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class Tasks : MonoBehaviour
{
    [SerializeField] TMP_InputField TaskInput;
    [SerializeField] Button CreateButton;
    [SerializeField] Transform taskContainer;
    [SerializeField] Transform taskTemplate;

    
    string taskString;
    private void Awake()
    {
        TaskInput.onValueChanged.AddListener((string text) =>
        {
            taskString = text;
        });
        CreateButton.onClick.AddListener(() =>
        {   if(taskString != null)
            {
            Transform taskTransform = Instantiate(taskTemplate, taskContainer);
            if (taskTransform.TryGetComponent(out TaskTemplate TaskTemplate))
            {
                TaskTemplate.setText(taskString);
            }
            taskTransform.gameObject.SetActive(true);
            TaskInput.text = "";
            taskString = null;
            }
        });
    }
    private void Start()
    {
        taskTemplate.gameObject.SetActive(false);
    }
}
