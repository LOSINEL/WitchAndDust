using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityManager : MonoBehaviour
{
    public static Ability[] abilities;
    public static int[] maxAbilityLevel;
    public static int[] nowAbilityLevel;
    private void Start()
    {
        InitAbilityLevel();
    }
    public enum AbilityName_
    {
        BubbleMissile,
    }

    public void InitAbilityLevel()
    {
        for(int i=0;i<abilities.Length;i++)
        {
            maxAbilityLevel[i] = abilities[i].maxLevel;
        }
        for(int i=0;i<nowAbilityLevel.Length;i++)
        {
            nowAbilityLevel[i] = 0;
        }
    }
}