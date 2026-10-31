using MedicalSystem.Users;

namespace MedicalSystem.Interfaces;

public interface INotifier
{
    void Send(Patient patient, string message);
}