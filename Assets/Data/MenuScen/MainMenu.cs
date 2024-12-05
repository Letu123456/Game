using System.Collections;
using System.IO;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject button_continue;
    public static GameData gameData = null;    
    private void Start()
    {
        if(System.IO.File.Exists(SaveLoadManage.game_data_path)){
            button_continue.SetActive(true);
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void Man2()
    {
        SceneManager.LoadSceneAsync(2);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Continue()
    {
        gameData = SaveLoadManage.LoadGame();
        SceneManager.LoadSceneAsync(1);
    }
}
