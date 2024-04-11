// See https://aka.ms/new-console-template for more information
class program
{
static void Main (string[] args){

  DisplayFactory factory = new DisplayFactory();
  WeatherStation weatherstation = new WeatherStation(factory); 

  WeatherStation.AddDisplay("current");
   WeatherStation.AddDisplay("forecast");

}
}