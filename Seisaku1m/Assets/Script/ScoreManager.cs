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
    public int Dscore = 500;
    public int Totalscore;
    public static bool flgA;
    public static bool flgB;
    public static bool flgC;
    public static bool flgD;

    void Start()
    {
        textRezult = GameObject.Find("Result Score").GetComponent<Text>();
    }

    void Update()
    {
        if (Input.GetKeyDown("joystick button 1")) {
            flgA = true;
            InvokeRepeating(nameof(ScoreA), 1.0f, 1.0f);
            CancelInvoke(nameof(ScoreB));
            CancelInvoke(nameof(ScoreC));
            CancelInvoke(nameof(ScoreD));
        }
        else
        {
            flgA = false;
        }
        if (Input.GetKeyDown("joystick button 2"))
        {
            flgB = true;
            InvokeRepeating(nameof(ScoreB), 1.0f, 1.0f);
            CancelInvoke(nameof(ScoreA));
            CancelInvoke(nameof(ScoreC));
            CancelInvoke(nameof(ScoreD));

        }
        else
        {
            flgB = false;
        }
        if (Input.GetKeyDown("joystick button 3"))
        {
            flgC = true;
            InvokeRepeating(nameof(ScoreC), 1.0f, 1.0f);
            CancelInvoke(nameof(ScoreA));
            CancelInvoke(nameof(ScoreB));
            CancelInvoke(nameof(ScoreD));
        }
        else
        {
            flgC = false;
        }
        if (Input.GetKeyDown("joystick button 0"))
        {
            flgD = true;
            InvokeRepeating(nameof(ScoreD), 1.0f, 1.0f);
            CancelInvoke(nameof(ScoreA));
            CancelInvoke(nameof(ScoreB));
            CancelInvoke(nameof(ScoreC));
        }
        else
        {
            flgD = false;
        }
        textRezult.text = "Totalscore = " + Totalscore.ToString();
    }

    void ScoreA()
    {
        Totalscore += Ascore;
        Debug.Log("10+");
        flgA = false;
    }
    void ScoreB()
    {
        Totalscore += Bscore;
        Debug.Log("50+");
        flgB = false;
    }
    void ScoreC()
    {
        Totalscore += Cscore;
        Debug.Log("100+");
        flgC = false;
    }
    void ScoreD()
    {
        Totalscore += Dscore;
        Debug.Log("500+");
        flgD = false;
    }
    public static bool flagA()
    {
        return flgA;
    }
    public static bool flagB()
    {
        return flgB;
    }
    public static bool flagC()
    {
        return flgC;
    }
    public static bool flagD()
    {
        return flgD;
    }
}
