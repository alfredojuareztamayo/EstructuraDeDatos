using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public bool isAttack;
    Animator animator;
    public string namePlayer;
    public GameObject windWall;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        attackMove(namePlayer);
       
    }
    IEnumerator TIMEWALL()
    {
        
        yield return new WaitForSeconds (1f);
    }
    public void attackMove(string player)
    {
        
        if(player == "PlayerOne")
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                animator.SetBool("IsAttack", true);
                windWall.SetActive(true);
               StartCoroutine(TIMEWALL());
                
            }
            if (Input.GetKeyUp(KeyCode.X))
            {
                animator.SetBool("IsAttack", false);
              
            }
        }
        if (player == "PlayerTwo")
        {
            if (Input.GetKeyDown(KeyCode.M))
            {
                animator.SetBool("IsAttack", true);
            }
            if (Input.GetKeyUp(KeyCode.M))
            {
                animator.SetBool("IsAttack", false);
            }
        }
    }
}
