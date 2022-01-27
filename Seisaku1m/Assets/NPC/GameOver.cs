using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField]
    GameObject GameOverText;
    bool GameOverflg;
    // Start is called before the first frame update
    void Start()
    {
        GameOverflg = NPC.gameover();
        GameOverText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameOverflg == true)
        {
            GameOverText.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {

        }
    }
}
