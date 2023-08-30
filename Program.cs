//followed along with the video to get an understanding
//create an instance from 1st constructor
Vehicle car= new Vehicle("Nissan Altima", 4, "blue", true);

//instance from 2nd constructor
Vehicle anotherCar= new Vehicle("Toyota Camry", "white");

//create a vehicle with no engine
Vehicle Scooter= new Vehicle("Scooter", 1, "gray", false);

//create a 4th vehicle
Vehicle Horse= new Vehicle("Donna", 2, "brown", false);

List<Vehicle> AllVehicles= new List <Vehicle>();
AllVehicles.Add(car);
AllVehicles.Add(anotherCar);
AllVehicles.Add(Scooter);
AllVehicles.Add(Horse);

foreach(Vehicle v in AllVehicles)
{
    v.ShowInfo();
}

car.Travel(100);
car.ShowInfo();