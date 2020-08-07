using FgupAPI.Models.TableData;
using FgupDAL.Models;
using FgupDAL.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FgupBL.Services.Implementation
{
    public class TableDataService : ITableDataService
    {
        private readonly IRouteRepository _routeRepository;
        private readonly ISubjectRepository _subjectRepository;
        private readonly IFederalDistrictRepository _federalDistrictRepository;
        private readonly ICityRepository _cityRepository;

        public TableDataService(IRouteRepository routeRepository,
            ISubjectRepository subjectRepository,
            IFederalDistrictRepository federalDistrictRepository,
            ICityRepository cityRepository)
        {
            _routeRepository = routeRepository;
            _subjectRepository = subjectRepository;
            _federalDistrictRepository = federalDistrictRepository;
            _cityRepository = cityRepository;
        }

        public async Task<TableDataResponse> GenerateTableDataAsync()
        {
            var routes = await _routeRepository.GetAllRoutesAsync();
            if(routes.Count <= 0)
                return new TableDataResponse("No available routes");

            var subjects = await _subjectRepository.GetSubjectsByIdsAsync(routes.Select(x => x.ParentRegionId).ToList());
            if(subjects.Count <= 0)
                return new TableDataResponse("No available subject");

            var fedDistrics = await _federalDistrictRepository.GetDistrictsByIdsAsync(subjects.Select(x => x.ParentRegionId).ToList());
            if (fedDistrics.Count <= 0)
                return new TableDataResponse("No available federal districs");

            return await CreateResponseAsync(routes, subjects, fedDistrics);
        }

        //если будет добавляться логика, необходимо будет разнести для простоты тестов
        private async Task<TableDataResponse> CreateResponseAsync(List<Route> routes, List<Subject> subjects, List<FederalDistrict> fedDistrics)
        {
            var response = new TableDataResponse();
            var cityNames = await GetCityNamesDictAsync(routes);

            foreach (var fedDist in fedDistrics)
            {
                var fedData = new FederalDistrictData { Name = fedDist.Name };

                foreach(var subj in subjects.Where(x => x.ParentRegionId == fedDist.Id))
                {
                    var subjData = new SubjectData { Name = subj.Name };

                    foreach (var route in routes.Where(x => x.ParentRegionId == subj.Id))
                    {
                        subjData.InsideRegionData.Add(new InsideRegionData
                        {
                            CityFrom = cityNames[route.CityFromId],
                            CityTo = cityNames[route.CityToId],
                            HiddenId = route.Id,
                            MenAdult = route.MenAdult,
                            MenKid = route.MenKid,
                            MenSenior = route.MenSenior,
                            WomenAdult = route.WomenAdult,
                            WomenKid = route.WomenKid,
                            WomenSenior = route.WomenSenior
                        });
                    }

                    subjData.MenAdult = subjData.InsideRegionData.Sum(x => x.MenAdult);
                    subjData.MenKid = subjData.InsideRegionData.Sum(x => x.MenKid);
                    subjData.MenSenior = subjData.InsideRegionData.Sum(x => x.MenSenior);
                    subjData.WomenAdult = subjData.InsideRegionData.Sum(x => x.WomenAdult);
                    subjData.WomenKid = subjData.InsideRegionData.Sum(x => x.WomenKid); 
                    subjData.WomenSenior = subjData.InsideRegionData.Sum(x => x.WomenSenior);

                    fedData.SubjectData.Add(subjData);
                }

                fedData.MenAdult = fedData.SubjectData.Sum(x => x.MenAdult);
                fedData.MenKid = fedData.SubjectData.Sum(x => x.MenKid);
                fedData.MenSenior = fedData.SubjectData.Sum(x => x.MenSenior);
                fedData.WomenAdult = fedData.SubjectData.Sum(x => x.WomenAdult);
                fedData.WomenKid = fedData.SubjectData.Sum(x => x.WomenKid);
                fedData.WomenSenior = fedData.SubjectData.Sum(x => x.WomenSenior);

                response.FederalDistrictData.Add(fedData);
            }            

            return response;
        }

        private async Task<Dictionary<long, string>> GetCityNamesDictAsync(List<Route> routes)
        {
            var ids = routes.Select(x => x.CityFromId).Union(routes.Select(x => x.CityToId)).Distinct();

            return await _cityRepository.GetNamesDictByIdsAsync(ids);
        }
    }
}
