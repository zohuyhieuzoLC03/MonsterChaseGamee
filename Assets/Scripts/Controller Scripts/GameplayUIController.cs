using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameplayUIController : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private Text timerText;
    private int timerCount;
    public void RestartGame()
    {

        Time.timeScale = 1f;
        SceneManager.LoadScene(TagManager.GAMEPLAY_SCENE_NAME);
    }

    public void BackToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(TagManager.MAIN_MENU_SCENE_NAME);
    }
    void Start()
    {
        InvokeRepeating("CountTime",1f,1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CountTime()
    {
        timerCount++;
        timerText.text = "Time: " + timerCount;
    }
}
