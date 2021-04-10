using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class myhand : MonoBehaviour
{
    static public int com_count;
    static public int win_count;

    public AudioSource win_audio, loose_audio, start_audio;
    Animator anim;
    int idle = Animator.StringToHash("idle");
    int peace = Animator.StringToHash("peace");
    int fist = Animator.StringToHash("fist");


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.C))
        { // for電腦 : 0是布; 1是剪刀 ; 2是石頭

            anim.SetTrigger(idle); //激發索引值-布
            if (enemy.rand == 2)
            {
                win_count++;
                win_audio.Play();
            }

            else if (enemy.rand == 1)
            {
                //win_count--;
                com_count++; //電腦得分
                loose_audio.Play();

            }
                
        }
        else if (Input.GetKeyDown(KeyCode.Z)) //GetKeyDown 按一次觸發一次(短暫), GetKey(連續)希望產生一個連續的動作
        {

            anim.SetTrigger(peace); //激發索引值-剪刀
            if (enemy.rand == 0)
            {
                win_count++;
                win_audio.Play();
            }

            else if (enemy.rand == 2)
            {   
                //win_count--;
                com_count++; //電腦得分
                loose_audio.Play();

            }
                
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            anim.SetTrigger(fist); //激發索引值-石頭
            if (enemy.rand == 1)
            {
                win_count++;
                win_audio.Play();
            }
            else if (enemy.rand == 0)
            {
                //win_count--;
                com_count++; //電腦得分
                loose_audio.Play();

            }
                
        }
    }
}
