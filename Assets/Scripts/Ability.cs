using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Ability", menuName = "Ability")]
public class Ability : ScriptableObject
{
    public Sprite abilityImage;
    public string[] abilityInfo;
    public string abilityName;
    public GameObject abilityPrefab;
    public int maxLevel;
}