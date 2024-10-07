using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
 public class CharacterAnimationController : MonoBehaviour
 {
     private Animator animator;  
     
     private void Start()
     {
         animator = GetComponent<Animator>();
     }
 

     private void Update()
     {
         HandleAnimation();  
     }
 
     private void HandleAnimation()  
     {
         
         if (Input.GetAxis("Horizontal") != 0)
         {
             animator.SetTrigger("Run");  
         }
         else
         {
             animator.SetTrigger("Idle");  
         }
 
         
         if (Input.GetButtonDown("Jump"))
         {
             animator.SetTrigger("Jump");  
         }
 
         
         if (Input.GetKeyDown(KeyCode.W))
         {
             animator.SetTrigger("WallJump"); 
         }
     }
 }
