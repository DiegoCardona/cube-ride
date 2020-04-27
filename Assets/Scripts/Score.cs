using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public Transform player;
    public Text speedText;
    private long lastPosition = -45;
    private long lastTime =  System.DateTimeOffset.Now.ToUnixTimeMilliseconds();
    private int speed = 0;
    
    
    // Update is called once per frame
    private void Update()
    {
        float score = (player.position.z + 45) / 10;
        scoreText.text = score.ToString("0");
        long currentPosition = System.Convert.ToInt64(player.position.z);
        long currentTime = System.DateTimeOffset.Now.ToUnixTimeMilliseconds();
        
        if (currentPosition > (lastPosition + 10)) {
            speed = (int)(((currentPosition - lastPosition)*System.Math.Pow(10,3)) /  (currentTime - lastTime));
            lastPosition = currentPosition;
            lastTime =  currentTime;
        }

        speedText.text = speed.ToString();
    }
}
