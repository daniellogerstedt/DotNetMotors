
# .NET Motors
#### Lab05-DotNetMotors
##### *Author: Daniel Logerstedt*

------------------------------

## Description
This is a C# collection of Abstract and Concrete classes containing three levels of abstraction.

##### Interfaces
Interfaces are a way for us to attach similar behavior across many objects that do not share a parent object type and have sibling objects that don't share it.

I have 2 interfaces: DriveBackward and AllWheelDrive

DriveBackward is implemented in Commuter Cars, Pickup Trucks, and Cargo Vans. This is because Racecars and Motorcycles cannot drive backward.

AllWheelDrive is implemented in Commuter Cars and Pickups. It includes all methods of all wheel driving such as 4 wheel drive and standard all wheel drive. Racecars, Motorcycles, and Cargo Vans don't have this but Commuters and Trucks do.'

------------------------------

## Getting Started
Clone this repository to your local machine.
```
$ git clone https://github.com/daniellogerstedt/DotNetMotors.git
```
#### To run the program from Visual Studio:
Select ```File``` -> ```Open``` -> ```Project/Solution```

Next navigate to the location you cloned the Repository.

Double click on the ```DotNetMotors``` directory.

Then select and open ```DotNetMotors.sln```

------------------------------

## Visuals

![Wireframe](./assets/wireframe.PNG)

------------------------------

## Change Log
