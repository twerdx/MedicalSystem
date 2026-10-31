using MedicalSystem.Interfaces;
using MedicalSystem.Users;

namespace MedicalSystem.Notifications;

public class SmsNotifier : INotifier
{
    public void Send(Patient patient, string message)
    {
        Console.WriteLine(
            $"SMS на номер {patient.PhoneNumber}: {message}");
    }
}