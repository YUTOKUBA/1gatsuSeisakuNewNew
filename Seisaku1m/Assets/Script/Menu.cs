using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    //[SerializeField] private Button pauseButton;
    [SerializeField] private GameObject pausePanel;
    //[SerializeField] private Button resumeButton;
    bool flg = false;

    void Start()
    {
        pausePanel.SetActive(false);
        //pauseButton.onClick.AddListener(Pause);
        //resumeButton.onClick.AddListener(Resume);
    }

    void Update()
    {
        if(/*flg == false && */Input.GetKeyDown("joystick button 8"))
        {
            Pause();
            flg = true;
            Debug.Log("止まった");
        }
        if(flg == true && Input.GetKeyDown("joystick button 8"))
        {
            Resume();
            flg = false;
        }
    }

    private void Pause()
    {
        Time.timeScale = 0;  // 時間停止
        pausePanel.SetActive(true);
    }

    private void Resume()
    {
        Time.timeScale = 1;  // 再開
        pausePanel.SetActive(false);
    }
}
