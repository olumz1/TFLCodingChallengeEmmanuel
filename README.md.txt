# Project Title
TFL RoadApi to determine live road status

## Getting started
Project was built on Visual studio 2019

Unzip the TFL folder for access to the solution
Load TFLCodingChallengeEmmanuel.sln solution in Visual studio 2019 to reveal four individual projects

```
TFLCodingChallengeEmmanuel.API.Feature
TFLCodingChallengeEmmanuel.Console
TFLCodingChallengeEmmanuel.Server
TFLCodingChallengeEmmanuel.Test
```

## How to build the code

In the Visual Studio - solution explorer, expand the 'TFLCodingChallengeEmmanuel.Server' project. 
Open the appsettings.json to set the values for the following parameters

```
"AppId": "Enter AppId value here",
"AppKey": "Enter AppKey value here"
```
Right click on 'TFLCodingChallengeEmmanuel.Server' in the Visual Studio - solution explorer and select 'Set as StartUp Project'
In the Visual Studio menu bar, click on IIS Express to run the solution and if the build is successful, this would lunch a browser.

## How to run the output

For this particular solution, there are 3 ways to run the output

### 1. Powershell

Ensure the project 'TFLCodingChallengeEmmanuel.Server' is still running.
navigate to the C:\TFL\TFLCodingChallengeEmmanuel\TFLCodingChallengeEmmanuel.Console\bin\Debug\netcoreapp3.0, shift + right click for an option to run powershell inside this folder.
Drag and drop the TFLCodingChallengeEmmanuel.Console.exe file into powershell and press enter to run the console app as displayed below
```
PS C:\TFL\TFLCodingChallengeEmmanuel\TFLCodingChallengeEmmanuel.Console\bin\Debug\netcoreapp3.0> C:\TFL\TFLCodingChallengeEmmanuel\TFLCodingChallengeEmmanuel.Console\bin\Debug\netcoreapp3.0\TFLCodingChallengeEmmanuel
.Console.exe

```
Enter the Road Id and press enter to request for the road status update as shown below

```
PS C:\TFL\TFLCodingChallengeEmmanuel\TFLCodingChallengeEmmanuel.Console\bin\Debug\netcoreapp3.0> C:\TFL\TFLCodingChallengeEmmanuel\TFLCodingChallengeEmmanuel.Console\bin\Debug\netcoreapp3.0\TFLCodingChallengeEmmanuel
.Console.exe 
A2
```

### 2. Browser

Ensure the project 'TFLCodingChallengeEmmanuel.Server' is still running.

In the opened browser, add /Road/A2 to the address as shown below

```
https://localhost:44380/Road/A2
```

### 3. Postman

Ensure the project 'TFLCodingChallengeEmmanuel.Server' is still running.

Add a new request in postman, from the address bar, select the GET method from the drop down list
in the Enter request URL, enter https://localhost:44380/Road/A2 and click on the send button. 

## How to run the test
In visual studio, navigate to the 'TFLCodingChallengeEmmanuel.Test' project and expand.

This project has 2 tests
```
RoadStatusMapperTest - This test to ensure when we get a response for the road api, we are able to map the result into a Dto and we get the expected result
RoadStatusTest - This test to ensure when a road Id is provided we get the right response from the road status service
```
To run these tests individually right click on the test and click 'Run Test'. 
To run all the tests in this project, right click on TFLCodingChallengeEmmanuel.Test and click 'Run Test'.

