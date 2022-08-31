using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExperiencePoint : MonoBehaviour
{
    int expPoint;
    public void SetExpPoint(int num)
    {
        expPoint = num;
    }

    public int GetExpPoint()
    {
        return expPoint;
    }
}