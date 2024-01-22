# Gen2Emu
A Command & Conquer emulator to preserve the alpha client of the game for future generations.

## Why?
I bought the first decade collection especially for this CnC games, as i already owned all of the titles it contained.
I was disappointed to find out that the online servers were shut down when i found the time to finally play this.
Sadly there is no official way to play this game, so i had the client on my disk for ages in the hope someone would write a proper emulator one day.
Just recently i stumbled across someone finally bypassing the origin activation screen, so i directly started to work.

There was already someone working on this (Xevrac), and i took a quick look on that project firsthand.
As of writing, his current state is barely anything further than mine.
Sadly the used techstack (.NET Framework 4.6, Windows-only UI), being just a copy&paste from a battlefield emulator, and the code quality did definitely not reflect my vision.
So instead of somewhat taking over or forking his project to completely overhaul his codebase, i decided to start from scratch and do my own researches.
This seems the fairest approach from my side, as im not planning to steal anyones work, nor do i want to be first or ahead.
Im working on game preservation purely for the fun of doing it.

I have no idea if this will ever be finished, as i have too many projects running already, but i will try my best to get this working.

## To make this work you need the following:
- A copy of the game with version 150805 (see Info_Win32_final.BuildSettings file contents)
- A Patched (no-origin) executable, otherwise the game will fail to start at all
- Run the ClientPatcher to re-target the game to the new server instead of the defunct one

## What must be done:
- a new main menu must be made to get the game to do anything
- figure out how to launch a simple game, by using the right javascript calls
- the game protocol itself (blaze) uses another socket. Upon reaching that point, that must be properly emulated too

## Special thanks:
- Xevrac for sharing some insights on how to get the game to start.

## Legal information
Ofcourse, this project is not affiliated with EA in any way!
Im not trying to steal anyones work, and i will not publish any of the original game files.
You need to own a copy of the game files to make this work, and you need to find a patched executable yourself.
I will not provide any help on how to do this, as this is not the purpose of this project.
