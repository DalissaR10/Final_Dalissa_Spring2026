using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public Transform checkpoint;
    public GameObject player;
    public GameObject winText;

    void Start()
    {
        winText.SetActive(false);
        Time.timeScale = 1f;
    }

    public void RespawnPlayer()
    {
        player.transform.position = checkpoint.position;
        Rigidbody2D rb = player.GetComponent<Rigidbody2D>();
        rb.linearVelocity = Vector2.zero;
    }

    public void WinGame()
    {
        winText.SetActive(true);
        Time.timeScale = 0f;
    }
}