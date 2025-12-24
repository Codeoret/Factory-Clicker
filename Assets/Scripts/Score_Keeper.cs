using UnityEngine;

public class Score_Keeper : MonoBehaviour
{
    public int Score = 0;

    public void AddScore()
    {
        Score ++;
        Debug.Log("Score: " + Score);
    }

}
