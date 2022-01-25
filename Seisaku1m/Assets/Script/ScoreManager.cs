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

    void Start()
    {
        textRezult = GameObject.Find("Result Score").GetComponent<Text>();
    }

    void Update()
    {
        if (Input.GetKeyDown("joystick button 1")) {
            Totalscore += Ascore * (int)(Time.deltaTime / 100f);
        }
        if (Input.GetKeyDown("joystick button 0")) {
            Totalscore += Bscore * (int)(Time.deltaTime / 100f);
        }
        if (Input.GetKeyDown("joystick button 3")) {
            Totalscore += Cscore * (int)(Time.deltaTime / 100f);
        }

        textRezult.text = "Totalscore = " + Totalscore.ToString();
    }

}
