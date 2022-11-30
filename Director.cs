class Director {

    WordList wordList = new WordList(); 
    Player player = new Player();
    Display display = new Display();

     
    public void beginGame() 
    {
        int lives = 5;
        bool gameOver = false;
        string letter = "";     
        int charactersLeft = 0;
        var lettersGuessed = new List<string>();


        string word = wordList.GetWord();

        Dictionary<string, string> parachute = display.buildParachute();
        Dictionary<string, string> jumper = display.buildJumper();
        display.updateFigure(parachute, jumper, lives);

        //while bool game over is false, it will execute this code, will also check for how many characters are left to be guessed.
        while(gameOver == false) 
        {

            letter = player.guessLetter();  
            lettersGuessed.Add(letter);
            display.updateFigure(parachute, jumper, lives);
            charactersLeft = display.displayWord(word, lettersGuessed, charactersLeft);
            bool letterInWord = player.letterInWord(word, letter);
            Console.WriteLine(@" ");

            if (charactersLeft ==  0) 
            {
                Console.WriteLine($"Congratulations, you saved the jumper");
                gameOver = true;
                break;
            }
            // if guess is not a character in the random word, then will deduct a live, game starts with 5 lives.
            if (letterInWord == false) 
            {
                lives = player.loseLife(lives);
            }

            if (lives == 0) 
            {
                Console.WriteLine(@" ");
                display.updateFigure(parachute, jumper, lives);
                Console.WriteLine($"Game over, the jumper died");
                gameOver = true;
            }            
        }
    }
}
