using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderMap : MonoBehaviour
{
    public CommandClient GetCommand;
    public int countMap;
    public List<GameObject> listMap=new List<GameObject>();
    public List<GameObject> listInfo = new List<GameObject>();
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ActiveMap()
    {
        for (int m = 0; m < listMap.Count; m++)
        {
            listMap[m].SetActive(false);
            listInfo[m].SetActive(false);


        }
        listInfo[countMap].SetActive(true);
        listMap[countMap].SetActive(true);
        GetCommand.SendCommandMapCount(countMap);
    }

    public void plusCountMap()
    {
        if (countMap >= 0&& countMap < listMap.Count - 1) { countMap += 1;   }
    }

    public void minusCountMap()
    {
        if (countMap <= listMap.Count - 1&&countMap>0)
        {
            countMap -= 1;
        }
    }

}
