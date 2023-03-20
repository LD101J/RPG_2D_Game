using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG_Animation_Game
{
    [CreateAssetMenu(menuName = "Item")]
    public class Item : ScriptableObject
    {
        [SerializeField] private string objectName;
        public Sprite sprite;
        public int quantity;
        public bool stackable;
        public enum ItemType
        {
            COIN,
            HEALTH
        }
        public ItemType itemType;
        
    }
}
