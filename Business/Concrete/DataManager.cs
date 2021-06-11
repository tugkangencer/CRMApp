using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class DataManager : IDataService
    {
        private readonly ICountryRepository _countryRepository;
        private readonly ICityRepository _cityRepository;
        private readonly IDistrictRepository _districtRepository;
        private readonly INeighborhoodRepository _neighborhoodRepository;
        private readonly IOccupationRepository _occupationRepository;
        private readonly ISectorRepository _sectorRepository;

        public DataManager(ICountryRepository countryRepository,
                           ICityRepository cityRepository,
                           IDistrictRepository districtRepository,
                           INeighborhoodRepository neighborhoodRepository,
                           IOccupationRepository occupationRepository,
                           ISectorRepository sectorRepository)
        {
            _countryRepository = countryRepository;
            _cityRepository = cityRepository;
            _districtRepository = districtRepository;
            _neighborhoodRepository = neighborhoodRepository;
            _occupationRepository = occupationRepository;
            _sectorRepository = sectorRepository;
        }

        public IDataResult<List<Country>> GetCountries()
        {
            return new SuccessDataResult<List<Country>>(_countryRepository.GetAll(), Messages.Success);
        }

        public IDataResult<List<City>> GetCities(int countryId)
        {
            return new SuccessDataResult<List<City>>(_cityRepository.GetAll(c => c.CountryID == countryId), Messages.Success);
        }

        public IDataResult<List<District>> GetDistricts(int cityId)
        {
            return new SuccessDataResult<List<District>>(_districtRepository.GetAll(d => d.CityID == cityId), Messages.Success);
        }

        public IDataResult<List<Neighborhood>> GetNeighborhoods(int districtId)
        {
            return new SuccessDataResult<List<Neighborhood>>(_neighborhoodRepository.GetAll(n => n.DistrictID == districtId), Messages.Success);
        }

        public IDataResult<List<Occupation>> GetOccupations()
        {
            return new SuccessDataResult<List<Occupation>>(_occupationRepository.GetAll(), Messages.Success);
        }

        public IDataResult<List<Sector>> GetSectors()
        {
            return new SuccessDataResult<List<Sector>>(_sectorRepository.GetAll(), Messages.Success);
        }
    }
}