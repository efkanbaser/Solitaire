using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    public GameObject highScorePanel;
    public Selectable[] topStacks;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (HasWon())
        {
            Win();
        }
    }

    public bool HasWon()
    {
        int i = 0;
        foreach (Selectable topStack in topStacks)
        {
            i += topStack.value;           
        }
        if (i >= 52)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    void Win()
    {
        highScorePanel.SetActive(true);
        print("You have won!");
    }
}
