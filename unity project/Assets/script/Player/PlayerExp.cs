using UnityEngine;

public class PlayerExp : MonoBehaviour
{
    [Header("Config")]
    [SerializeField] private PlayerStats stats;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            AddExp(300f);
        }
    }

    public void AddExp(float amount)
    {
    stats.CurrentExp += amount;
    while (stats.CurrentExp >= stats.NextLevelExp)
    {
        stats.CurrentExp -= stats.NextLevelExp;
        NextLevel();
    }
    }  
    private void NextLevel()
    {
        stats.Level++;
        float CurrentExpRequired = stats.NextLevelExp;
        float newNextLevelExp = Mathf.Round(CurrentExpRequired + stats.NextLevelExp 
        *(stats.ExpMultiplier / 100f));
        stats.NextLevelExp = newNextLevelExp;
    }
}
