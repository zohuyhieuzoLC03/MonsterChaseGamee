using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // public void SelectPlayer1()
    // {
    //     CharacterSelectController.instance.CharIndex = 0;
    //     Debug.Log(CharacterSelectController.instance.CharIndex);
    // }
    //
    // public void SelectPlayer2()
    // {
    //     CharacterSelectController.instance.CharIndex = 1;
    //     Debug.Log(CharacterSelectController.instance.CharIndex);
    // }

    public void SelectPlayer()
    {
        string btnName = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
        CharacterSelectController.instance.CharIndex = int.Parse(btnName);
        SceneManager.LoadScene(TagManager.GAMEPLAY_SCENE_NAME);
    }
    
    public void PlayGame()
    {
        SceneManager.LoadScene(TagManager.GAMEPLAY_SCENE_NAME);
    }
}
