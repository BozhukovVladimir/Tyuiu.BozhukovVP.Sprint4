﻿using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BozhukovVP.Sprint4.Task0.V3.Lib;

public class DataService : ISprint4Task0V3
{
    public int GetMultOddArrEl(int[] array)
    {
        int с = 1;
        foreach (int i in array)
        {
            if (i % 2 != 0)
            {
                с = с * i;
            }
        }
        return с;
    }
}
