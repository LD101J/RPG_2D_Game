using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG_Animation_Game
{
    [CreateAssetMenu(menuName = "Item")]
    public class Item : ScriptableObject
    {
        [SerializeField] private string objectName;
        [SerializeField] private Sprite sprite;
        public int quantity;
        [SerializeField] private bool stackable;
        public enum ItemType
        {
            COIN,
            HEALTH
        }
        public ItemType itemType;
        
    }
}
