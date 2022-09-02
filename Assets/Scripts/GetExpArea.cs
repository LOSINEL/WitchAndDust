using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetExpArea : MonoBehaviour
{
    float range = 2f;
    public GameObject player;
    private void Start()
    {
        GetComponent<CircleCollider2D>().radius = range;
    }
    public void AddRange(float num)
    {
        range += num;
    }
    public void SetRange(float num)
    {
        range = num;
    }
    public float GetRange()
    {
        return range;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag.Equals("ExperiencePoint"))
        {
            player.GetComponent<Player>().AddExp(collision.GetComponent<ExperiencePoint>().GetExpPoint());
            Debug.Log(player.GetComponent<Player>().NowExp);
            Destroy(collision.gameObject);
        }
    }
}