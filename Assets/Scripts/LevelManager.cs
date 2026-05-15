using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public bool player1AtExit = false;
    public bool player2AtExit = false;

    public string nextLevelName = "Level2";

    void Update()
    {
        if (player1AtExit && player2AtExit)
        {
            SceneManager.LoadScene(nextLevelName);
        }
    }
}