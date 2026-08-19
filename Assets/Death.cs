using UnityEngine;

public class Death : MonoBehaviour
{
    public GameObject death;
 
   void Start()
    {
    death.SetActive(false);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Dead()
    {
        death.SetActive(true);
        bool isAlive = false;
        // have code that stops you from moving
        // have code that waits
        // have code that ends everything
    }
}
