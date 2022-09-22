using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[CreateAssetMenu(fileName = "New Ability", menuName = "Ability")]
public class Ability : ScriptableObject
{
    public Image abilityImage;
    public string[] abilityInfo;
    public string abilityName;
    public GameObject abilityPrefab;
    public int maxLevel;
}