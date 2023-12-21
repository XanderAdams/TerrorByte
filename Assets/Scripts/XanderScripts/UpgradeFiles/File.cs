using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewFile", menuName = "UpgradeFile/Health")]
public class File : ScriptableObject
{
        public float size;
        public bool open = false;
        public string fileName;
        public Sprite fileSprite;
        public Color newColor;
        public int dropChance;

        public virtual void Active()
        {

        }

        public virtual void Passive()
        {
            //Debug.Log("Passive");
        }
}
