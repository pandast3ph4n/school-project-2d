using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class QuitManager : MonoBehaviour

{
    public void QuitGame()
    {
        Application.Quit();
        print("Game is exiting");
    }
}
