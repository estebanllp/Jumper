class Display {
    WordList wordList = new WordList();

    public Dictionary<string, string> buildParachute() // self explanatory
    {
        Dictionary<string, string> parachute = new Dictionary<string, string>(4);

        parachute.Add("top",  "  ---- ");
        parachute.Add("mid2", @"/ ___ \");
        parachute.Add("mid1", @"\     /");
        parachute.Add("bottom", @" \   / "); 

        return parachute;
    }

    public Dictionary<string, string> buildJumper() // self explanatory
    {
        Dictionary<string, string> jumper = new Dictionary<string, string>(4);

        jumper.Add("head",  "   0   ");
        jumper.Add("torso", @"  /'\  ");
        jumper.Add("leags", @"  / \  ");
        return jumper;
    }

    //update figure will modify the parachute dictionary according to its key pair, and number of lives left. parachute and jumper will be printed separately with the for loop at the end.
    public void updateFigure(Dictionary<string, string> parachute, Dictionary<string, string> jumper, int lives) {
        if (lives == 5) 
        {
        } 
        else if (lives == 4) 
            {
                parachute.Remove("top");
            } 

        else if (lives == 3) 
            {
                parachute.Remove("mid1");
            } 
        else if (lives == 2) 
            {
                parachute.Remove("mid2");
            } 
        else if (lives == 1) 
            {
            parachute.Remove("bottom");
            } 
        else 
            {
                jumper["head"] = "   x   ";
            } 


        foreach (KeyValuePair<string, string> line in parachute) {
            Console.WriteLine(line.Value);
        }

        foreach (KeyValuePair<string, string> line in jumper) {
            Console.WriteLine(line.Value);
        }
    }

//displayWord will check if the letter guessed is a letter in the random word, if so, it will print the letter, if not, it will print an underscore.
    public int displayWord(string word, List<string> lettersGuessed, int charactersLeft) {
            charactersLeft = 0;
            foreach (var character in word) {
                var letter = character.ToString();

                if (lettersGuessed.Contains(letter)) {
                    Console.Write(letter);
                }
                else {
                    Console.Write("_");
                    charactersLeft= charactersLeft+1;
                }
            }
            Console.WriteLine(string.Empty);
            return charactersLeft;
        }


}