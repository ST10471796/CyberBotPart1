# Cybersecurity Awareness Chatbot - Part 1

## Overview
A console-based chatbot that educates users about cybersecurity through voice and text interaction.

## Features
- Voice greeting (WAV file)
- ASCII art logo
- Personalized responses using user's name
- Keyword recognition for cybersecurity topics
- Random responses using arrays
- Input validation and error handling
- Colorful console UI

## Topics Covered
- Password safety
- Phishing scams
- Privacy protection
- Safe browsing

## How to Run
1. Open in Visual Studio
2. Press F5 to run
3. Make sure greeting.wav is in the Resources folder

## Commands
| Command | Description |
|---------|-------------|
| help | Show help menu |
| passwords | Get password tips |
| phishing | Get phishing tips |
| privacy | Get privacy tips |
| another tip | Get more advice |
| exit | Quit the bot |

## CI Status
![CI Build](https://github.com/YOUR_USERNAME/CyberBotPart1/actions/workflows/build.yml/badge.svg)

## File Structure
- `Program.cs` - Main program logic
- `ResponseManager.cs` - Response methods and tips
- `AudioManager.cs` - Voice greeting handling
- `Resources/greeting.wav` - Voice greeting audio

- ## References

[1] H. Pieterse, “The Cyber Threat Landscape in South Africa: A 10-Year Review,” *The African Journal of Information and Communication*, no. 28, pp. 1–21, 2021. Accessed: Apr. 15, 2026. [Online]. Available: https://doi.org/10.23962/10539/32213

[2] Microsoft, “SoundPlayer Class (System.Media),” *Microsoft Learn*. Accessed: Apr. 15, 2026. [Online]. Available: https://learn.microsoft.com/en-us/dotnet/api/system.media.soundplayer

[3] Microsoft, “SoundPlayer.PlaySync Method (System.Media),” *Microsoft Learn*. Accessed: Apr. 15, 2026. [Online]. Available: https://learn.microsoft.com/en-us/dotnet/api/system.media.soundplayer.playsync

[4] Microsoft, “SpeechSynthesizer Class (System.Speech.Synthesis),” *Microsoft Learn*. Accessed: Apr. 15, 2026. [Online]. Available: https://learn.microsoft.com/en-us/dotnet/api/system.speech.synthesis.speechsynthesizer

[5] Microsoft, “Console.Beep Method (System),” *Microsoft Learn*. Accessed: Apr. 15, 2026. [Online]. Available: https://learn.microsoft.com/en-us/dotnet/api/system.console.beep

[6] Institute of Electrical and Electronics Engineers, *IEEE Reference Guide*, IEEE, Piscataway, NJ, USA, 2024. [Online]. Available: https://ieeeauthorcenter.ieee.org/wp-content/uploads/IEEE-Reference-Guide.pdf
