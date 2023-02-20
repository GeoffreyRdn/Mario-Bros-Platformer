using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [Header("UI")]
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private GameObject gameOverGO;

    [Space(10)]
    [Range(0,350)]
    [SerializeField] private float timer;

    private static bool timerIsRunning = true;
    

    void Update()
    {
        if (timerIsRunning)
        {
            if (timer > 0)
            {
                timer -= Time.deltaTime;
                timerText.text = "TIME\n" + (int) timer;
            }
            
            else
            {
                timerIsRunning = false;
                gameOverGO.SetActive(true);
            }
        }
        
    }
}