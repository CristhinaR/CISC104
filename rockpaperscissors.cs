using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public enum GameChoices
{
    none,
    rock,
    paper,
    scissors,

}


public class rockpaperscissors : MonoBehaviour
{
    [SerializeField]
    private Sprite rock_Sprite, paper_Sprite, scissors_Sprite;

    [SerializeField]
    private Image playerChoice_Img, AiChoice_Img;

    [SerializeField]
    private Text resultsText;

    private GameChoices player_Choice = GameChoices.none, Ai_Choice = GameChoices.none;

    public void SetChoices(GameChoices gameChoices)
    {
        switch (gameChoices)
        {
            case GameChoices.rock:
                playerChoice_Img.sprite = rock_Sprite;
                player_Choice = GameChoices.rock;
                break;
            case GameChoices.paper:
                playerChoice_Img.sprite = paper_Sprite;
                player_Choice = GameChoices.paper;
                break;
            case GameChoices.scissors:
                playerChoice_Img.sprite = scissors_Sprite;
                player_Choice = GameChoices.scissors;
                break;

        } // switch / case

        SetAiChoice();
        DetermineWinner();

    }

    void SetAiChoice()
    {
        int rnd = Random.Range(0, 3);
        switch (rnd)
        {
            case 0:
                Ai_Choice = GameChoices.rock;
                AiChoice_Img.sprite = rock_Sprite;
                break;

            case 1:
                Ai_Choice = GameChoices.paper;
                AiChoice_Img.sprite = paper_Sprite;
                break;

            case 2:
                Ai_Choice = GameChoices.scissors;
                AiChoice_Img.sprite = scissors_Sprite;
                break;
        }


    }

    void DetermineWinner()
    {
        if (player_Choice == Ai_Choice)
        //draw
        {
            resultsText.text = "Tie";
            StartCoroutine(DisplayWinnerandRestart());

            return;
        }

        if (player_Choice == GameChoices.paper && Ai_Choice == GameChoices.rock)
        {
            //player won
            resultsText.text = "You Win!!";
            StartCoroutine(DisplayWinnerandRestart());

            return;
        }

        if (Ai_Choice == GameChoices.paper && player_Choice == GameChoices.rock)
        {
            //Ai won
            resultsText.text = "You Lost:(";
            StartCoroutine(DisplayWinnerandRestart());

            return;
        }

        IEnumerator DisplayWinnerandRestart()
        {
            yield return new WaitForSeconds(2f);
            resultsText.gameObject.SetActive(true);


            yield return new WaitForSeconds(2f);
            resultsText.gameObject.SetActive(false);

           

        }


    }
}


  