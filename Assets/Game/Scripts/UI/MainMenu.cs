using Stalinho2D.General;
using UnityEngine;

namespace Stalinho2D.UI
{
    public class MainMenu : MonoBehaviour
    {
        private LevelLoader levelLoader;

        private void Awake()
        {
            levelLoader = GameObject.FindGameObjectWithTag("LevelLoader").GetComponent<LevelLoader>();
        }

        public void PlayGame()
        {
            levelLoader.LoadNextLevel();
        }

        public void QuitGame()
        {
            levelLoader.QuitGame();
        }

    }

}