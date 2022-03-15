using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    private int nextSceneToLoad;
    float currentTime = 5.0f;
    public Text CountDown;

    void Start()
    {
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }
    void Update()
    {
        currentTime -= 1*Time.deltaTime;
        CountDown.text = currentTime.ToString();
        if (currentTime <= 0)
        {
            SceneManager.LoadScene(nextSceneToLoad);
        }
    }
}
