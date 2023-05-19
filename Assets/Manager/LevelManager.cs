using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public List<GameObject> lvlprefebs;
    public static LevelManager inst;
    public GameObject currentlvl;
    public GameObject parent;
    private int lvlCount = 0;
    private GameObject store;

    private void Awake()
    {
        inst = this;
        currentlvl = lvlprefebs[0];
        OnLoadLvel();
    }

    public void OnLoadLvel()
    {
        if (store != null)
        {
            Destroy(store);
        }
        store = Instantiate(lvlprefebs[lvlCount], parent.transform);



    }
    public void NextButton()
    {
        lvlCount += 1;
        OnLoadLvel();
    }

}

