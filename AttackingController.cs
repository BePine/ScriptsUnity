using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackingController : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;

    private bool isAttack = false;
    private float timer = 0f;
    private float timeToAttack= 0.25f;
    void Start()
    {
        // attackArea = transform.GetChild(0).gameObject;
        animator = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)){
            Attack();
        }
        if(isAttack)
        {
            timer += Time.deltaTime;
            if(timer >= timeToAttack){
                timer = 0;
                animator.SetBool("isAttack", false);
                isAttack = false;
                // attackArea.SetActive(isAttack);
            }
        }
    }
    private void Attack()
    {
        animator.SetBool("isAttack", true);
        isAttack = true;
        // attackArea.SetActive(isAttack);
    }
}
