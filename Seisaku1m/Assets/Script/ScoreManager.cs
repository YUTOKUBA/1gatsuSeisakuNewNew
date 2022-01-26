using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private Text textRezult;

    public int Ascore = 10;
    public int Bscore = 50;
    public int Cscore = 100;
    public int Totalscore;
    public int timeCount = 0;

    void Start()
    {
        textRezult = GameObject.Find("Result Score").GetComponent<Text>();
    }

    void Update()
    {
        if (Input.GetKeyDown("joystick button 1")) {
            for (timeCount = 0; timeCount < 600; timeCount++)
            {
                if (timeCount / 100 == 0)
                {
                    Totalscore += Ascore;
                }
                Debug.Log("10+");
            }
        }
        if (Input.GetKeyDown("joystick button 0")) {
            for (timeCount = 0; timeCount < 600; timeCount++)
            {
                if (timeCount / 100 == 0)

                    Totalscore += Bscore;
                Debug.Log("50+");
            }
        }
        if (Input.GetKeyDown("joystick button 3")) {
            for (timeCount = 0; timeCount < 600; timeCount++)
            {
                if (timeCount / 100 == 0)

                    Totalscore += Cscore;
                Debug.Log("100+");
            }
        }

        textRezult.text = "Totalscore = " + Totalscore.ToString();
    }

}
