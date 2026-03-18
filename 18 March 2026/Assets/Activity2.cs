using UnityEngine;

public class Activity2 : MonoBehaviour
{
    string[] names = { "Mario", "Luigi", "and Toad"};
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 2; i++)
        {
            Debug.Log(names[0]);
        }
    }
}
