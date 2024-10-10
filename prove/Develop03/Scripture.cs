using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public string GetDisplayText()
    {
        string displayText = "";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText.Trim();
    }

    public bool HideRandomWords(int numberToHide)
    {
        Random rand = new Random();

        // Calculate the actual number of words to hide
        int wordsToHide = Math.Min(numberToHide, _words.Count);

        // Hide the specified number of words
        for (int i = 0; i < wordsToHide; i++)
        {
            int index = rand.Next(_words.Count);
            while (_words[index].IsHidden() || _words[index].GetText().Equals(" "))
            {
                index = rand.Next(_words.Count);
            }
            _words[index].Hide();
        }

        // Check if all words have been hidden and return the result
        return IsCompletelyHidden();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden() && !word.GetText().Equals(" "))
            {
                return false;
            }
        }
        return true;
    }
}
