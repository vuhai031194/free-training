using System;
using UnityEngine;
using UnityEngine.UI;

namespace Lession8
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private Text _textScore;
        
        private static   GameManager _instance;
    
        private int _score = 0;

        public static GameManager Instance => _instance;

        private void Awake()
        {
            _instance = this;
        }

        private void Start()
        {
            _textScore.text = $"Score: 0";
        }

        public void CollectItem(int score)
        {
            this._score += score;

            _textScore.text = this._score.ToString();
            
            print("Current Score: " + this._score);
        }
    }

}

