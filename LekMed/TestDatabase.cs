using System.Collections.Generic;

namespace LekMed
{
    public static class TestDatabase
    {
        public static List<DoctorViewModel> Doctors { get; set; } = new List<DoctorViewModel>
        {
            new DoctorViewModel
            {
                Name = "Janusz",
                Prescriptions = new List<PrescriptionViewModel>
                {
                    new PrescriptionViewModel
                    {
                        Name = "Recepta 1",
                        Medicines = new List<MedicineViewModel>
                        {
                            new MedicineViewModel
                            {
                                Name = "Magnez"
                            },
                            new MedicineViewModel
                            {
                                Name = "Aspiryna"
                            },
                        }
                    },
                    new PrescriptionViewModel
                    {
                        Name = "Recepta 2",
                        Medicines = new List<MedicineViewModel>
                        {
                            new MedicineViewModel
                            {
                                Name = "Żelazo"
                            },
                            new MedicineViewModel
                            {
                                Name = "Witamina C"
                            },
                        }
                    },
                }
            },
            new DoctorViewModel
            {
                Name = "Kazimierz",
                Prescriptions = new List<PrescriptionViewModel>
                {
                    new PrescriptionViewModel
                    {
                        Name = "Recepta 1",
                        Medicines = new List<MedicineViewModel>
                        {
                            new MedicineViewModel
                            {
                                Name = "Magnez"
                            },
                            new MedicineViewModel
                            {
                                Name = "Aspiryna"
                            },
                        }
                    },
                    new PrescriptionViewModel
                    {
                        Name = "Recepta 2",
                        Medicines = new List<MedicineViewModel>
                        {
                            new MedicineViewModel
                            {
                                Name = "Żelazo"
                            },
                            new MedicineViewModel
                            {
                                Name = "Witamina C"
                            },
                        }
                    },
                }
            },
            new DoctorViewModel
            {
                Name = "Zbigniew",
               Prescriptions = new List<PrescriptionViewModel>
                {
                    new PrescriptionViewModel
                    {
                        Name = "Recepta 1",
                        Medicines = new List<MedicineViewModel>
                        {
                            new MedicineViewModel
                            {
                                Name = "Magnez"
                            },
                            new MedicineViewModel
                            {
                                Name = "Aspiryna"
                            },
                        }
                    },
                    new PrescriptionViewModel
                    {
                        Name = "Recepta 2",
                        Medicines = new List<MedicineViewModel>
                        {
                            new MedicineViewModel
                            {
                                Name = "Żelazo"
                            },
                            new MedicineViewModel
                            {
                                Name = "Witamina C"
                            },
                        }
                    },
                }
            }
        };
    }
}
