using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public Transform player;
    
    
    // Update is called once per frame
    private void Update()
    {
        float score = (player.position.z + 45) / 10;
        scoreText.text = score.ToString("0");
    }
}
