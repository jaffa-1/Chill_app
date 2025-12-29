using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    private int currentExp =0;
    private int MaxExp;
    private int level = 1;

    [SerializeField] StatsUI StatsUI;
    [SerializeField] List<LevelSO> LevelSoList;

    private void Start()
    {
        TaskTemplate.OnTaskCompleted += TaskTemplate_OnTaskCompleted;
        MaxExp = 100;
        StatsUI.updateExpUI(currentExp, MaxExp, level);
        foreach (LevelSO levelSO in LevelSoList)
        {
            if (level == levelSO.level)
            {
                MaxExp = levelSO.maxExp;
            }
        }
    }

    private void TaskTemplate_OnTaskCompleted(object sender, System.EventArgs e)
    {
        IncreaseExp();
        StatsUI.updateExpUI(currentExp, MaxExp, level);
    }

    public void IncreaseExp()
    {
        if (currentExp < MaxExp - 10)
        {
            currentExp += 10;
        }
        else 
        {
            LevelUp();
        }
    }
    public void LevelUp()
    {
        level++;
        currentExp = 0;
        foreach (LevelSO levelSO in LevelSoList)
        {
            if (level == levelSO.level)
            {
                MaxExp = levelSO.maxExp;
            }
        }
        StatsUI.updateExpUI(currentExp, MaxExp, level);
    }
    [ContextMenu("increase xp")]
    public void increaseXPMax()
    {
        currentExp = MaxExp - 20;
        StatsUI.updateExpUI(currentExp, MaxExp, level);
    }
}
