using System.Media;

var soundFile = "default.wav";
var time = 5;

if (args.Length > 0)
{
    if (int.TryParse(args[0], out int timeArgs))
    {
        time = timeArgs;
    }
}
if (args.Length > 1)
{
    soundFile = args[1];
}

var start = DateTime.Now;
var end = start.AddMinutes(time);
var random = new Random();

while (DateTime.Now < end)
{
    PlaySound(soundFile);

    var sleep = random.Next(10, 30);
    Thread.Sleep(1000 * sleep);
}

static void PlaySound(string soundFile)
{
    var player = new SoundPlayer(soundFile);
    player.PlaySync();
}