using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knives : MonoBehaviour
{
    public float speed;
    public float dmg = 0.3f;
    public float dmgBar = 0.3f;
    public float lifetime;
    public float distance;
    public LayerMask whatIsSolid;
    public Rigidbody2D rb;


    private void Start()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D hitinfo)
    {
        Enemy enemy = hitinfo.GetComponent<Enemy>();
        if (enemy != null )
        {
            enemy.TakeDamage(dmg);
        }
        Destroy(gameObject);
    }
    //private void Update()
    //{
    //    RaycastHit2D hitinfo = Physics2D.Raycast(transform.position, transform.up, distance, whatIsSolid);
    //    if (hitinfo.collider != null)
    //    {
    //        if (hitinfo.collider.CompareTag("Enemy"))
    //        {
    //            hitinfo.collider.GetComponent<Enemy>().TakeDamage(dmg);
    //        }
    //        Destroy(gameObject);
    //    }
    //    transform.Translate(Vector2.up * speed * Time.deltaTime);
    //}
}
