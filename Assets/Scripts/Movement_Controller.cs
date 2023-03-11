using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG_Animation_Game
{
    public class Movement_Controller : MonoBehaviour
    {
        #region Variables for moving Player
        [SerializeField] private float moveSpeed;
        [SerializeField] private Vector2 movement = new Vector2();
        private Rigidbody2D rb;
        #endregion
        #region Variables for animations
        Animator  animator;
       [SerializeField] private string animationState = "AnimationState";
        #endregion 
        
        public enum CharacterStates
        {
            walkEast = 1,
            walkSouth= 2,
            walkWest = 3,
            walkNorth = 4,
            IdleSouth = 5
        }
        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            animator = GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update()
        {
            UpdateState();
        }

        private void UpdateState()
        {
            if(movement.x > 0)
            {
                animator.SetInteger(animationState, (int)CharacterStates.walkEast);
            }
            else if(movement.x < 0)
            {
                animator.SetInteger(animationState, (int)CharacterStates.walkWest);
            }
            else if(movement.y > 0)
            {
                animator.SetInteger(animationState, (int)CharacterStates.walkNorth);
            }
            else
            {
                animator.SetInteger(animationState, (int)CharacterStates.IdleSouth);
            }
        }

        private void MoveCharacter()
        {
            movement.Normalize();
            rb.velocity = moveSpeed * movement;
            //movement on the x & y axis
            movement.x = Input.GetAxisRaw("Horizontal");
                    movement.y = Input.GetAxisRaw("Vertical");
        }

        private void FixedUpdate()
        {
            MoveCharacter();
            
        }
    }

}
