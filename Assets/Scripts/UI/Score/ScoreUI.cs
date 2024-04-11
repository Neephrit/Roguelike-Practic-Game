using System.Linq;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    public static ScoreUI instance;

    public RowUI rowUI;
    public ScoreManager scoreManager;
    void Start()
    {
            //scoreManager.AddScore(new ScoreFix("Angry Sin", 10));
            //scoreManager.AddScore(new ScoreFix("Zombi", 0));
            //scoreManager.AddScore(new ScoreFix("Sad Sin", -100));
            //scoreManager.AddScore(new ScoreFix("Proud Sin", 500));

        var scores = scoreManager.GetHightScore().ToArray();
        for(int i = 0; i < scores.Length; i++)
        {
            if (i > 5)
                break;
            var row = Instantiate(rowUI,transform).GetComponent<RowUI>();
            row.NumText.text= (i+1).ToString();
            row.NameText.text= scores[i].name;
            row.ScoreText.text = scores[i].score.ToString();
        }
    }
}
