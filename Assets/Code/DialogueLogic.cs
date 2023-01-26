using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueLogic : MonoBehaviour
{
    public string[] sentances;
    Queue<string> dialogue = new Queue<string>();
    bool ready = false;
    bool shouldQueue = true;
    public Text diagText;
    public GameObject textBox;
    public GameObject yesOrNoButtons;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (dialogue.Count == 0)
		{
            GameObject.Find("Player").GetComponent<CharacterControl>().OutOfDialogue();
            ready = false;
            shouldQueue = true;
            StopAllCoroutines();
            textBox.SetActive(false);
		}
        if (shouldQueue)
        {
            dialogue.Clear();
            foreach (string x in sentances)
            {
                dialogue.Enqueue(x);
            }
            dialogue.Enqueue("");
            shouldQueue = false;
        }
        if (ready && Input.GetKeyDown(KeyCode.Space))
		{
            StopAllCoroutines();
            StartCoroutine(DisplayDiag());
        }
    }

    public void ReadyForDialogue()
	{
        yesOrNoButtons.SetActive(false);
        ready = true;
        StopAllCoroutines();
        StartCoroutine(DisplayDiag());
	}

    public IEnumerator DisplayDiag()
	{
        string diagString = dialogue.Dequeue();

        if (diagString.Contains("QUEST-"))
        {
            string selection = diagString.Split('-')[1];
            Debug.Log(selection);
            yesOrNoButtons.SetActive(true);
            Cursor.lockState = CursorLockMode.Confined;
        }
        else
        {
            textBox.SetActive(true);
            diagText.text = "";

            foreach (char x in diagString)
            {
                diagText.text = diagText.text + x.ToString();
                Debug.Log(diagText.text);
                yield return new WaitForSeconds(0.1f);
            }
        }
	}
}
