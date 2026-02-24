using CommunityToolkit.Mvvm.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace WMSProjekt
{
    /// <summary>
    /// Dolgozó adatok megjelenítéshez (szabadnapkezelés)
    /// </summary>
    public partial class EmployeeViewModel : ObservableObject
    {
        /// <summary>
        /// Szabadnapok száma
        /// </summary>
        private static int VacationDay = 45;
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
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(RemainingDays))]
        private int daysOff = 8;
        /// <summary>
        /// Hátralévő szabadnapok száma
        /// </summary>
        public int RemainingDays
        {
            get 
            { 
                int eredmeny = VacationDay -  DaysOff;
                return eredmeny;
            }
        }
    }
}
