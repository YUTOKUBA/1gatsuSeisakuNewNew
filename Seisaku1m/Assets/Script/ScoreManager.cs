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
            InvokeRepeating(nameof(ScoreA), 1.0f, 1.0f);
            CancelInvoke(nameof(ScoreB));
            CancelInvoke(nameof(ScoreC));
        }
        if (Input.GetKeyDown("joystick button 0"))
        {
            InvokeRepeating(nameof(ScoreB), 1.0f, 1.0f);
            CancelInvoke(nameof(ScoreA));
            CancelInvoke(nameof(ScoreC));

        }
        if (Input.GetKeyDown("joystick button 3"))
        {
            InvokeRepeating(nameof(ScoreC), 1.0f, 1.0f);
            CancelInvoke(nameof(ScoreB));
            CancelInvoke(nameof(ScoreA));
        }
        textRezult.text = "Totalscore = " + Totalscore.ToString();
    }

    void ScoreA()
    {
        Totalscore += Ascore;
        Debug.Log("10+");
    }
    void ScoreB()
    {
        Totalscore += Bscore;
        Debug.Log("50+");
    }
    void ScoreC()
    {
        Totalscore += Cscore;
        Debug.Log("100+");
    }
}
