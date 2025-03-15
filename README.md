# Chatbot Voice Greeting C# Application

## Overview
This C# console application simulates a basic chatbot greeting the user with both a textual message and a pre-recorded voice greeting. It is a simple demonstration of how to play audio files in a C# application while also handling errors related to missing or inaccessible files. The application includes an easy-to-understand structure, allowing you to modify it for more complex scenarios.

## Features
- Displays a welcome message in the console.
- Plays a pre-recorded WAV audio file (`welcome.wav`) as a voice greeting.
- Error handling for missing or inaccessible audio files.
- The ability to customize the audio file path and greeting message.

## Requirements
- .NET Framework or .NET Core (The project uses basic C# functionality, so it should be compatible with both).
- A valid `welcome.wav` file located in the `Audio` directory of the project.

## File Structure
```
/chatbot_voice_greeting_csharp
│
├── Audio
│   └── welcome.wav  (Your pre-recorded voice greeting file)
│
└── Program.cs  (The main application file)
```

## How to Run
1. **Clone or Download** the project to your local machine.
2. Make sure you have a valid `.wav` file, named `welcome.wav`, located in the `Audio` folder inside the project directory.
3. Open the project in your C# IDE (such as Visual Studio or Visual Studio Code).
4. Build and run the project.
5. The program will display a welcome message in the console and play the audio greeting (if the `welcome.wav` file is found).
6. If the audio file is missing, it will display an error message indicating the file path.
7. The console will stay open until the user presses any key to exit.

## Key Points
- **Console Colors:** 
  - **Cyan** is used for informational messages.
  - **Green** is used for successful events like playing the greeting.
  - **Red** is used for error messages (e.g., file not found or an exception).

- **Audio Playback:** The audio is played using the `System.Media.SoundPlayer` class. It synchronously plays the audio file from the specified location.

- **Error Handling:** The application checks if the file exists before attempting to play it. If there is an issue (like a missing file), it will print an error message.

## Troubleshooting
- **Error:** `"Audio file not found"`
  - **Solution:** Ensure the `welcome.wav` file is located in the `Audio` folder in the root directory of the project.

- **Error:** `"Error playing voice greeting: [Exception Details]"`
  - **Solution:** Check if the WAV file is valid and not corrupted. Ensure the file is accessible and the correct permissions are set.

## Example Output
```
Cybersecurity Awareness Bot.
Playing voice greeting...
Press any key to exit.
```

If the `welcome.wav` file is missing or cannot be played:
```
Cybersecurity Awareness Bot.
Audio file not found at: C:\path\to\your\project\Audio\welcome.wav
Press any key to exit.
```

---
