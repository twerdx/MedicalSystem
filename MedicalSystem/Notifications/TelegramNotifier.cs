using MedicalSystem.Interfaces;
using MedicalSystem.Users;

namespace MedicalSystem.Notifications;

public class TelegramNotifier : INotifier
{
    public void Send(Patient patient, string message)
    {
        Console.WriteLine(
            $"Telegram для {patient.Name}: {message}");
    }
}