using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnd : MonoBehaviour
{
    private float elapsedTime;
    [SerializeField]
    private float timeToDoSomething = 1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= timeToDoSomething)
        {
            elapsedTime = 0f;
            DoSomething();
        }
    }

    void DoSomething()
    {
        Application.Quit();
    }
}
