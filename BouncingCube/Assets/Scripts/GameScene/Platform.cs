using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float ZiplamaKuvveti;
    public bool zemintemas;
    int _extrajump;

    Animator anim;


    private void Start()
    {
        anim = GetComponent<Animator>();
        _extrajump = Random.Range(1,11);
        if (_extrajump==1)
        {
            anim.SetBool("ExtraJump",true);
            ZiplamaKuvveti = 20f;
        }
        else
        {
            ZiplamaKuvveti = 14f;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.relativeVelocity.y<0)
        {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();

            if (rb != null)
            {
                Vector2 ZiplamaVelocity = rb.velocity;
                ZiplamaVelocity.y = ZiplamaKuvveti;
                rb.velocity = ZiplamaVelocity;

                if (zemintemas==false)
                {
                    ScoreScripts.TotalScore++;
                    zemintemas = true;
                }
                anim.SetBool ("TemasEdildi",true);
                Destroy(gameObject,1.2f);
            }
        }
        

       

    }
}
