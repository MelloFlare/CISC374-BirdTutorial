using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
   public int playerScore;
   public Text scoreText;
   public GameObject gameOverScreen;
   public BirdScript bird;

    public void Start()
    {
        bird = GameObject.FindGameObjectWithTag("Bird").GetComponent<BirdScript>();
    }

    [ContextMenu("Increase Score")]
   public void addScore(int scoreToAdd){
    if(bird.birdAlive){
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }
   }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameDoness()
    {

        gameOverScreen.SetActive(true);

    }

}
