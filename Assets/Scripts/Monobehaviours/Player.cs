using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG_Animation_Game
{
    public class Player : Character_Doubleclick
    {

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("CanBePickedUp"))
            {
                collision.gameObject.SetActive(false);
            }
            
        }
    }
}
