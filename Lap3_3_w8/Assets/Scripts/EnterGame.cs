using UnityEngine;

public class EnterGame : MonoBehaviour
{
    private GameManager gameManager;

    private void Start()
    {
        gameManager = FindFirstObjectByType<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // Nếu object gốc của vật va chạm là Player
        if (other.transform.root.CompareTag("Player"))
        {
            gameManager.ShowGameMenu();
        }
    }
}