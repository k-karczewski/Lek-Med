using AutoMapper;
using LekMed.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace LekMed.Core
{
    public class DtoMapper
    {
        private IMapper _mapper;

        public DtoMapper()
        {
            _mapper = new MapperConfiguration(config =>
            {
                config.CreateMap<DoctorEntity, DoctorDto>().ReverseMap();
                config.CreateMap<PrescriptionEntity, PrescriptionDto>().ReverseMap();
                config.CreateMap<MedicineEntity, MedicineDto>().ForMember(x => x.TotalPrice, options => options.MapFrom(y => y.Price * y.Amount)).ReverseMap();
            }).CreateMapper();
        }

        #region Doctor Maps
        // doctor entity => doctor dto
        public DoctorDto Map(DoctorEntity doctorEntity) => _mapper.Map<DoctorDto>(doctorEntity);
        public IEnumerable<DoctorDto> Map(IEnumerable<DoctorEntity> doctorEntities) => _mapper.Map<IEnumerable<DoctorDto>>(doctorEntities);

        // doctor dto => doctor entity
        public DoctorEntity Map(DoctorDto doctorDto) => _mapper.Map<DoctorEntity>(doctorDto);
        public IEnumerable<DoctorEntity> Map(IEnumerable<DoctorDto> doctorDtos) => _mapper.Map<IEnumerable<DoctorEntity>>(doctorDtos);

        #endregion

        #region Prescription Maps
        // prescription entity => prescription dto
        public PrescriptionDto Map(PrescriptionEntity prescriptionEntity) => _mapper.Map<PrescriptionDto>(prescriptionEntity);
        public IEnumerable<PrescriptionDto> Map(IEnumerable<PrescriptionEntity> prescriptionEntities) => _mapper.Map<IEnumerable<PrescriptionDto>>(prescriptionEntities);

        // prescription dto => prescription entity
        public PrescriptionEntity Map(PrescriptionDto prescriptionDto) => _mapper.Map<PrescriptionEntity>(prescriptionDto);
        public IEnumerable<PrescriptionEntity> Map(IEnumerable<PrescriptionDto> prescriptionDtos) => _mapper.Map<IEnumerable<PrescriptionEntity>>(prescriptionDtos);
        #endregion

        #region Medicine Maps
        // medicine entity => medicine dto
        public MedicineDto Map(MedicineEntity medicineEntity) => _mapper.Map<MedicineDto>(medicineEntity);
        public IEnumerable<MedicineDto> Map(IEnumerable<MedicineEntity> medicineEntities) => _mapper.Map<IEnumerable<MedicineDto>>(medicineEntities);

        // medicine dto => medicine entity
        public MedicineEntity Map(MedicineDto medicineDto) => _mapper.Map<MedicineEntity>(medicineDto);
        public IEnumerable<MedicineEntity> Map(IEnumerable<MedicineDto> medicineDtos) => _mapper.Map<IEnumerable<MedicineEntity>>(medicineDtos);
        #endregion
    }
}
