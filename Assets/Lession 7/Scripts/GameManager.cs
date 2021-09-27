using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    private int _score = 0;

    public static GameManager Instance => _instance;

    private void Awake()
    {
        _instance = this;
    }

    public void CollectItem(int score)
    {
        this._score += score;

        print("Current Score: " + this._score);
    }
}