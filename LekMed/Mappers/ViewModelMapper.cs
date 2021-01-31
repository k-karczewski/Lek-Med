using AutoMapper;
using LekMed.Core;
using System.Collections.Generic;

namespace LekMed
{
    public class ViewModelMapper
    {
        private IMapper _mapper;

        public ViewModelMapper()
        {
            _mapper = new MapperConfiguration(config =>
            {
                config.CreateMap<DoctorDto, DoctorViewModel>().ReverseMap();
                config.CreateMap<PrescriptionDto, PrescriptionViewModel>().ReverseMap();
                config.CreateMap<MedicineDto, MedicineViewModel>().ReverseMap();
            }).CreateMapper();
        }

        #region Doctor Maps
        // doctor entity => doctor dto
        public DoctorViewModel Map(DoctorDto doctorDto) => _mapper.Map<DoctorViewModel>(doctorDto);
        public IEnumerable<DoctorViewModel> Map(IEnumerable<DoctorDto> doctorDtos) => _mapper.Map<IEnumerable<DoctorViewModel>>(doctorDtos);

        // doctor dto => doctor entity
        public DoctorDto Map(DoctorViewModel doctorVM) => _mapper.Map<DoctorDto>(doctorVM);
        public IEnumerable<DoctorDto> Map(IEnumerable<DoctorViewModel> doctorVMs) => _mapper.Map<IEnumerable<DoctorDto>>(doctorVMs);

        #endregion

        #region Prescription Maps
        // prescription entity => prescription dto
        public PrescriptionViewModel Map(PrescriptionDto prescriptionDto) => _mapper.Map<PrescriptionViewModel>(prescriptionDto);
        public IEnumerable<PrescriptionViewModel> Map(IEnumerable<PrescriptionDto> prescriptionDtos) => _mapper.Map<IEnumerable<PrescriptionViewModel>>(prescriptionDtos);

        // prescription dto => prescription entity
        public PrescriptionDto Map(PrescriptionViewModel prescriptionVM) => _mapper.Map<PrescriptionDto>(prescriptionVM);
        public IEnumerable<PrescriptionDto> Map(IEnumerable<PrescriptionViewModel> prescriptionVMs) => _mapper.Map<IEnumerable<PrescriptionDto>>(prescriptionVMs);
        #endregion

        #region Medicine Maps
        // medicine entity => medicine dto
        public MedicineViewModel Map(MedicineDto medicineDto) => _mapper.Map<MedicineViewModel>(medicineDto);
        public IEnumerable<MedicineViewModel> Map(IEnumerable<MedicineDto> medicineDtos) => _mapper.Map<IEnumerable<MedicineViewModel>>(medicineDtos);

        // medicine dto => medicine entity
        public MedicineDto Map(MedicineViewModel medicineVM) => _mapper.Map<MedicineDto>(medicineVM);
        public IEnumerable<MedicineDto> Map(IEnumerable<MedicineViewModel> medicineVMs) => _mapper.Map<IEnumerable<MedicineDto>>(medicineVMs);
        #endregion
    }
}
