# POSE-FizzBuzz

## Task 

Write a C# program "FizzBuzz" that counts from 1 to 100 using a loop of your 
choice and prints the output on one line according to the "Fizz-Buzz" rules
(as described above). The model should be the output shown in the following
illustration!

## Description

Fizz-Buzz is a group game for children to practice division arithmetic. For
example, the players have to sit in a circle and count them step by step.
- The first player starts with the number 1. (He says: “One”.)
- The next player to the right says “two”.
- And so forth.

The following must be taken into account:
- If the number is divisible by 3, it is called “Fizz”.
(So instead of 3, 6, 9, ... you say “Fizz”.)
- If the number is divisible by 5, it is called “buzz”.
(So instead of 5, 10, ... you say “Buzz”.)
- If the number is divisible by 5 and 3, we say “Fizz” and “Buzz”.
(So instead of: 15, 30, 45, ... you say “Fizz Buzz”.)
- Otherwise you say the number itself.
- Then it is the next player's turn. This goes on in circles until someone
makes a mistake. (An error should not occur in the program!)

The players' spoken word line would therefore be without errors:
```bash
1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14, Fizz Buzz, 16, 17, Fizz, 19, Buzz,
Fizz, 22, 23, Fizz, Buzz, 26, Fizz, 28, 29, Fizz Buzz, 31, 32, Fizz, 34, Buzz, Fizz, …
```
