using UnityEngine;

public class GameController : MonoBehaviour
{
    private ScoreManager scoreManager;

    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    // Gi? s? b?n có ph??ng th?c ?? ghi bàn cho ??i 1
    public void Team1Scores()
    {
        scoreManager.IncreaseTeam1Score(1); // T?ng ?i?m s? ??i 1
    }

    // Gi? s? b?n có ph??ng th?c ?? ghi bàn cho ??i 2
    public void Team2Scores()
    {
        scoreManager.IncreaseTeam2Score(1); // T?ng ?i?m s? ??i 2
    }
}
