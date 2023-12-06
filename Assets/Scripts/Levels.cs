using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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


}
