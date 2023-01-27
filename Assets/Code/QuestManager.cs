using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public GameObject[] quests;
    string questIndex;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateQuests()
	{
        int index = int.Parse(questIndex) - 1;
        quests[index].SetActive(true);
	}

    public void GetQuestNumber(string questNumber)
	{
        questIndex = questNumber;
	}
}
