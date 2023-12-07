using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels
{
    private int current = 1;
    public int Current =>current;
    private static Levels instance=new Levels();
    public static Levels Instance => instance;
    public void Add()
    {
        current++;
    }
    public void DeathScreen()
    {
        SceneManager.LoadScene(1);
    }
    public void Restart()
    {
        current = 1;
    }

}
