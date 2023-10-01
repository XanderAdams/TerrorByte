using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootTable : MonoBehaviour
{

    public GameObject droppedItemPrefab;
    public List<File> lootList = new List<File>();
    private List<File> possibleItems;

    // Start is called before the first frame update
     File GetDroppedItem()
    {
        int randomNumber = Random.Range(1, 101);
        List<File> possibleFiles = new List<File>();
        foreach (File item in lootList)
        {
            if(randomNumber <= item.dropChance)
            {
                possibleFiles.Add(item);
               
            }
        }
        if(possibleFiles.Count > 0 )
        {
            File droppedItem = possibleFiles[Random.Range(0,possibleFiles.Count)];
            return droppedItem;


        }
        return null;
    }

    public void InstantiateFile(Vector3 spawnPositon)
    {
        File droppedItem = GetDroppedItem();
        if( droppedItem != null )
        {   droppedItemPrefab.GetComponent<FileHolder>().file = droppedItem;
            GameObject fileGameObject = Instantiate(droppedItemPrefab, spawnPositon, Quaternion.identity);
            fileGameObject.GetComponent<SpriteRenderer>().sprite = droppedItem.fileSprite;
        }
    }

   
}
