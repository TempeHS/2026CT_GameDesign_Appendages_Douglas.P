using UnityEngine;


public class Item_Collector : MonoBehaviour
{
    public GameObject bone;
    public GameObject hand;
    public GameObject heart;
    public GameObject brain;
    public GameObject eyeball;
    public GameObject foot;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    bone.SetActive(false);
    hand.SetActive(false);
    heart.SetActive(false);
    brain.SetActive(false);
    eyeball.SetActive(false);
    foot.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("bone"))
    {
        Destroy(collision.gameObject);
        bone.SetActive(true);
    }
        if (collision.gameObject.CompareTag("hand"))
    {
        Destroy(collision.gameObject);
        hand.SetActive(true);
    }
        if (collision.gameObject.CompareTag("heart"))
    {
        Destroy(collision.gameObject);
        heart.SetActive(true);
    }
        if (collision.gameObject.CompareTag("brain"))
    {
        Destroy(collision.gameObject);
        brain.SetActive(true);
    }
        if (collision.gameObject.CompareTag("eyeball"))
    {
        Destroy(collision.gameObject);
        eyeball.SetActive(true);
    }
        if (collision.gameObject.CompareTag("foot"))
    {
        Destroy(collision.gameObject);
        foot.SetActive(true);
    }
    
    }

    
}
