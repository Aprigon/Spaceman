class Game
   {
     private string codeword;
     private string currentWord;
     private int maximumGuesses;
     private int currentGuesses;
     private string[] codewordList;
     private Ufo ufo = new Ufo();

    public Game()
    {
      maximumGuesses = 5;
      currentGuesses = 0;
      currentWord = "";
      codewordList = new string[]{"galaxy", "abduction", "spacecraft", "secret", "gachapon", "test", "genchimpa" };
      Random r = new Random();
      codeword = codewordList[r.Next(codewordList.Length)];

      for(int i=0; i<codeword.Length;i++)
      {
        currentWord=currentWord+"_";
      }

 
    }

    public void greet()
    {
      Console.WriteLine("=================");
      Console.WriteLine("=======UFO=======");
      Console.WriteLine("=================");
      Console.WriteLine("Greetings human! You have to guess the word or you'll be absorbed!! >:c");
    }

    public bool didWin()
    {
      return codeword.Equals(currentWord);
    }

    public bool didLose()
    {
      return currentGuesses>= maximumGuesses;
    }

    public void display()
    {
      Console.WriteLine(ufo.Stringify());
      Console.WriteLine($"Current word: {currentWord}\n");
      Console.WriteLine($"Incorrect guesses: {currentGuesses}\n");
    }

     public void ask()
    {
      Console.Write("Enter a etter: ");
      string stringGuess = Console.ReadLine();
      Console.WriteLine();
      if (stringGuess.Trim().Length != 1)
      {
        Console.WriteLine("Do not enter more than one letter!");
        return;
      }
      char guess = stringGuess.Trim().ToCharArray()[0];
      if (codeword.Contains(guess))
      {
        Console.WriteLine($"'{guess}' is in the word!");
        for (int i = 0; i < codeword.Length; i++)
        {
          if (guess == codeword[i])
          {
            currentWord = currentWord.Remove(i, 1).Insert(i, guess.ToString());
          }
        }
      }
      else 
      {
        Console.WriteLine($"'{guess}' isn't in the word! The tractor beam pulls the person in further...");
        currentGuesses++;
        ufo.AddPart();
      }
    }

   }
}