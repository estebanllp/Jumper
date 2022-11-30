class WordList {
    private Random generator = new Random();

    private List<string> words = new List<string> 
        {
        "january", "february", "march", "april", 
        "may", "june", "july", "august", 
        "september", "october", "november","december"
        };
    


    public string GetWord() 
        {
            int randomIndex = generator.Next(words.Count);
            string randomWord = words[randomIndex];
            words.RemoveAt(randomIndex);
            return randomWord;
        }    

    public int getLength(string randomWord) 
        {
            int length = randomWord.Length;
            return length;
        }
    }