//Design a parking system for a parking lot.
//The parking lot has three kinds of parking spaces: big, medium, and small, with a fixed number of slots for each size.
//Design a parking system for a parking lot. The parking lot has three kinds of parking spaces: big, medium, and small, with a fixed number of slots for each size.

//Implement the ParkingSystem class:

//ParkingSystem(int big, int medium, int small) Initializes object of the ParkingSystem class.
//The number of slots for each parking space are given as part of the constructor.
//bool addCar(int carType) Checks whether there is a parking space of carType for the car that wants to get into the parking lot.
//carType can be of three kinds: big, medium, or small, which are represented by 1, 2, and 3 respectively.
//A car can only park in a parking space of its carType. If there is no space available, return false, else park the car in that size space and return true.

//Thoughts for addCar method: Check carType and match it with a switch case statement to its corresponding parking space.
//If available, decrement parking space count and return true.
//If not available, return false.

using Assignment_7._4;

ParkingSystem MyParkingLot = new(5, 1, 3);

MyParkingLot.AddCar(1); // return true because there is big car space available
MyParkingLot.AddCar(2);
MyParkingLot.AddCar(3);
MyParkingLot.AddCar(2); // return false because there is no medium car space available

Console.WriteLine(MyParkingLot.ToString()); // return a string representation of the parking lot status.