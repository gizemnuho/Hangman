# 🎯 Hangman - Word Guessing Game (C# Console Application)

This project is a simple **Hangman** game written in C#. The user tries to guess a hidden word one letter at a time. Each wrong guess reduces the number of lives. The game ends after 7 wrong guesses or when the word is completely guessed.

---

## 🚀 How It Works

- The hidden word (e.g., `hello`) is not shown at the start.
- The user inputs letter guesses.
- Correct guesses reveal the letter(s) in the word.
- Incorrect guesses decrease the remaining lives.
- After 7 incorrect guesses, the game ends and the user loses.
- If all letters are guessed correctly before lives run out, the user wins.

---

## 🧠 Key Concepts Used

- Uses a `List<char>` to keep track of guessed letters.
- A `while` loop controls the game flow based on lives and win condition.
- Input validation ensures the user can’t guess the same letter twice.
- Handles division of lives and displays current progress with underscores.

---

## 🎮 How to Play

1. Run the program.
2. Enter letter guesses one by one.
3. Try to guess the entire word before you run out of lives.
4. Enjoy!

---

## 📂 How to Run

- Open the solution in Visual Studio or your preferred C# IDE.
- Build and run the project.
- Follow on-screen instructions.

---

## 📜 License

This project is open source and free to use.

---
