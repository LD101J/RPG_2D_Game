using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RPG_Animation_Game
{
    public class Health_Bar : MonoBehaviour
    {
        public Hit_Points hit_Points;
        [HideInInspector] public Player character;
        public Image meterImage;
        public Text hpText;
        float maxHitPoints;
        //[SerializeField] private float variableForHB;

        private void Start()
        {
            
            maxHitPoints = character.maxHitPoints;
        }
        private void Update()
        {
            if(character != null)
            {
                meterImage.fillAmount = hit_Points.value / maxHitPoints;
                hpText.text = "HP :" + (meterImage.fillAmount * 100);
            }
        }
    }
}