using System;
using UnityEngine;
using UnityEngine.UI;

namespace Lession9
{
    [RequireComponent(typeof(Text))]
    public class TextScore : MonoBehaviour
    {
        private Text textScore;

        private void Awake()
        {
            textScore = GetComponent<Text>();
        }

        private void OnEnable()
        {
            GameManager.Instance.UpdateScore.AddListener(UpdateScore);
        }

        private void Start()
        {
            UpdateScore(0);
        }

        private void UpdateScore(int score)
        {
            print($"Score: {score} => {name}");
            textScore.text = $"Score: {score}";
        }

        private void OnDisable()
        {
            if (GameManager.Instance)
                GameManager.Instance.UpdateScore.RemoveListener(UpdateScore);
        }
    }
}