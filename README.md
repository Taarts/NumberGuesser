#P
Children's game "Think of a number..."
Guess the number the player is thinking of. 1 - 1024
the user should not reveal the number
the user will be truthful with their answers
they can give the input Y/N, H/L

## If guess is HIGH (516), we use the Guess (516) and add the ## previousLOW (512) and divide by 2. ← algorithm 

## If guess is LOW (514), we use the guess (514) and add the ## previous HIGH (516) and divide by 2. ← algorithm

#Example: 
Guess: 610
Computer: 512?
H
Computer: 768?
L
C: (768/2) = 384?
H
576?
H
608?
H
624
L
616
L
618

Data Structures:
Instructions for user
Boolean if/else

# NumberGuesser
(Divide & conquer algorithm)
#Presentation
Min = 1
Max = 1024

- Hello I'm great at guessing numbers
  #request
- Give me a number between 1 - 1024
  min = 1
  max = 1024
- Don't tell me the number, Let me guess!
  #Guess
- Is your number {Guess}?
  #Confirm
  Did they type something else?
  # Y/N
      Else #Confirm
      GOTO #END
  # N:
  #Filter
  - Is your number Higher or Lower
  # H/L
    **Did they type something else?
    **GOTO #END
    IF H
    # Guess;
    LowGuess = (Guess + previousHigh) / 2

    - Is your number {NewGuess}?

    Else
    #GUESS 
    HighGuess = (Guess + previousLow) / 2

  - Is your number NewGuess?
      GoTO #Guess
    
      Else Y:
- Excellent! It's great to be correct!
- Wanna play again?
  If Y
  GOTO #Request
  If N
- OK thanks for playing, Goodbye!
  #END
- That's not what I asked for, I'm not playing anymore.
