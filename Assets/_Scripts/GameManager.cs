using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int currentExp =0;
    private int MaxExp;
    private int level;

    [SerializeField] StatsUI StatsUI;

    private void Start()
    {
        TaskTemplate.OnTaskCompleted += TaskTemplate_OnTaskCompleted;
        MaxExp = 100;
        StatsUI.updateExpUI(currentExp, MaxExp);
    }

    private void TaskTemplate_OnTaskCompleted(object sender, System.EventArgs e)
    {
        IncreaseExp();
        StatsUI.updateExpUI(currentExp, MaxExp);
    }

    public void IncreaseExp()
    {
        if (currentExp < MaxExp)
        {
            currentExp += 10;
        }
    }
}
