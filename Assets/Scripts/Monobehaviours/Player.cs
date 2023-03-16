using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG_Animation_Game
{
    public class Player : Character_Doubleclick
    {
        #region Variables for health
        public GameObject healthBarStore;
        public bool shouldDissapear;
        public Health_Bar healthBarPrefab;
        Health_Bar healthBar;
        #endregion
        #region Variables for inventory
        public Inventory inventoryPrefab;
        Inventory inventory;
        #endregion 
        private void Start()
        {
            #region Inventory section
            inventory = Instantiate(inventoryPrefab);
            hitPoints.value = startingHitPoints;
            healthBar = Instantiate(healthBarPrefab);
            healthBar.character = this;
            #endregion
            #region Health functions
            healthBar = Instantiate(healthBarPrefab);
            healthBar.character = this;
            #endregion
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("CanBePickedUp"))
            {
                Item hitObject = collision.gameObject.GetComponent<Consumable>().item;

                if (hitObject != null)
                {
                    shouldDissapear = false;
                    //bool shouldDissapear = false;

                }
                switch (hitObject.itemType)
                {
                    case Item.ItemType.COIN:
                        shouldDissapear = inventory.AddItem(hitObject);
                        shouldDissapear = true;
                        break;

                    case Item.ItemType.HEALTH:
                        shouldDissapear = AdjustHitPoints(hitObject.quantity);
                        break;

                    default:
                        break;
                }
                if (shouldDissapear)
                {
                    collision.gameObject.SetActive(false);
                }
            }
        }


        public bool AdjustHitPoints(int amount)
        {
            if (hitPoints.value < maxHitPoints)
            {
                hitPoints.value = hitPoints.value + amount;
                print("Adjusted hitpoints by : " + amount + ". New value: " + hitPoints);
            }
            return true;
        }
    }
}