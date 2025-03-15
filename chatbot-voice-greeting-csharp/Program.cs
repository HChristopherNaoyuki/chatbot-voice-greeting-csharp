using System;
using System.IO;
using System.Media;

namespace chatbot_voice_greeting_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display a message in the console (using Cyan color for normal info)
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Cybersecurity Awareness Bot.");

            // Call the function to play the voice greeting
            PlayVoiceGreeting();

            // Keep the console open until the user presses a key
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Press any key to exit.");
            Console.ResetColor();
            Console.ReadKey();
        }

        /// <summary>
        /// Plays a pre-recorded voice greeting from a WAV file.
        /// </summary>
        static void PlayVoiceGreeting()
        {
            try
            {
                // Get the base directory of the application
                var basePath = AppDomain.CurrentDomain.BaseDirectory;

                // Combine the base directory with the relative path to the audio file
                string relativePath = Path.Combine("Audio", "welcome.wav");

                // Get the absolute path by resolving the relative path
                string audioPath = Path.GetFullPath(Path.Combine(basePath, relativePath));

                // Check if the file exists at the resolved path
                if (File.Exists(audioPath))
                {
                    // Load and play the WAV file (use Green for success)
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Playing voice greeting...");
                    Console.ResetColor();

                    SoundPlayer player = new SoundPlayer(audioPath);
                    player.PlaySync(); // Play synchronously
                }
                else
                {
                    // Display an error in Red if the file is not found
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Audio file not found at: " + audioPath);
                    Console.ResetColor();
                }
            }
            catch (Exception ex)
            {
                // Display the error message in Red for exceptions
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error playing voice greeting: " + ex.Message);
                Console.ResetColor();
            }
        }
    }
}
