using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public float moveSpeed;
    public int damage;
    public int nowHp, maxHp;
    public GameObject expPrefab;
    Vector2 moveAngle;
    GameObject player;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    private void Update()
    {
        moveAngle = (player.transform.position - transform.position).normalized;
        transform.Translate(new Vector2(moveAngle.x * moveSpeed * Time.deltaTime, moveAngle.y * moveSpeed * Time.deltaTime));
    }
    public void GetDamaged(int num)
    {
        nowHp -= num;
        GetComponent<MonsterHpBar>().RefreshHpBar();
        CheckDead();
    }
    void CheckDead()
    {
        if (nowHp <= 0) MonsterDead();
    }

    void MonsterDead()
    {
        GameObject exp = Instantiate(expPrefab, transform.position, Quaternion.identity);
        exp.GetComponent<ExperiencePoint>().SetExpPoint(1);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            collision.gameObject.GetComponent<Player>().AddHp(damage * -1);
            Destroy(this.gameObject);
        }
    }
}