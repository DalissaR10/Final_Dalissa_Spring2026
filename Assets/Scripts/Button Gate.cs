using UnityEngine;

public class ButtonGate : MonoBehaviour
{
    public GameObject gate;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gate.SetActive(false);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gate.SetActive(true);
        }
    }
}