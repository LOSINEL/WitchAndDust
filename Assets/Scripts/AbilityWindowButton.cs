using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AbilityWindowButton : MonoBehaviour
{
    int abilityNum = -1;
    public GameObject abilityButtonWindow;
    public void SelectAbilityButton()
    {
        abilityNum = EventSystem.current.currentSelectedGameObject.GetComponent<AbilityButton>().AbilityNum;
    }

    public void SelectAbilityConfirm()
    {
        if (abilityNum == -1) return;
        else AbilityManager.nowAbilityLevel[abilityNum]++;
        abilityButtonWindow.SetActive(false);
    }

    public void SelectAbilityRefresh()
    {
        for (int i = 0; i < abilityButtonWindow.transform.childCount; i++)
        {
            abilityButtonWindow.transform.GetChild(i).GetComponent<AbilityButton>().AbilityNum = Random.Range(0, abilityButtonWindow.transform.childCount);
            for (int j = 0; j < i; j++)
            {
                if (abilityButtonWindow.transform.GetChild(i).GetComponent<AbilityButton>().AbilityNum == abilityButtonWindow.transform.GetChild(j).GetComponent<AbilityButton>().AbilityNum) continue;
                else
                {
                    i--;
                    break;
                }
            }
            
        }
    }

    public void SelectAbilityIgnore()
    {
    }
}