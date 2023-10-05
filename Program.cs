
// Declarations
const int MAX_CAR_SPEEDS = 100;
int[] carSpeeds = new int[MAX_CAR_SPEEDS];

int count = 0;

// Prompt and gather speeds
System.Console.WriteLine("Please enter car speeds (-1 to stop)");
int speed = int.Parse(Console.ReadLine());

while(speed > 0){
    carSpeeds[count] = speed;
    count++;

    System.Console.WriteLine("Please enter car speeds (-1 to stop)");
    speed = int.Parse(Console.ReadLine());

}

//Find and display max
int max = carSpeeds[0];

for(int i = 0; i < count; i++){
    if(max == carSpeeds[i]){
        max = carSpeeds[i];
    }
}

System.Console.WriteLine($"The fastest car speed was: {max}");