using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnStart()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void OnEnd()
    {
        SceneManager.LoadScene("End");
        StartCoroutine(Timer());
    }

    public void OnTitle()
    {
        SceneManager.LoadScene("Title");
    }

    private IEnumerator Timer()
    {
        yield return new WaitForSecondsRealtime(1.0f);

        Application.Quit();
    }
}
