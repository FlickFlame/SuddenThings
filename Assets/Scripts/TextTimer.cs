using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextTimer : MonoBehaviour
{
    public Text textArea;
    public string[] paragraphs;
    public float waitLetter = 0.2f;
    public float waitParagraph = 2f;

    void Start()
    {
        StartCoroutine(Move());
    }

    IEnumerator Move()
    {
        foreach (string paragraph in paragraphs)
        {
            
            for (int i = 0; i < paragraph.Length; i++)
            {
                textArea.text = paragraph.Substring(0, i);
                // tocar som de tecla
                yield return new WaitForSeconds(waitLetter);
            }
            yield return new WaitForSeconds(waitParagraph);
        }
        NavigationManager.instance.LoadScene("TimeLine");
    }
}
