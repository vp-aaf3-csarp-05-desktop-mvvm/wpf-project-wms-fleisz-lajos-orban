using System.Security.Cryptography.X509Certificates;

namespace WMSProjekt
{
    /// <summary>
    /// Dolgozó adatok megjelenítéshez (szabadnapkezelés)
    /// </summary>
    public class EmployeeViewModel
    {
        /// <summary>
        /// Dolgozó neve
        /// </summary>
        public string Name { get; } = "Nagy Anna";
        /// <summary>
        /// Adószáma
        /// </summary>
        public string TaxNumber { get; } = "59712655-2-33";
        /// <summary>
        /// Kivett szabadnapok száma
        /// </summary>
        public int DaysOff { get; } = 6;
    }
}
