using UnityEngine;
using UnityEngine.UI;

public class Speed : MonoBehaviour
{
    public Transform player;
    public Text speedText;
    private long lastPosition = -45;
    private long lastTime =  System.DateTimeOffset.Now.ToUnixTimeMilliseconds();
    private int speedTxt = 0;

    void Update()
    {
        long currentPosition = System.Convert.ToInt64(player.position.z);
        long currentTime = System.DateTimeOffset.Now.ToUnixTimeMilliseconds();
        
        if (currentPosition > (lastPosition + 10)) {
           
            speedTxt = (int)(((currentPosition - lastPosition)*System.Math.Pow(10,3)) /  (currentTime - lastTime));
            Debug.Log(speedTxt);
            lastPosition = currentPosition;
            lastTime =  currentTime;
        }

        speedText.text = speedTxt.ToString("0");
    }
}
