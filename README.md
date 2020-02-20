# Table of contents
* [General description](#general-description)
* [Scope of functionalities](#scope-of-functionalities)
* [Screenshots](#screenshots)
* [Technologies](#technologies)
* [Inspiration](#inspiration)
* [Things To Do](#things-to-do)

# General description

Simple application that allows user to download any video from Youtube service in every desired quality and three available extensions - .mp3, .mp4, .webm. YoutubeDownloader is connected with MSSQL database which is hosted on Microsoft Azure.

# Scope of functionalities

* Save files wherever you want on your PC
* Download in desired quality and extension
* Proceed many downloads at one time
* History view of downloaded files

# Screenshots

![Scr1](https://i.ibb.co/w6741vm/mainwindow.png)
![Scr2](https://i.ibb.co/X2y1STM/dwnld.png)
![Scr3](https://i.ibb.co/k4rQ1HL/downloadinprogress.png)

# Technologies

### Languages:
* C#

### Environments:
* Visual Studio
* SQL Server Management Studio (SSMS)
* Microsoft Azure

### External libraries:
* MaterialSkin 0.2.2 by Ignace Maes
* Newtonsoft.Json 12.0.3 by James Newton-King
* Youtube Explode 4.7.13 by Tyrrrz
* YoutubeExplode.Converter 1.4.3 by Tyrrrz

# Inspiration

Application is not an innovation - I know that this kind of apps can be easily found everywhere. I made it with educational purposes only.

### Here's what I learned from it:
* Invoke method which is necessary to access controls from level of another thread
* Better operate with EventHandlers and LINQ
* Use of program memory to save data
* Creating asynchronous methods which doesn't block the UI
* Better code organization
* Paying attention to the use of the DRY pattern


# Things To Do
* Enhance code organization
* Consider another app design
* Optimize FFMpeg.exe process CPU usage
* Connect application to database established on Azure service
* Launch application
