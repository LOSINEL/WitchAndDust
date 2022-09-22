using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BubbleMissile : MonoBehaviour
{
    const float normalSpeed = 100f;
    const float addSpeed = 10f;
    const int normalDamage = 5;
    const int addDamage = 1;
    const float normalSize = 1f;
    const float addSize = 0.1f;
    [SerializeField] float moveSpeed;
    [SerializeField] float damage;
    [SerializeField] float size;
    private void Start()
    {
        SetMagicOption();
    }
    private void Update()
    {
        transform.Translate(new Vector2(moveSpeed * Time.deltaTime, 0));
    }
    void SetMagicOption()
    {
        moveSpeed = AbilityManager.nowAbilityLevel[(int)AbilityManager.AbilityName_.BubbleMissile] * addSpeed + normalSpeed;
        damage = AbilityManager.nowAbilityLevel[(int)AbilityManager.AbilityName_.BubbleMissile] * addDamage + normalDamage;
        size = AbilityManager.nowAbilityLevel[(int)AbilityManager.AbilityName_.BubbleMissile] * addSize + normalSize;
    }
}