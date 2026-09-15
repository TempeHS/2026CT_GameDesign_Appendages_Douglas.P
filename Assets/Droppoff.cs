using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Droppoff : MonoBehaviour
{
    public Item_Collector BPScript;
    private Item_Collector BP;
    public bool BoneCheck;
    public bool HandCheck;
    public bool HeartCheck;
    public bool BrainCheck;
    public bool EyeballCheck;
    public bool FootCheck;

    public GameObject boneCover;
    public GameObject handCover;
    public GameObject heartCover;
    public GameObject brainCover;
    public GameObject eyeballCover;
    public GameObject footCover;

    public GameObject Welcome;
    public GameObject NotEnough;
    public GameObject YIPPIE;

    public bool BoneValue;
    public bool HandValue;
    public bool HeartValue;
    public bool BrainValue;
    public bool EyeballValue;
    public bool FootValue;

    List<bool> mylist = new List<bool> {};
    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        BP = GetComponent<Item_Collector>();
            //hide those smiles
        boneCover.SetActive(false);
        handCover.SetActive(false);
        heartCover.SetActive(false);
        brainCover.SetActive(false);
        eyeballCover.SetActive(false);
        footCover.SetActive(false);
        NotEnough.SetActive(false);
        YIPPIE.SetActive(false);

    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //on collide with player check what things it has
        if (collision.CompareTag("Player"))
        {
            Welcome.SetActive(false);
            //mark those objects here
            BoneCheck = BPScript.Bone;
            HandCheck = BPScript.Hand;
            HeartCheck = BPScript.Heart;
            BrainCheck = BPScript.Brain;
            EyeballCheck = BPScript.Eyeball;
            FootCheck = BPScript.Foot;

            BoneValue = BoneCheck;
            HandValue = HandCheck;
            HeartValue = HeartCheck;
            BrainValue = BrainCheck;
            EyeballValue = EyeballCheck;
            FootValue = FootCheck;

            mylist.Add(BoneValue);
            mylist.Add(HandValue);
            mylist.Add(HeartValue);
            mylist.Add(BrainValue);
            mylist.Add(EyeballValue);
            mylist.Add(FootValue); 
            /* Debug.Log(BoneCheck);
             Debug.Log(HandCheck);
             Debug.Log(HeartCheck);
             Debug.Log(BrainCheck);
             Debug.Log(EyeballCheck);
             Debug.Log(FootCheck);   */

            // reveal smile for objects that have been found
            if (BoneCheck == true)
            {
                boneCover.SetActive(true);
            }
            if(HandCheck == true)
            {
                handCover.SetActive(true);
            }
            if(HeartCheck == true)
            {
                heartCover.SetActive(true);
            }
            if(BrainCheck == true)
            {
                brainCover.SetActive(true);
            }
            if(EyeballCheck == true)
            {
                eyeballCover.SetActive(true);
            }
            if(FootCheck == true)
            {
                footCover.SetActive(true);
            }

            string allValues = string.Join(", ", mylist);
            Debug.Log("Bool List: " + allValues);
            // if so DEBUG YOU WIN


            bool allAreTrue = mylist.TrueForAll(x => x);

            if (allAreTrue)
            {
                Debug.Log("All conditions met!");
                YIPPIE.SetActive(true);
                //animation trigger
                //waiitttttt
                SceneManager.LoadScene("LevelTwo");
            }
            else
            {
                NotEnough.SetActive(true);
                YIPPIE.SetActive(false);
                Debug.Log("Not all conditions met.");
                //reveal other sign
                //animation trigger
            }



            mylist.Clear();           
        }
    }
}