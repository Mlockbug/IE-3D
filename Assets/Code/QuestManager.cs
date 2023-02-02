using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public GameObject[] stages;
    int activeStage = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		foreach (GameObject stage in stages)
		{
			if (stages[activeStage] != stage)
			{
				stage.SetActive(false);
			}
		}
		stages[activeStage].SetActive(true);
	}

	public void ActivateQuests(string questNumber, GameObject messanger)
	{
		foreach (GameObject stage in stages)
		{
			stage.SetActive(false);
		}
		activeStage = int.Parse(questNumber) - 1;
		if (messanger != null)
		{
			messanger.GetComponent<DialogueLogic>().accepted = true;
		}
	}
}
