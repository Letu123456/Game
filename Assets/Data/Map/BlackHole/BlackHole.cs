using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlackHole : AllBeh
{

    protected string sceneName = "GalaxyOne";
  protected virtual void OnMouseDown()
    {
        LoadScene();
    }

    protected virtual void LoadScene()
    {
        SceneManager.LoadScene(this.sceneName);
    }
}
