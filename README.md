# About the project (Teltonika-task) 

An application that allows user to input two different IPv4 addresses and get return the number of addresses between them (including the first one, excluding the last one). All inputs must be valid IPv4 addresses in the form of strings. The last address must be greater than the first one. This program works as linux terminam program, no linux or external modules/libraries/functions are used.

### Examples:

• “10.0.0.0” “10.0.0.50” => 50

• “10.0.0.0” “10.0.1.0” => 256

• “20.0.0.10” “20.0.1.0” => 246

### Built with:

Application was built with C#.

## Getting started
This is an example of how you may give instructions on setting up your project locally. To get a local copy up and running follow these simple example steps.

1. Download the project to your local environment.
2. Open TeltonikaBackEndTask folder and find TeltonikaBackEndTask.sln file and open it.
3. Compile the code like this ![Instruction](https://user-images.githubusercontent.com/60816697/189891193-1ea9f85f-7fec-438a-8ef9-000c468c2ce8.png "Code compilation")
4. Enter mentioned IPv4 addresses in example section.
5. After first compilation you can access this code by terminal.

## Usage
Firstly we have to access Publish folder, which is in this path: TeltonikaBackEndTask\bin\Release\net6.0

1. In path field type `cmd` to open up terminal. It should look like this (picture below)
![CmdCompile](https://user-images.githubusercontent.com/60816697/189892084-fd254191-d5c8-4ac5-b045-9bd4be0b6a16.png)

2. Now type `TeltonikaBackEndTask.exe` and press "Enter" (_step corresponds to number 1 in the picture_). 
Or you can run the app by using the dotnet command: Enter `dotnet TeltonikaBackEndTask.dll` and press Enter (_step corresponds to number 4 in the picture_).
![Cmd](https://user-images.githubusercontent.com/60816697/189896124-f336be37-2554-46d6-adbf-3b5516b93a20.png)

3. After this you can input two IPv4 addresses into the application (_first address (2) should not be greater than second one (3)_).

For example:

• First input: “10.0.0.0”

• Second input: “10.0.0.50”

• Expected result: 50.

