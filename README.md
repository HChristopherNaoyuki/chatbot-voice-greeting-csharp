# Chatbot Voice Greeting Demo (C#)

This is a simple C# console application that demonstrates how to play a voice greeting using a WAV file. The program is designed to simulate the initialization of a chatbot, display a message in the console, and play a pre-recorded voice greeting. If the audio file is not found or an error occurs, the program displays an appropriate error message.

## Features
- **Console Output:** Displays messages with different colors (Cyan for normal info, Green for success, and Red for errors).
- **Voice Greeting:** Plays a pre-recorded voice greeting from a WAV file using the `SoundPlayer` class.
- **Error Handling:** Provides feedback in case of missing audio files or errors during playback.

## Requirements
- **.NET Framework:** This application requires the .NET Framework (tested with .NET Core 3.1 or later).
- **WAV File:** A `.wav` file named `welcome.wav` should be placed in an `Audio` folder in the project directory.

## How to Use
1. **Clone the repository or download the source code** to your local machine.
2. **Create a folder** named `Audio` in the root of your project directory.
3. Place the **`welcome.wav`** file inside the `Audio` folder. This will be the voice greeting that the program will play.
4. Open a command prompt or terminal window and navigate to the project directory.
5. Build and run the project using the following command:
   ```bash
   dotnet run
   ```
6. The program will output a message to the console indicating that the chatbot is initializing and will then play the voice greeting.
7. Press any key to exit the program when prompted.

## File Structure
```
chatbot_voice_greeting_csharp/
│
├── Audio/
│   └── welcome.wav      # Voice greeting audio file
├── Program.cs           # C# program source code
├── chatbot_voice_greeting_csharp.csproj  # Project file
└── README.md            # This readme file
```

## Code Explanation

### Main Program

- The program initializes by printing a welcome message to the console in **cyan**.
- It then calls the method `PlayVoiceGreeting()` to attempt to play the voice greeting.
- If the greeting is successfully played, a message is printed in **green**.
- If an error occurs, an appropriate error message is displayed in **red**.

### PlayVoiceGreeting Method

- **Path Resolution:** The method computes the absolute path of the `welcome.wav` file by combining the base directory with the relative path to the `Audio` folder.
- **File Check:** It checks whether the file exists at the resolved path. If it exists, it plays the file using `SoundPlayer`. If not, it prints an error message.
- **Error Handling:** Any exceptions that occur during playback are caught and displayed in **red**.

## Error Handling
- If the `welcome.wav` file is missing or cannot be found, an error message will appear in the console with the path where it was expected.
- If there is any issue with playing the audio, the error message will indicate the specific problem.

## Example Output

When the program is running successfully:
```
Initializing Cybersecurity Awareness Bot...
Playing voice greeting...
Press any key to exit...
```

If the audio file is missing or not found:
```
Initializing Cybersecurity Awareness Bot...
Audio file not found at: C:\Path\To\Project\Audio\welcome.wav
Press any key to exit...
```

In case of an error during playback:
```
Initializing Cybersecurity Awareness Bot...
Error playing voice greeting: The specified file could not be played.
Press any key to exit...
```

## Troubleshooting
- Ensure the `welcome.wav` file is placed correctly in the `Audio` folder.
- Make sure the file path is correct and the program has permission to access the folder.

---
