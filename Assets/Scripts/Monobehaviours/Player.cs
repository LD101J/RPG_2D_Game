//using System;
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using RPG_Animation_Game;
//     public class Player : Character_Doubleclick
//    {
//        HealthBar healthBar;
//        public HealthBar healthBar;
//        public GameObject healthBarPrefab;

//        hitPoints.value = startingHitPoints;
            

//            private void Start()
//        {
//        healthBarPrefab = Instantiate(healthBarPrefab);
//        }
//        private void OnTriggerEnter2D(Collider2D collision)
//        {
//            if (collision.gameObject.CompareTag("CanBePickedUp"))
//            {
//            Item hitObject = collision.gameObject.GetComponent<Consumable>().item;

//            if (hitObject != null)
//                {
//                bool shouldDissapear = false;
                
//                }
//                switch (hitObject.itemType)
//                {
//                    case Item.ItemType.COIN:
//                    shouldDissapear = true;
//                        break;

//                    case Item.ItemType.HEALTH:
//                        AdjustHitPoints(hitObject.quantity);
//                        break;

//                    default:
//                        break;
//                }
//            if (shouldDissapear)
//            {
//                collision.gameObject.SetActive(false);
//            }
//            }
//        }

//        public bool AdjustHitPoints(int amount)
//        {
//        if(hitPoints.value < maxHitPoints)
//        {
//            hitPoints.value = hitPoints.value + amount;
//            print("Adjusted hitpoints by : " + amount + ". New value: " + hitPoints);
//        }
//        return true;
//        }
//    }
