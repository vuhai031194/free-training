using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static   GameManager _instance;
    
    private int _score = 0;

    public static GameManager Instance => _instance;

    private void Awake()
    {
        _instance = this;
    }

    public void CollectItem()
    {
        _score++;
        
        print("Current Score: " + _score);
    }
}
