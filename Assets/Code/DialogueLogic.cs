using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueLogic : MonoBehaviour
{
    Queue<string> dialogue = new Queue<string>();
    bool ready = false;
    bool shouldQueue = true;
    public Text diagText;
    public GameObject textBox;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (dialogue.Count == 0)
		{
            ready = false;
            shouldQueue = true;
            StopAllCoroutines();
            textBox.SetActive(false);
		}
        if (shouldQueue)
        {
            switch (transform.tag)
            {
                case "npc 1":
                    dialogue.Clear();
                    dialogue.Enqueue("asasdasdasdasdasdasd");
                    dialogue.Enqueue("lkjlkjlkjljklkjlkjlkjljl");
                    dialogue.Enqueue("");
                    shouldQueue = false;
                    Debug.Log("Done");
                    break;
                case "npc 2":
                    dialogue.Clear();
                    dialogue.Enqueue("sadsgfgc");
                    dialogue.Enqueue("yuo6c");
                    dialogue.Enqueue("");
                    shouldQueue = false;
                    Debug.Log("Done");
                    break;
                default:
                    Debug.Log("cannot");
                    break;
            }
        }
        if (ready && Input.GetKeyDown(KeyCode.Space))
		{
            StopAllCoroutines();
            StartCoroutine(DisplayDiag());
        }
    }

    public void ReadyForDialogue()
	{
        ready = true;
        StopAllCoroutines();
        StartCoroutine(DisplayDiag());
	}

    public IEnumerator DisplayDiag()
	{
        textBox.SetActive(true);
        diagText.text = "";
        string diagString = dialogue.Dequeue();
        foreach(char x in diagString)
		{
            diagText.text = diagText.text + x.ToString();
            Debug.Log(diagText.text);
            yield return new WaitForSeconds(1);
        }
	}
}
