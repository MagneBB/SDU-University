// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
int experiment = 2147483647;
experiment = experiment + 1;
Console.WriteLine(experiment);
*/
int ada_lovelace = 36;
int dennis_ritchie = 70;
int grace_hopper = 85;
int hedy_lamarr = 85;
int edsger_dijkstra = 72;
int douglas_engelbart = 88;

float male_avg = (float)(dennis_ritchie + edsger_dijkstra + douglas_engelbart) / 3;
float female_avg = (float)(ada_lovelace + grace_hopper + hedy_lamarr) / 3;
float avg = (male_avg + female_avg);
float diff = male_avg - female_avg;

Console.WriteLine("The average lifespan of a male computer scientist: ");
Console.WriteLine(male_avg);
Console.WriteLine("The average lifespan of a female computer scientist: ");
Console.WriteLine(female_avg);
Console.WriteLine("The average lifespan of a computer scientist: ");
Console.WriteLine(avg);
Console.WriteLine("Males live this much longer than females: ");
Console.WriteLine(diff);
