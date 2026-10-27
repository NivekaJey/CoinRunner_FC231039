using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private int coins = 0;

    void Awake() { instance = this; }

    public void AddCoin()
    {
        coins++;
        Debug.Log("Coins: " + coins);
    }

    public void LevelComplete()
    {
        Debug.Log("LEVEL COMPLETE! You got " + coins + " coins.");
        Invoke("RestartGame", 2f);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}