using MedicalSystem.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalSystem.Interfaces
{
    public interface ISpravka
    {
        string SpravkaName { get; set; }
        Patient Patient { get; set; }
        decimal Price { get; set; }

        void DisplayInfo();

        decimal CalculatePrice();
        string GetShortInfo();

    }
}
