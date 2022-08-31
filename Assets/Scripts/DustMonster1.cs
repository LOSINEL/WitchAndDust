using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustMonster1 : MonoBehaviour
{
    public float moveSpeed;
    public int damage;
    public int nowHp, maxHp;
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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            collision.gameObject.GetComponent<Player>().AddHp(damage * -1);
            Destroy(this.gameObject);
        }
    }
}