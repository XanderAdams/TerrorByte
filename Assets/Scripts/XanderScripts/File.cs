using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New File", menuName = "Upgrade File")]
public class File : ScriptableObject
{
        public float size;
        public bool open;
        public string fileName;

        public virtual void Active()
        {

        }

        public virtual void Passive()
        {
            //Debug.Log("Passive");
        }
}
