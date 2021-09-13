# MarsRover

A simple program that was done for a technical task challenge. 

# Requierments 

The task is to create a program that controls a "rover" that is exploring a 100 by 100 grid. Each grid is numbered between 1 and 10,000.
The rover needs to take up to 5 commands from the user and execute them. The rover starts in position 1 and is facing south. 
The user is able to give the rover 3 different commands those are: 
Left, Right and a command that tells the rover to move in the direction it is facing for a specific amount of meters. 
For example those 5 commands: 
1.	50m
2.	Left
3.	23m
4.	Left
5.	4m

The rover would report back that it is in position 4,624 north.
The next set of commands would then continue off the previous location and this would continue for as long as the user wants.
The rover is not allowed to venture outside of the 100 by 100 grid and should be stoped if it tried to. 

# Implementation 

Three classes were created, the first one is the initial "program" class that is made with every project in VS. 
This class would handle the input side and the data management between the 2 other classes.
Instance of both the 2 other classes are called and are passed around. The grid is also initialised and is populated by numbers ranging from 1 to 10,000. 
This is done with a nested for loop. The data is also processed here, first, the data is checked if it contains 
the keyword "left" or "right" and if they do they go through a switch statement to send them to the correct method in roverComand class
If the character "m" is detected then that data will be sent to the move method in the roverComand class. 

The rover class contains the X location, Y location and the direction the rover is facing, in the beginning of the program the rover is located in 0, 0 and is facing south.
The class also contain getters and setters for those values and allow the program to access those variable to change. 
Those variables are also the initial variables used with the turnLeft, turnRight and move methods in roverCommand. 

The roverCommand class contains 3 methods each designed to perform one of the designated commands that the user can give to the rover. 
The simpler ones are the turnLeft and turnRight methods which use the initial direction of the rover to calculate which direction the rover will be facing afterwards. 
This is done also with the help of the direction enum which keeps track of the directions and allows the changing of them. 
The next method is the more complicated one, it is used to move the rover to the specified amount the user requires. 
The method uses a try-catch statement to make sure that the rover does not go outside the designated 100by100 area. 
The rover uses the X and Y axis within the Rover class and the variable dis which is the initial movement string variable converted to an int. 
Depending on which direction the rover is facing the switch case will either increase or decrease the X or Y axis of the rover based on the distance given.
