using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private bool gameHasEnded = false;
    public float restartDelay = 2f;
    public GameObject completeLevelUI;
    public GameObject scoreBoard;
    public Text score;
    public Text finalScore;

    public void CompleteLevel()
    {
        finalScore.text = score.text;
        gameHasEnded = true;
        scoreBoard.SetActive(false);
        completeLevelUI.SetActive(true);
        
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            Invoke("Restart", restartDelay);
        }
    }

    private void Restart()
    {
        gameHasEnded = false;
        completeLevelUI.SetActive(false);
        scoreBoard.SetActive(true);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void Continue()
    {
        gameHasEnded = false;
        completeLevelUI.SetActive(false);
        scoreBoard.SetActive(true);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

    private void FixedUpdate()
    {
        if (gameHasEnded) {
            if (Input.GetKey("r"))
            {
                Restart();
            }
            else if (Input.GetKey("space"))
            {
                Continue();
            } 
        }
    } 
}
