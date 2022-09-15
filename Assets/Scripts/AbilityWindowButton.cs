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
        else Abilities.nowAbilityLevel[abilityNum]++;
        abilityButtonWindow.SetActive(false);
    }

    public void SelectAbilityRefresh()
    {
    }

    public void SelectAbilityIgnore()
    {
    }
}