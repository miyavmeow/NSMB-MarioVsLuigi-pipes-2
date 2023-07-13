using UnityEngine;
using UnityEngine.UI;

public class RandomText1 : MonoBehaviour
{
    public string[] words = { "Click to Continue...", "Stop playing pipes", "Jungle staring contest", "Cubby stop kicking the rocks", "Whats a Toasted v1??", "Try enabling debug mode!", "Remember, you cant leave 2 certain maps in debug mode", "Jungle staring contest", "Go ahead, see if you can find the Classy Pipe", "Earth 2: Earth Forever", "Praise the people in credits :)", "Jaosiwne seqer", "make it a toggle", "ð", "the", "Also check out: Cubby's Character Mod", "Also check out: Steven's Character Mod", "Also check out: Vic's Custom Match-inator", "Wario 2024!", "Ok, Yes Im Suggesting A COMPLETELY Different Game", "Pizza Tower is my favorite gamezing!", };
    public Text text;

    private void Start()
    {
        string wordToDisplay = RandomWord();

        text.text = wordToDisplay;
    }

    private string RandomWord()
    {
        string randomWord = words[Random.Range(0, words.Length)];

        return randomWord;
    }

}