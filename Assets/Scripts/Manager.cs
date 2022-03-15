using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public Text Result;
    public Sprite Enemy;

    public string[] Choices;
    public Image Rock, Scissors, Paper;

    public void Play(string myChoice)
    {
        string randomChoice = Choices[Random.Range(0, Choices.Length)];

        switch (randomChoice)
        {
            case "Rock":
                switch (myChoice)
                {
                    case "Rock":
                        Result.text = "Tie";
                        break;
                    case "Paper":
                        Result.text = "Lose";
                        break;
                    case "Scissors":
                        Result.text = "Win";
                        break;

                }
                break;
            case "Paper":
                switch (myChoice)
                {
                    case "Rock":
                        Result.text = "Win";
                        break;
                    case "Paper":
                        Result.text = "Tie";
                        break;
                    case "Scissors":
                        Result.text = "Lose";
                        break;

                }
                break;
            case "Scissors":
                switch (myChoice)
                {
                    case "Rock":
                        Result.text = "Lose";
                        break;
                    case "Paper":
                        Result.text = "Win";
                        break;
                    case "Scissors":
                        Result.text = "Tie";
                        break;

                }
                break;
        }
    }
}
