using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 2;
    private int currentHealth;

    [SerializeField] private GameObject uiElement1;
    [SerializeField] private GameObject uiElement2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = maxHealth;
    }

    void Update()
    {
        if (Input.GetKeyDown("h"))
        {
            currentHealth ++;
             Debug.Log("health increased");
        }
    
        if (Input.GetKeyDown("l"))
        {
            currentHealth -= 1;
             Debug.Log("health decreased");
        }
        if (currentHealth > 2) currentHealth = 2;
        if (currentHealth < 0) currentHealth = 0;
        Debug.Log(currentHealth);
    }

    
 
}
