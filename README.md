C# Number Guessing Game 🎯

A simple and interactive console-based number guessing game written in C#. The application picks a random number within a user-defined range, and you have to guide the program to guess your chosen number by answering "yes", "no", or "equal" prompts.

📝 Table of Contents

Features

Prerequisites

Getting Started

Usage

Game Flow

Contributing

License

Contact

🚀 Features

Dynamic Range: Set custom minimum and maximum values before starting the game.

Input Validation: Ensures only valid integer inputs for ranges.

Intuitive Prompts: Program asks if the secret number is bigger, smaller, or equal to its guess.

Error Handling: Graceful handling of invalid responses and exhausted ranges.

🔧 Prerequisites

.NET SDK 6.0+

A code editor or IDE (e.g., Visual Studio, Visual Studio Code)

📥 Getting Started

Clone the repository:

git clone https://github.com/<your-username>/<your-repo-name>.git
cd <your-repo-name>

Build and run:

dotnet build
dotnet run

🎮 Usage

Run the application using dotnet run.

When prompted, enter the Minimum number and press Enter.

Enter the Maximum number and press Enter.

Think of a number within this range.

Respond to the program’s guesses:

Type yes if your number is bigger.

Type no if your number is smaller or equal.

Type equal (or done) when the program guesses correctly.

🔄 Game Flow

Initialize Range: User inputs min and max values.

Guess Loop:

Program generates a random guess between min and max - 1.

Program displays: “Is your number bigger than guess?”

User responds with yes, no, or equal

Program updates the range accordingly:

yes: min = guess + 1

no: max = guess

equal: game ends with a success message.

Validation:

If min >= max, the game detects an invalid state and prompts that the range is exhausted.

🤝 Contributing

Contributions are welcome! To contribute:

Fork the repository.

Create a new branch: git checkout -b feature/YourFeatureName.

Commit your changes: git commit -m "Add YourFeatureName".

Push to the branch: git push origin feature/YourFeatureName.

Open a Pull Request detailing your changes.
