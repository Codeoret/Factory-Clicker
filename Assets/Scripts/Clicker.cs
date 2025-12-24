using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Clicker : MonoBehaviour, IPointerClickHandler
{
    private Score_Keeper scoreKeeper;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreKeeper = FindAnyObjectByType<Score_Keeper>();
        if (scoreKeeper == null)
        {
            Debug.LogError("Score_Keeper not found in the scene!");
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (scoreKeeper != null)
        {
            scoreKeeper.AddScore();
        }
        else
        {
            Debug.LogError("Score_Keeper is null!");
        }
    }

}
