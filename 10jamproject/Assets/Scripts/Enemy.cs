using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public Transform target;
    
    private float radius = 2f;
    Animator anim;
   // Health health;
    bool isWalking = false;

    //Sounds
    public GameObject zombieAttackSound;
    public GameObject zombieMoveSound;


    void Start()
    {

        anim = gameObject.GetComponent<Animator>();
       // health = GameObject.Find("Player").GetComponent<Health>();
    }

    void Update()
    {

        
        
      
        float distance = Vector3.Distance(target.position, transform.position);




    }
    void FacePlayer()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
    public void AttackDmg()
    {
        zombieAttackSound.GetComponent<AudioSource>().Play();
       // health.TakeDamage(10);

    }

}
