using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueLogic : MonoBehaviour
{
    public string[] sentances;
    string diagString;
    Queue<string> dialogue = new Queue<string>();
    bool ready = false;
    bool shouldQueue = true;
    public Text diagText;
    public GameObject textBox;
    public GameObject yesOrNoButtons;
    bool typing = false;
    public bool accepted;
    public GameObject overworldHelp;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        overworldHelp.transform.LookAt(GameObject.Find("Player").GetComponent<Transform>());
        //overworldHelp.transform.rotation = Quaternion.Euler(0f, overworldHelp.transform.rotation.y, 0f);
        if (dialogue.Count == 0)
		{
            diagText.gameObject.SetActive(false);
            Debug.Log("WWWW");
            GameObject.Find("Player").GetComponent<CharacterControl>().OutOfDialogue();
            ready = false;
            shouldQueue = true;
            StopAllCoroutines();
            textBox.SetActive(false);
		}

        if (shouldQueue && accepted)
		{
            overworldHelp.SetActive(false);
            dialogue.Clear();
            dialogue.Enqueue(sentances[sentances.Length - 1]);
            dialogue.Enqueue("");
            shouldQueue = false;
            enabled = false;
        }
        else if (shouldQueue)
        {
            overworldHelp.SetActive(true);
            dialogue.Clear();
            foreach (string x in sentances)
            {
                dialogue.Enqueue(x);
            }
            dialogue.Enqueue("");
            shouldQueue = false;
        }

        if (typing && Input.GetKeyDown(KeyCode.Space))
		{
            diagText.text = diagString;
            typing = false;
            ready = true;
        }
        else if (ready && Input.GetKeyDown(KeyCode.Space))
		{
            StopAllCoroutines();
            StartCoroutine(DisplayDiag());
            ready = false;
        }
    }

    public void ReadyForDialogue()
	{
        diagText.gameObject.SetActive(true);
        Debug.Log("sadsawdas");
        Cursor.lockState = CursorLockMode.Locked;
        yesOrNoButtons.SetActive(false);
        ready = true;
        StopAllCoroutines();
        StartCoroutine(DisplayDiag());
	}

    public IEnumerator DisplayDiag()
	{
        overworldHelp.SetActive(false);
        diagString = dialogue.Dequeue();

        if (diagString.Contains("QUEST-"))
        {
            string selection = diagString.Split('-')[1];
            Debug.Log(selection);
            yesOrNoButtons.SetActive(true);
            Cursor.lockState = CursorLockMode.Confined;
            FindObjectOfType<QuestManager>().GetQuestNumber(selection, this.gameObject);
        }
        else
        {
            textBox.SetActive(true);
            diagText.text = "";
            typing = true;
            foreach (char x in diagString)
            {
                if (typing)
                {
                    diagText.text = diagText.text + x.ToString();
                    Debug.Log(diagText.text);
                    yield return new WaitForSeconds(0.1f);
                }
            }
        }
	}

    public void Empty()
	{
        dialogue.Clear();
        Cursor.lockState = CursorLockMode.Locked;
        yesOrNoButtons.SetActive(false);
        diagText.text = "";
    }
}
