using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int max = 1000;
        int min = 1;


        Debug.Log("Welcome to number wizard");
        Debug.Log("Pick a number");
        Debug.Log("The highest number you can pick is : " + max);
        Debug.Log("The lowest number you can pick is : " + min);
        Debug.Log("Tell me if your number is higher or lower then 500");
        Debug.Log("Push up = higher, Push down = Lower, Push Enter = Correct");


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        { 
            Debug.Log("Up Arrow key was pressed.");
        }
      
        if (Input.GetKeyDown(KeyCode.DownArrow))
        { 
            Debug.Log("Down Arrow key was pressed.");
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Return key was pressed.");
        }
    }
}
