using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lennycontroller : CharacterObject
{
    public Animator anim;
    private Stack<string> animationStack = new Stack<string>(); 
    private bool animPlaying;
    private bool animationStarted;
    public float momentum;
    public float frontForce;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        var m_CurrentClipInfo = anim.GetCurrentAnimatorClipInfo(0);
        if (Input.GetKeyDown("space"))
        {
            PunchCombo();
           
        }
        print(m_CurrentClipInfo[0].clip.name);
        if (m_CurrentClipInfo[0].clip.name.Equals("fightingidle") || anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1)
        {
            //Do something when animator isn't playing
            //play the next element in the stack
            //if none go back to Idle
            print(this.animationStack.Count);
            if (!m_CurrentClipInfo[0].clip.name.Equals("fightingidle"))
            {
                animationStarted = true;
            }
            if (this.animationStack.Count > 0)
            {
                anim.SetTrigger(animationStack.Pop());
            }
            else
            {
                if (animPlaying && animationStarted)
                {
                    anim.SetTrigger("idle");
                    animPlaying = false;
                    animationStarted = false;
                }
              
            }
            
        }
    }

    public void increaseMomentum(int i)
    {
        if(momentum == 0)
        {
            momentum = i;
        }
        else
        {
            momentum = momentum * i;
        }
    }

    public Vector3 getFrontVector()
    {
        Quaternion rotation = (this.transform.rotation);
    

        var forward = Vector3.forward;  // fairly common

        var result = rotation  * forward;
        return result;

    }

    void PunchCombo()
    {
        this.GetComponent<Rigidbody>().AddForce(frontForce*getFrontVector());
        animationStack.Push("punchCombo");
        animPlaying = true;

    }

    void LeftTurn()
    {

    }

    void RightTurn()
    {

    }

    void LeftShove()
    {


    }

    void RightShove()
    {

    }

}
