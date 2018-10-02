using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {



    int currentLevel = -1;
    public List<GameObject> Levels;
    public List<GameObject> PrefabObjects;

    [HideInInspector]
    public GameObject level;


    // Use this for initialization
    void Start () {

        NextLevel();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void NextLevel()
    {
        if (currentLevel < Levels.Count - 1) currentLevel++ ;
        if (level)
        {
            level.SetActive(false);
            Destroy(level);
        }
        level = Instantiate(Levels[currentLevel]);
        ReplaceObjects();
        level.SetActive(false);
    }

    public void ReplaceObjects()
    {
        object[] sceneObjects = GameObject.FindObjectsOfType(typeof(GameObject));
        foreach (object sceneObject in sceneObjects)
        {
            GameObject currentObject = (GameObject)sceneObject;
            if (currentObject.activeInHierarchy)
            {
                for(int i = 0; i < PrefabObjects.Count; i++)
                {
                    if (currentObject.name.StartsWith(PrefabObjects[i].name))
                    {
                        GameObject newObject = (GameObject)Instantiate(PrefabObjects[i], currentObject.transform.position, Quaternion.identity, transform);
                        newObject.transform.SetParent(level.transform);
                        newObject.name = PrefabObjects[i].name;
                        Destroy(currentObject);
                    }
                }
            }
        }
    }
}
