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
