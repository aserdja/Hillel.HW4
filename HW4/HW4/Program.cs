var timer = new Timer();

timer.OnTimeElapsed += Informator.ShowInfo;
timer.OnTimeElapsed += () => Console.WriteLine("Timer stopped (lambda)");
timer.Start(10);


var timer2 = new Timer();
timer2.OnTimeElapsed += () => Console.WriteLine("Second timer stopped");
timer2.Start(5);

Console.ReadKey();
