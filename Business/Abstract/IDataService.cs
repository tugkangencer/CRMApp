using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IDataService
    {
        IDataResult<List<Country>> GetCountries();
        IDataResult<List<City>> GetCities(int countryId);
        IDataResult<List<District>> GetDistricts(int cityId);
        IDataResult<List<Neighborhood>> GetNeighborhoods(int districtId);
        IDataResult<List<Occupation>> GetOccupations();
        IDataResult<List<Sector>> GetSectors();
    }
}