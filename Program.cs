var timer = new CronTimer("0/10 * * * *", "Europe/Amsterdam", includingSeconds: false);
timer.OnOccurence += (s, ea) => Console.Out.WriteLineAsync(ea + " - " + DateTime.Now);
timer.Start();