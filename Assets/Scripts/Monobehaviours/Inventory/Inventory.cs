using UnityEngine;
using UnityEngine.UI;

namespace RPG_Animation_Game
{
    public class Inventory : MonoBehaviour
    {
        public GameObject slotPrefab;// this is the reference to the instantiated gameobject
        public const int numSlots = 5;
        Image[] itemImages = new Image[numSlots];
        Item[] items = new Item[numSlots];
        GameObject[] slots = new GameObject[numSlots];

        private void Awake()
        {
            CreateSlots();
        }
        public void CreateSlots()
        {
            if(slotPrefab != null)
            {
                for(int i = 0; i < numSlots; i++)
                {
                    GameObject newSlot = Instantiate(slotPrefab);
                    newSlot.name = "ItemSlot_" + i;
                    newSlot.transform.SetParent(gameObject.transform.GetChild(0).transform);
                    slots[i] = newSlot;
                    itemImages[i] = newSlot.transform.GetChild(1).GetComponent<Image>();
                }
            }
        }
         public bool AddItem(Item itemToAdd)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] != null && items[i].itemType == itemToAdd.itemType && itemToAdd.stackable == true)
                {
                    items[i].quantity = items[i].quantity + 1;
                    Slot slotScript = slots[i].gameObject.GetComponent<Slot>();
                    Text quantityText = slotScript.qtyText;
                    quantityText.enabled = true;
                    quantityText.text = items[i].quantity.ToString();
                    return true;
                }
                    if(items[i] == null)
                    {
                        items[i] = Instantiate(itemToAdd);
                        items[i].quantity = 1;
                        itemImages[i].sprite = itemToAdd.sprite;
                        itemImages[i].enabled = true;
                        return true;
                    }
                }
                return false;
            }
        }
    }

