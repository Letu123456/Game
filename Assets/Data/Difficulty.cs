using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Difficulty : MonoBehaviour
{
    public float currentDifficulty = 1f;
    public float difficultyIncreaseRate = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentDifficulty += difficultyIncreaseRate * Time.deltaTime;
    }
}
