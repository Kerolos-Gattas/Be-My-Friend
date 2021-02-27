using UnityEngine;

public class MCsSelection : MonoBehaviour
{
    private SpriteRenderer[] characters;

    private void Awake()
    {
        int characterCount = transform.childCount;
        characters = new SpriteRenderer[characterCount];
        for (int i = 0; i < characterCount; i++)
        {
            characters[i] = transform.GetChild(i).GetComponent<SpriteRenderer>();
        }
    }

    private void Start()
    {
        this.selectCharacter(0, -1);
    }

    public void selectCharacter(int currentIndex, int prevIndex)
    {
        if (prevIndex != -1)
        {
            characters[prevIndex].color = Color.white;
        }
        else
        {
            foreach (SpriteRenderer character in characters)
            {
                character.color = Color.white;
            }
        }
        characters[currentIndex].color = Color.green;
    }
}
