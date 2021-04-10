using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{

    static public int rand;
    Animator hand;
    int idle = Animator.StringToHash("idle");
    int peace = Animator.StringToHash("peace");
    int fist = Animator.StringToHash("fist");


    // Start is called before the first frame update
    void Start()
    {
        hand = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        rand = Random.Range(0, 3);
        if (Input.GetKeyDown(KeyCode.Z) | Input.GetKeyDown(KeyCode.X) | Input.GetKeyDown(KeyCode.C))
        {
            switch (rand)
            {
                case 0:
                    hand.SetTrigger(idle);
                    break;
                case 1:
                    hand.SetTrigger(peace);
                    break;
                case 2:
                    hand.SetTrigger(fist);
                    break;
            }
        }
    }
}
