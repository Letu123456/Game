using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManage : MonoBehaviour
{
    public static bool isGameOver;
    public GameObject gameOverScreen;
    ShipMovement movement;
    ShootAbleDameRecei damage;
    GameObject player;
    ItemLooter looter;
    Shield shield;
    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;
        gameOverScreen.SetActive(false);
        Time.timeScale = 1;
        player = GameObject.FindGameObjectWithTag("Player");
        looter = FindAnyObjectByType<ItemLooter>();
        shield = FindAnyObjectByType<Shield>();
        movement = FindAnyObjectByType<ShipMovement>();
        damage = player.GetComponent<ShootAbleDameRecei>();
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.S))
        {
            SaveLoadManage.SaveGame(movement, damage, looter, shield);
        }

            if (isGameOver)
        {
            gameOverScreen.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void ReTry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Main()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }
}
