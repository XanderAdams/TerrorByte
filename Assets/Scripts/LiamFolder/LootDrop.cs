using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootDrop : ScriptableObject
{
    public Sprite lootSprite;
    public string lootName;
    public int dropChance;

    public LootDrop(string lootName, int dropChance)
    {
        this.lootName = lootName;
        this.dropChance = dropChance;
    }

}