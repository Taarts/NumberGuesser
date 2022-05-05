# NumberGuesser

#Presentation
Min = 1
Max = 1024

- Hello I'm great at guessing numbers
  #request
- Give me a number between 1 - 1024
  min = 1
  max = 1024
  first guess
- Don't tell me the number, Let me guess!
  #Guess
- Is your number {Guess}?
  #Confirm
  Did they type something else?
  #Y_N
  Else #Confirm
  GOTO #END
  If N:
  #Filter

  - Is your number Higher or Lower
  - Type "H" or "L"
    **Did they type something else?
    **GOTO #END
    IF H
    #Guess = min;
    NewGuess = (min / 2) + min

    - Is your number {NewGuess}?

    Else if L
    #GUESS = Max
    NewGuess = max / 2

    - Is your number NewGuess?
      GoTO #Guess
      Else
      If Y:

- Excellent! It's great to be correct!
- Wanna play again?
  If Y
  GOTO #Request
  If N
- OK thanks for playing, Goodbye!
  #END
- That's not what I asked for, I'm not playing anymore.
