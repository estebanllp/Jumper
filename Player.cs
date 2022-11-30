class Player {
    WordList wordList = new WordList();
    Display display = new Display();
    
    //stores guess from player
    public string guessLetter() 
        {
            Console.WriteLine("Guess a letter [a-z]: ");
            string letter = Console.ReadLine();
            return letter;
        }     
    
    //deducts life if guess is incorrect
    public int loseLife(int lives) 
        {
            return lives = lives - 1;
        }
    //check letter
    public bool letterInWord(string word, string letter) 
        {
            return word.Contains(letter);
        }    



}




