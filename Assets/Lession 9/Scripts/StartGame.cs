using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Lession9
{
    public class StartGame : MonoBehaviour
    {
        private void Start()
        {
            SceneManager.sceneLoaded += (arg0, mode) =>
            {
                GameManager.Instance.SetNumberItem();
            };
        }

        public void LoadScene1()
        {
            SceneManager.LoadScene("Lession 9/Scenes/MainScene");
            SceneManager.LoadScene("EnvironmentScene", LoadSceneMode.Additive);
            SceneManager.LoadScene("Level_1", LoadSceneMode.Additive);
        }
    
        public void LoadScene2()
        {
            SceneManager.LoadScene("Lession 9/Scenes/MainScene");
            SceneManager.LoadScene("EnvironmentScene", LoadSceneMode.Additive);
            SceneManager.LoadScene("Level_2", LoadSceneMode.Additive);
        }
    }

}
