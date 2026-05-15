using UnityEngine;

public class ExitDoor : MonoBehaviour
{
    public LevelManager levelManager;
    public int playerNumber;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (playerNumber == 1 && collision.gameObject.name == "Player1")
        {
            levelManager.player1AtExit = true;
        }

        if (playerNumber == 2 && collision.gameObject.name == "Player2")
        {
            levelManager.player2AtExit = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (playerNumber == 1 && collision.gameObject.name == "Player1")
        {
            levelManager.player1AtExit = false;
        }

        if (playerNumber == 2 && collision.gameObject.name == "Player2")
        {
            levelManager.player2AtExit = false;
        }
    }
}