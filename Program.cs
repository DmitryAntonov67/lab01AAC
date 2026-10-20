//Архитектура
using System.Diagnostics;

Console.WriteLine($"компьютер:{Environment.MachineName}");
Console.WriteLine($"пользователь:{Environment.UserName}");
Console.WriteLine($"дата и время:{DateTime.Now:dd.MM.yyyy HH:mm}");

Console.WriteLine($"OC:{Environment.OSVersion}");
Console.WriteLine($"64-битная ОС:{Environment.Is64BitOperatingSystem}");

//step3
Console.WriteLine($"Логических процессов:{Environment.ProcessorCount}");
//step 4
Console.WriteLine($"PID процесса:{Environment.ProcessId}");
long memory = Environment.WorkingSet / 1024 / 1024;
Console.WriteLine($"Память процесса:{memory}мб");
Console.ReadLine();




Console.WriteLine("МИНИ-МОНИТОР СИСТЕМЫ\n");
Console.WriteLine($"Компьютер: {Environment.MachineName}");
Console.WriteLine($"Пользователь: {Environment.UserName}");
Console.WriteLine($"ОС: {Environment.OSVersion}");
Console.WriteLine($"64-битная ОС: {Environment.Is64BitOperatingSystem}");
Console.WriteLine($"Логических процессоров: {Environment.ProcessorCount}\n");

Process currentProcess = Process.GetCurrentProcess();

Console.WriteLine($"PID процесса: {currentProcess.Id}\n");
Console.WriteLine("Память процесса:");
for (int i = 1; i <= 3; i++) {
    currentProcess.Refresh();
    long memoryy = currentProcess.WorkingSet64 / 1024 / 1024;
    Console.WriteLine($"{i} измерение: {memoryy} МБ");
    if (i < 3) {
        Console.WriteLine("Обновите окно через несколько секунд...");
        Console.ReadLine();
    }
}

Console.WriteLine("Исследование завершено.");
