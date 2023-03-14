using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RPG_Animation_Game;

    public class Player : Character_Doubleclick
    {

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("CanBePickedUp"))
            {
                Item hitObject = collision.gameObject.GetComponent<Consumable>().item;
                if(hitObject != null)
                {
                    print("Hit: " + hitObject.name);
                }
                switch (hitObject.itemType)
                {
                    case Item.ItemType.COIN:
                        break;

                    case Item.ItemType.HEALTH:
                        break;

                        AdjustHitPoints(hitObject.quantity);
                        break;

                    default:
                        break;
                }
                collision.gameObject.SetActive(false);
            }
        }

        private void AdjustHitPoints(int amount)
        {
        hitPoints = hitPoints + amount;
        print("Adjusted hitpoints by : " + amount + ". New value: " + hitPoints);        
        }
    }
   