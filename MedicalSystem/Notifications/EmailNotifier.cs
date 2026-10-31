using MedicalSystem.Interfaces;
using MedicalSystem.Users;

namespace MedicalSystem.Notifications;

public class EmailNotifier : INotifier
{
    public void Send(Patient patient, string message)
    {
        Console.WriteLine(
            $"Email на адрес {patient.Email}: {message}");
    }
}