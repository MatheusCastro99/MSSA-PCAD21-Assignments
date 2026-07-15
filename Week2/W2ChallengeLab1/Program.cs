Console.WriteLine("Hello, World!");

int temperature = 11;
string weatherType = "";

switch (temperature) {
    case >= 0 and <=10:
        {
            weatherType = "Freezing weather";
            break;
        }
    case >10 and <=20: 
        {
            weatherType = "Very cold weather";
            break;
        }
    case >20 and <=35:
        {
            weatherType = "Cold weather";
            break;
        }
    case > 35 and <= 50:
        {
            weatherType = "Normal in weather";
            break;
        }
    case > 50 and <= 65:
        {
            weatherType = "Its Hot";
            break;
        }
    case > 65 and <= 80:
        {
            weatherType = "Its very hot";
            break;
        }
}

Console.WriteLine(weatherType);