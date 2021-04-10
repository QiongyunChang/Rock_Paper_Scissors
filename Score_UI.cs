using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score_UI : MonoBehaviour
{
    Text text;
    Text com_text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = myhand.com_count.ToString() + "    (enemy score)  vs   " + myhand.win_count.ToString() + "  (your score)";

    }
}
