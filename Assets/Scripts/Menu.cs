using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public void exit()
    {
        Application.Quit();
    }
    public void play(string scene_name)
    {
        Application.LoadLevel(scene_name);
    }
}
