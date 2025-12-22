using UnityEngine;

public class Score_Keeper : MonoBehaviour
{
    public int Score = 0;

    public void AddScore(int amount)
    {
        Score += amount;
        Debug.Log("Score: " + Score);
    }


}
