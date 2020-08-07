using FgupDAL.Context.Implementation;
using FgupDAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FgupDAL
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TestDbContext(
            serviceProvider.GetRequiredService<DbContextOptions<TestDbContext>>()))
            {

                if (!context.Cities.Any() && !string.IsNullOrWhiteSpace(_citiesJsonStr))
                    context.Cities.AddRange(JsonConvert.DeserializeObject<List<City>>(_citiesJsonStr));

                if (!context.FederalDistricts.Any() && !string.IsNullOrWhiteSpace(_federalDistrictJsonStr))
                    context.FederalDistricts.AddRange(JsonConvert.DeserializeObject<List<FederalDistrict>>(_federalDistrictJsonStr));

                if (!context.Regions.Any() && !string.IsNullOrWhiteSpace(_regionJsonStr))
                    context.Regions.AddRange(JsonConvert.DeserializeObject<List<Region>>(_regionJsonStr));

                if (!context.Routes.Any() && !string.IsNullOrWhiteSpace(_routesJsonStr))
                    context.Routes.AddRange(JsonConvert.DeserializeObject<List<Route>>(_routesJsonStr));

                if (!context.Subjects.Any() && !string.IsNullOrWhiteSpace(_subjectsJsonStr))
                    context.Subjects.AddRange(JsonConvert.DeserializeObject<List<Subject>>(_subjectsJsonStr));

                context.SaveChanges();
            }
        }

        #region jsonStrings

        private static readonly string _regionJsonStr = @"
[
  {
    ""REGION_ID"": 9000001,
    ""PARENT_REGION_ID"": 185,
    ""REGION_LEVEL"": 2,
    ""REGION_NAME"": ""Центральный федеральный округ"",
    ""FEATURE_BINDING_ID"": -1029256,
    ""ENTITY_TYPE_ID"": 2
  },
  {
    ""REGION_ID"": 9000002,
    ""PARENT_REGION_ID"": 185,
    ""REGION_LEVEL"": 2,
    ""REGION_NAME"": ""Южный федеральный округ"",
    ""FEATURE_BINDING_ID"": -1059500,
    ""ENTITY_TYPE_ID"": 2
  },
  {
    ""REGION_ID"": 9000003,
    ""PARENT_REGION_ID"": 185,
    ""REGION_LEVEL"": 2,
    ""REGION_NAME"": ""Северо-Западный федеральный округ"",
    ""FEATURE_BINDING_ID"": -1216601,
    ""ENTITY_TYPE_ID"": 2
  },
  {
    ""REGION_ID"": 9000004,
    ""PARENT_REGION_ID"": 185,
    ""REGION_LEVEL"": 2,
    ""REGION_NAME"": ""Дальневосточный федеральный округ"",
    ""FEATURE_BINDING_ID"": -1221185,
    ""ENTITY_TYPE_ID"": 2
  },
  {
    ""REGION_ID"": 9000005,
    ""PARENT_REGION_ID"": 185,
    ""REGION_LEVEL"": 2,
    ""REGION_NAME"": ""Сибирский федеральный округ"",
    ""FEATURE_BINDING_ID"": -145454,
    ""ENTITY_TYPE_ID"": 2
  },
  {
    ""REGION_ID"": 9000006,
    ""PARENT_REGION_ID"": 185,
    ""REGION_LEVEL"": 2,
    ""REGION_NAME"": ""Уральский федеральный округ"",
    ""FEATURE_BINDING_ID"": -1113276,
    ""ENTITY_TYPE_ID"": 2
  },
  {
    ""REGION_ID"": 9000007,
    ""PARENT_REGION_ID"": 185,
    ""REGION_LEVEL"": 2,
    ""REGION_NAME"": ""Приволжский федеральный округ"",
    ""FEATURE_BINDING_ID"": -1075831,
    ""ENTITY_TYPE_ID"": 2
  },
  {
    ""REGION_ID"": 9000008,
    ""PARENT_REGION_ID"": 185,
    ""REGION_LEVEL"": 2,
    ""REGION_NAME"": ""Северо-Кавказский федеральный округ"",
    ""FEATURE_BINDING_ID"": -389344,
    ""ENTITY_TYPE_ID"": 2
  },
  {
    ""REGION_ID"": 1135368,
    ""PARENT_REGION_ID"": 9000001,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Белгородская область"",
    ""FEATURE_BINDING_ID"": 14000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1137574,
    ""PARENT_REGION_ID"": 9000001,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Брянская область"",
    ""FEATURE_BINDING_ID"": 15000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1141189,
    ""PARENT_REGION_ID"": 9000001,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Владимирская область"",
    ""FEATURE_BINDING_ID"": 17000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1155138,
    ""PARENT_REGION_ID"": 9000001,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Воронежская область"",
    ""FEATURE_BINDING_ID"": 20000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1163788,
    ""PARENT_REGION_ID"": 9000001,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Ивановская область"",
    ""FEATURE_BINDING_ID"": 24000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1171031,
    ""PARENT_REGION_ID"": 9000001,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Тверская область"",
    ""FEATURE_BINDING_ID"": 28000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1181365,
    ""PARENT_REGION_ID"": 9000001,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Калужская область"",
    ""FEATURE_BINDING_ID"": 29000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1192068,
    ""PARENT_REGION_ID"": 9000001,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Костромская область"",
    ""FEATURE_BINDING_ID"": 34000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1200083,
    ""PARENT_REGION_ID"": 9000001,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Курская область"",
    ""FEATURE_BINDING_ID"": 38000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1207534,
    ""PARENT_REGION_ID"": 9000001,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Липецкая область"",
    ""FEATURE_BINDING_ID"": 42000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1209975,
    ""PARENT_REGION_ID"": 9000001,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Москва"",
    ""FEATURE_BINDING_ID"": 45000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1210475,
    ""PARENT_REGION_ID"": 9000001,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Московская область"",
    ""FEATURE_BINDING_ID"": 46000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1229954,
    ""PARENT_REGION_ID"": 9000001,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Орловская область"",
    ""FEATURE_BINDING_ID"": 54000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1252418,
    ""PARENT_REGION_ID"": 9000001,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Рязанская область"",
    ""FEATURE_BINDING_ID"": 61000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1262864,
    ""PARENT_REGION_ID"": 9000001,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Смоленская область"",
    ""FEATURE_BINDING_ID"": 66000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1268470,
    ""PARENT_REGION_ID"": 9000001,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Тамбовская область"",
    ""FEATURE_BINDING_ID"": 68000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1271663,
    ""PARENT_REGION_ID"": 9000001,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Тульская область"",
    ""FEATURE_BINDING_ID"": 70000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1281909,
    ""PARENT_REGION_ID"": 9000001,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Ярославская область"",
    ""FEATURE_BINDING_ID"": 78000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1120524,
    ""PARENT_REGION_ID"": 9000002,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Краснодарский край"",
    ""FEATURE_BINDING_ID"": 3000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1134582,
    ""PARENT_REGION_ID"": 9000002,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Астраханская область"",
    ""FEATURE_BINDING_ID"": 12000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1143778,
    ""PARENT_REGION_ID"": 9000002,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Волгоградская область"",
    ""FEATURE_BINDING_ID"": 18000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1249220,
    ""PARENT_REGION_ID"": 9000002,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Ростовская область"",
    ""FEATURE_BINDING_ID"": 60000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1288465,
    ""PARENT_REGION_ID"": 9000002,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Республика Адыгея (Адыгея)"",
    ""FEATURE_BINDING_ID"": 79000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1299513,
    ""PARENT_REGION_ID"": 9000002,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Республика Калмыкия"",
    ""FEATURE_BINDING_ID"": 85000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 2200002,
    ""PARENT_REGION_ID"": 9000002,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Республика Крым"",
    ""FEATURE_BINDING_ID"": 35000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 2200003,
    ""PARENT_REGION_ID"": 9000002,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Севастополь"",
    ""FEATURE_BINDING_ID"": 67000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1129961,
    ""PARENT_REGION_ID"": 9000003,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Архангельская область"",
    ""FEATURE_BINDING_ID"": 11000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1129962,
    ""PARENT_REGION_ID"": 9000003,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Ненецкий автономный округ"",
    ""FEATURE_BINDING_ID"": 11100000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1146296,
    ""PARENT_REGION_ID"": 9000003,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Вологодская область"",
    ""FEATURE_BINDING_ID"": 19000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1169669,
    ""PARENT_REGION_ID"": 9000003,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Калининградская область"",
    ""FEATURE_BINDING_ID"": 27000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1203936,
    ""PARENT_REGION_ID"": 9000003,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Санкт-Петербург"",
    ""FEATURE_BINDING_ID"": 40000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1204092,
    ""PARENT_REGION_ID"": 9000003,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Ленинградская область"",
    ""FEATURE_BINDING_ID"": 41000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1217738,
    ""PARENT_REGION_ID"": 9000003,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Мурманская область"",
    ""FEATURE_BINDING_ID"": 47000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1217915,
    ""PARENT_REGION_ID"": 9000003,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Новгородская область"",
    ""FEATURE_BINDING_ID"": 49000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1240370,
    ""PARENT_REGION_ID"": 9000003,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Псковская область"",
    ""FEATURE_BINDING_ID"": 58000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1300033,
    ""PARENT_REGION_ID"": 9000003,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Республика Карелия"",
    ""FEATURE_BINDING_ID"": 86000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1300885,
    ""PARENT_REGION_ID"": 9000003,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Республика Коми"",
    ""FEATURE_BINDING_ID"": 87000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1126074,
    ""PARENT_REGION_ID"": 9000004,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Приморский край"",
    ""FEATURE_BINDING_ID"": 5000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1128226,
    ""PARENT_REGION_ID"": 9000004,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Хабаровский край"",
    ""FEATURE_BINDING_ID"": 8000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1128722,
    ""PARENT_REGION_ID"": 9000004,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Амурская область"",
    ""FEATURE_BINDING_ID"": 10000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1185310,
    ""PARENT_REGION_ID"": 9000004,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Камчатский край"",
    ""FEATURE_BINDING_ID"": 30000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1209786,
    ""PARENT_REGION_ID"": 9000004,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Магаданская область"",
    ""FEATURE_BINDING_ID"": 44000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1259454,
    ""PARENT_REGION_ID"": 9000004,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Сахалинская область"",
    ""FEATURE_BINDING_ID"": 64000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1280925,
    ""PARENT_REGION_ID"": 9000004,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Забайкальский край"",
    ""FEATURE_BINDING_ID"": 76000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1281825,
    ""PARENT_REGION_ID"": 9000004,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Чукотский автономный округ"",
    ""FEATURE_BINDING_ID"": 77000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1295163,
    ""PARENT_REGION_ID"": 9000004,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Республика Бурятия"",
    ""FEATURE_BINDING_ID"": 81000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1316079,
    ""PARENT_REGION_ID"": 9000004,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Республика Саха (Якутия)"",
    ""FEATURE_BINDING_ID"": 98000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1517729,
    ""PARENT_REGION_ID"": 9000004,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Еврейская автономная область"",
    ""FEATURE_BINDING_ID"": 99000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1117443,
    ""PARENT_REGION_ID"": 9000005,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Алтайский край"",
    ""FEATURE_BINDING_ID"": 1000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1123232,
    ""PARENT_REGION_ID"": 9000005,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Красноярский край"",
    ""FEATURE_BINDING_ID"": 4000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1167208,
    ""PARENT_REGION_ID"": 9000005,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Иркутская область"",
    ""FEATURE_BINDING_ID"": 25000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1185428,
    ""PARENT_REGION_ID"": 9000005,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Кемеровская область"",
    ""FEATURE_BINDING_ID"": 32000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1222096,
    ""PARENT_REGION_ID"": 9000005,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Новосибирская область"",
    ""FEATURE_BINDING_ID"": 50000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1224648,
    ""PARENT_REGION_ID"": 9000005,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Омская область"",
    ""FEATURE_BINDING_ID"": 52000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1270721,
    ""PARENT_REGION_ID"": 9000005,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Томская область"",
    ""FEATURE_BINDING_ID"": 69000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1299060,
    ""PARENT_REGION_ID"": 9000005,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Республика Алтай"",
    ""FEATURE_BINDING_ID"": 84000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1310031,
    ""PARENT_REGION_ID"": 9000005,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Республика Тыва"",
    ""FEATURE_BINDING_ID"": 93000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1313127,
    ""PARENT_REGION_ID"": 9000005,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Республика Хакасия"",
    ""FEATURE_BINDING_ID"": 95000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1197941,
    ""PARENT_REGION_ID"": 9000006,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Курганская область"",
    ""FEATURE_BINDING_ID"": 37000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1259887,
    ""PARENT_REGION_ID"": 9000006,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Свердловская область"",
    ""FEATURE_BINDING_ID"": 65000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1275926,
    ""PARENT_REGION_ID"": 9000006,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Тюменская область"",
    ""FEATURE_BINDING_ID"": 71000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1275927,
    ""PARENT_REGION_ID"": 9000006,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Ханты-Мансийский автономный округ - Югра"",
    ""FEATURE_BINDING_ID"": 71100000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1276157,
    ""PARENT_REGION_ID"": 9000006,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Ямало-Ненецкий автономный округ"",
    ""FEATURE_BINDING_ID"": 71140000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1279039,
    ""PARENT_REGION_ID"": 9000006,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Челябинская область"",
    ""FEATURE_BINDING_ID"": 75000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1158007,
    ""PARENT_REGION_ID"": 9000007,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Нижегородская область"",
    ""FEATURE_BINDING_ID"": 22000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1186973,
    ""PARENT_REGION_ID"": 9000007,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Кировская область"",
    ""FEATURE_BINDING_ID"": 33000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1195929,
    ""PARENT_REGION_ID"": 9000007,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Самарская область"",
    ""FEATURE_BINDING_ID"": 36000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1226987,
    ""PARENT_REGION_ID"": 9000007,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Оренбургская область"",
    ""FEATURE_BINDING_ID"": 53000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1233414,
    ""PARENT_REGION_ID"": 9000007,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Пензенская область"",
    ""FEATURE_BINDING_ID"": 56000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1235480,
    ""PARENT_REGION_ID"": 9000007,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Пермский край"",
    ""FEATURE_BINDING_ID"": 57000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1256225,
    ""PARENT_REGION_ID"": 9000007,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Саратовская область"",
    ""FEATURE_BINDING_ID"": 63000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1277717,
    ""PARENT_REGION_ID"": 9000007,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Ульяновская область"",
    ""FEATURE_BINDING_ID"": 73000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1288816,
    ""PARENT_REGION_ID"": 9000007,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Республика Башкортостан"",
    ""FEATURE_BINDING_ID"": 80000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1302061,
    ""PARENT_REGION_ID"": 9000007,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Республика Марий Эл"",
    ""FEATURE_BINDING_ID"": 88000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1304095,
    ""PARENT_REGION_ID"": 9000007,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Республика Мордовия"",
    ""FEATURE_BINDING_ID"": 89000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1306779,
    ""PARENT_REGION_ID"": 9000007,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Республика Татарстан"",
    ""FEATURE_BINDING_ID"": 92000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1310454,
    ""PARENT_REGION_ID"": 9000007,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Удмуртская Республика"",
    ""FEATURE_BINDING_ID"": 94000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1313584,
    ""PARENT_REGION_ID"": 9000007,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Чувашская Республика"",
    ""FEATURE_BINDING_ID"": 97000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1126811,
    ""PARENT_REGION_ID"": 9000008,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Ставропольский край"",
    ""FEATURE_BINDING_ID"": 7000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1169660,
    ""PARENT_REGION_ID"": 9000008,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Республика Ингушетия"",
    ""FEATURE_BINDING_ID"": 26000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1296359,
    ""PARENT_REGION_ID"": 9000008,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Республика Дагестан"",
    ""FEATURE_BINDING_ID"": 82000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1298848,
    ""PARENT_REGION_ID"": 9000008,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Кабардино-Балкарская Республика"",
    ""FEATURE_BINDING_ID"": 83000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1306147,
    ""PARENT_REGION_ID"": 9000008,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Республика Северная Осетия-Алания"",
    ""FEATURE_BINDING_ID"": 90000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1306600,
    ""PARENT_REGION_ID"": 9000008,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Карачаево-Черкесская Республика"",
    ""FEATURE_BINDING_ID"": 91000000,
    ""ENTITY_TYPE_ID"": 3
  },
  {
    ""REGION_ID"": 1313583,
    ""PARENT_REGION_ID"": 9000008,
    ""REGION_LEVEL"": 3,
    ""REGION_NAME"": ""Чеченская Республика"",
    ""FEATURE_BINDING_ID"": 96000000,
    ""ENTITY_TYPE_ID"": 3
  }
]";

        private static readonly string _citiesJsonStr = @"

[
  {
      ""CITY_OKATO_ID"": ""45000000000"",
      ""NAME"": ""Москва"",
      ""PARENT_REGION_ID"": ""1209975"",
      ""PARENT_REGION_NAME"": ""Москва"",
      ""FO_ID"": ""9000001""
  },
  {
      ""CITY_OKATO_ID"": ""45272580000"",
      ""NAME"": ""Зеленоград"",
      ""PARENT_REGION_ID"": ""1209975"",
      ""PARENT_REGION_NAME"": ""Москва"",
      ""FO_ID"": ""9000001""
  },
  {
      ""CITY_OKATO_ID"": ""45297581001"",
      ""NAME"": ""Щербинка"",
      ""PARENT_REGION_ID"": ""1209975"",
      ""PARENT_REGION_NAME"": ""Москва"",
      ""FO_ID"": ""9000001""
  },
  {
      ""CITY_OKATO_ID"": ""45297565001"",
      ""NAME"": ""Московский"",
      ""PARENT_REGION_ID"": ""1209975"",
      ""PARENT_REGION_NAME"": ""Москва"",
      ""FO_ID"": ""9000001""
  },
  {
      ""CITY_OKATO_ID"": ""45298578000"",
      ""NAME"": ""Троицк"",
      ""PARENT_REGION_ID"": ""1209975"",
      ""PARENT_REGION_NAME"": ""Москва"",
      ""FO_ID"": ""9000001""
  },
  {
      ""CITY_OKATO_ID"": ""46221501000"",
      ""NAME"": ""Клин"",
      ""PARENT_REGION_ID"": ""1210475"",
      ""PARENT_REGION_NAME"": ""Московская область"",
      ""FO_ID"": ""9000001""
  },
  {
      ""CITY_OKATO_ID"": ""46241501000"",
      ""NAME"": ""Одинцово"",
      ""PARENT_REGION_ID"": ""1210475"",
      ""PARENT_REGION_NAME"": ""Московская область"",
      ""FO_ID"": ""9000001""
  },
  {
      ""CITY_OKATO_ID"": ""46483000000"",
      ""NAME"": ""Химки"",
      ""PARENT_REGION_ID"": ""1210475"",
      ""PARENT_REGION_NAME"": ""Московская область"",
      ""FO_ID"": ""9000001""
  },
  {
      ""CITY_OKATO_ID"": ""46446000000"",
      ""NAME"": ""Мытищи"",
      ""PARENT_REGION_ID"": ""1210475"",
      ""PARENT_REGION_NAME"": ""Московская область"",
      ""FO_ID"": ""9000001""
  },
  {
      ""CITY_OKATO_ID"": ""46208501000"",
      ""NAME"": ""Дмитров"",
      ""PARENT_REGION_ID"": ""1210475"",
      ""PARENT_REGION_NAME"": ""Московская область"",
      ""FO_ID"": ""9000001""
  },
  {
      ""CITY_OKATO_ID"": ""28401000000"",
      ""NAME"": ""Тверь"",
      ""PARENT_REGION_ID"": ""1171031"",
      ""PARENT_REGION_NAME"": ""Тверская область"",
      ""FO_ID"": ""9000001""
  },
  {
      ""CITY_OKATO_ID"": ""28222501000"",
      ""NAME"": ""Калязин"",
      ""PARENT_REGION_ID"": ""1171031"",
      ""PARENT_REGION_NAME"": ""Тверская область"",
      ""FO_ID"": ""9000001""
  },
  {
      ""CITY_OKATO_ID"": ""28450000000"",
      ""NAME"": ""Торжок"",
      ""PARENT_REGION_ID"": ""1171031"",
      ""PARENT_REGION_NAME"": ""Тверская область"",
      ""FO_ID"": ""9000001""
  },
  {
      ""CITY_OKATO_ID"": ""28445000000"",
      ""NAME"": ""Ржев"",
      ""PARENT_REGION_ID"": ""1171031"",
      ""PARENT_REGION_NAME"": ""Тверская область"",
      ""FO_ID"": ""9000001""
  },
  {
      ""CITY_OKATO_ID"": ""28414000000"",
      ""NAME"": ""В. Волочек"",
      ""PARENT_REGION_ID"": ""1171031"",
      ""PARENT_REGION_NAME"": ""Тверская область"",
      ""FO_ID"": ""9000001""
  },
  {
      ""CITY_OKATO_ID"": ""29401000000"",
      ""NAME"": ""Калуга"",
      ""PARENT_REGION_ID"": ""1181365"",
      ""PARENT_REGION_NAME"": ""Калужская область"",
      ""FO_ID"": ""9000001""
  },
  {
      ""CITY_OKATO_ID"": ""29415000000"",
      ""NAME"": ""Обнинск"",
      ""PARENT_REGION_ID"": ""1181365"",
      ""PARENT_REGION_NAME"": ""Калужская область"",
      ""FO_ID"": ""9000001""
  },
  {
      ""CITY_OKATO_ID"": ""29250501000"",
      ""NAME"": ""Юхнов"",
      ""PARENT_REGION_ID"": ""1181365"",
      ""PARENT_REGION_NAME"": ""Калужская область"",
      ""FO_ID"": ""9000001""
  },
  {
      ""CITY_OKATO_ID"": ""29236501000"",
      ""NAME"": ""Сухиничи"",
      ""PARENT_REGION_ID"": ""1181365"",
      ""PARENT_REGION_NAME"": ""Калужская область"",
      ""FO_ID"": ""9000001""
  },
  {
      ""CITY_OKATO_ID"": ""29216501000"",
      ""NAME"": ""Козельск"",
      ""PARENT_REGION_ID"": ""1181365"",
      ""PARENT_REGION_NAME"": ""Калужская область"",
      ""FO_ID"": ""9000001""
  },
  {
      ""CITY_OKATO_ID"": ""66401000000"",
      ""NAME"": ""Смоленск"",
      ""PARENT_REGION_ID"": ""1262864"",
      ""PARENT_REGION_NAME"": ""Смоленская область"",
      ""FO_ID"": ""9000001""
  },
  {
      ""CITY_OKATO_ID"": ""66208501000"",
      ""NAME"": ""Гагарин"",
      ""PARENT_REGION_ID"": ""1262864"",
      ""PARENT_REGION_NAME"": ""Смоленская область"",
      ""FO_ID"": ""9000001""
  },
  {
      ""CITY_OKATO_ID"": ""66214501000"",
      ""NAME"": ""Дорогобуж"",
      ""PARENT_REGION_ID"": ""1262864"",
      ""PARENT_REGION_NAME"": ""Смоленская область"",
      ""FO_ID"": ""9000001""
  },
  {
      ""CITY_OKATO_ID"": ""66410000000"",
      ""NAME"": ""Десногорск"",
      ""PARENT_REGION_ID"": ""1262864"",
      ""PARENT_REGION_NAME"": ""Смоленская область"",
      ""FO_ID"": ""9000001""
  },
  {
      ""CITY_OKATO_ID"": ""66236501000"",
      ""NAME"": ""Рославль"",
      ""PARENT_REGION_ID"": ""1262864"",
      ""PARENT_REGION_NAME"": ""Смоленская область"",
      ""FO_ID"": ""9000001""
  },
  {
      ""CITY_OKATO_ID"": ""3401370000"",
      ""NAME"": ""Краснодар"",
      ""PARENT_REGION_ID"": ""1120524"",
      ""PARENT_REGION_NAME"": ""Краснодарский край"",
      ""FO_ID"": ""9000002""
  },
  {
      ""CITY_OKATO_ID"": ""3405000000"",
      ""NAME"": ""Армавир"",
      ""PARENT_REGION_ID"": ""1120524"",
      ""PARENT_REGION_NAME"": ""Краснодарский край"",
      ""FO_ID"": ""9000002""
  },
  {
      ""CITY_OKATO_ID"": ""3408000000"",
      ""NAME"": ""Геленджик"",
      ""PARENT_REGION_ID"": ""1120524"",
      ""PARENT_REGION_NAME"": ""Краснодарский край"",
      ""FO_ID"": ""9000002""
  },
  {
      ""CITY_OKATO_ID"": ""3426000000"",
      ""NAME"": ""Сочи"",
      ""PARENT_REGION_ID"": ""1120524"",
      ""PARENT_REGION_NAME"": ""Краснодарский край"",
      ""FO_ID"": ""9000002""
  },
  {
      ""CITY_OKATO_ID"": ""3420000000"",
      ""NAME"": ""Новороссийск"",
      ""PARENT_REGION_ID"": ""1120524"",
      ""PARENT_REGION_NAME"": ""Краснодарский край"",
      ""FO_ID"": ""9000002""
  },
  {
      ""CITY_OKATO_ID"": ""18401380000"",
      ""NAME"": ""Волгоград"",
      ""PARENT_REGION_ID"": ""1143778"",
      ""PARENT_REGION_NAME"": ""Волгоградская область"",
      ""FO_ID"": ""9000002""
  },
  {
      ""CITY_OKATO_ID"": ""18425000000"",
      ""NAME"": ""Урюпинск"",
      ""PARENT_REGION_ID"": ""1143779"",
      ""PARENT_REGION_NAME"": ""Волгоградская область"",
      ""FO_ID"": ""9000002""
  },
  {
      ""CITY_OKATO_ID"": ""18410000000"",
      ""NAME"": ""Волжский"",
      ""PARENT_REGION_ID"": ""1143780"",
      ""PARENT_REGION_NAME"": ""Волгоградская область"",
      ""FO_ID"": ""9000002""
  },
  {
      ""CITY_OKATO_ID"": ""18415000000"",
      ""NAME"": ""Камышин"",
      ""PARENT_REGION_ID"": ""1143781"",
      ""PARENT_REGION_NAME"": ""Волгоградская область"",
      ""FO_ID"": ""9000002""
  },
  {
      ""CITY_OKATO_ID"": ""18428000000"",
      ""NAME"": ""Фролово"",
      ""PARENT_REGION_ID"": ""1143782"",
      ""PARENT_REGION_NAME"": ""Волгоградская область"",
      ""FO_ID"": ""9000002""
  },
  {
      ""CITY_OKATO_ID"": ""35401000000"",
      ""NAME"": ""Симферополь"",
      ""PARENT_REGION_ID"": ""2200002"",
      ""PARENT_REGION_NAME"": ""Республика Крым"",
      ""FO_ID"": ""9000002""
  },
  {
      ""CITY_OKATO_ID"": ""35412000000"",
      ""NAME"": ""Керчь"",
      ""PARENT_REGION_ID"": ""2200002"",
      ""PARENT_REGION_NAME"": ""Республика Крым"",
      ""FO_ID"": ""9000002""
  },
  {
      ""CITY_OKATO_ID"": ""35419000000"",
      ""NAME"": ""Ялта"",
      ""PARENT_REGION_ID"": ""2200002"",
      ""PARENT_REGION_NAME"": ""Республика Крым"",
      ""FO_ID"": ""9000002""
  },
  {
      ""CITY_OKATO_ID"": ""35417000000"",
      ""NAME"": ""Феодосия"",
      ""PARENT_REGION_ID"": ""2200002"",
      ""PARENT_REGION_NAME"": ""Республика Крым"",
      ""FO_ID"": ""9000002""
  },
  {
      ""CITY_OKATO_ID"": ""35409000000"",
      ""NAME"": ""Евпатория"",
      ""PARENT_REGION_ID"": ""2200002"",
      ""PARENT_REGION_NAME"": ""Республика Крым"",
      ""FO_ID"": ""9000002""
  },
  {
      ""CITY_OKATO_ID"": ""67269000000"",
      ""NAME"": ""Севастополь"",
      ""PARENT_REGION_ID"": ""2200003"",
      ""PARENT_REGION_NAME"": ""Севастополь"",
      ""FO_ID"": ""9000002""
  },
  {
      ""CITY_OKATO_ID"": ""67263505000"",
      ""NAME"": ""Инкерман"",
      ""PARENT_REGION_ID"": ""2200003"",
      ""PARENT_REGION_NAME"": ""Севастополь"",
      ""FO_ID"": ""9000002""
  },
  {
      ""CITY_OKATO_ID"": ""60401000000"",
      ""NAME"": ""Ростов-на-Дону"",
      ""PARENT_REGION_ID"": ""1249220"",
      ""PARENT_REGION_NAME"": ""Ростовская область"",
      ""FO_ID"": ""9000002""
  },
  {
      ""CITY_OKATO_ID"": ""60437000000"",
      ""NAME"": ""Таганрог"",
      ""PARENT_REGION_ID"": ""1249220"",
      ""PARENT_REGION_NAME"": ""Ростовская область"",
      ""FO_ID"": ""9000002""
  },
  {
      ""CITY_OKATO_ID"": ""60407000000"",
      ""NAME"": ""Батайск"",
      ""PARENT_REGION_ID"": ""1249220"",
      ""PARENT_REGION_NAME"": ""Ростовская область"",
      ""FO_ID"": ""9000002""
  },
  {
      ""CITY_OKATO_ID"": ""60440000000"",
      ""NAME"": ""Шахты"",
      ""PARENT_REGION_ID"": ""1249220"",
      ""PARENT_REGION_NAME"": ""Ростовская область"",
      ""FO_ID"": ""9000002""
  },
  {
      ""CITY_OKATO_ID"": ""60412000000"",
      ""NAME"": ""Волгодонск"",
      ""PARENT_REGION_ID"": ""1249220"",
      ""PARENT_REGION_NAME"": ""Ростовская область"",
      ""FO_ID"": ""9000002""
  },
  {
      ""CITY_OKATO_ID"": ""40000000000"",
      ""NAME"": ""Санкт-Петербург"",
      ""PARENT_REGION_ID"": ""1203936"",
      ""PARENT_REGION_NAME"": ""Санкт-Петербург"",
      ""FO_ID"": ""9000003""
  },
  {
      ""CITY_OKATO_ID"": ""40281520000"",
      ""NAME"": ""Сестрорецк"",
      ""PARENT_REGION_ID"": ""1203936"",
      ""PARENT_REGION_NAME"": ""Санкт-Петербург"",
      ""FO_ID"": ""9000003""
  },
  {
      ""CITY_OKATO_ID"": ""40280000000"",
      ""NAME"": ""Кронштадт"",
      ""PARENT_REGION_ID"": ""1203936"",
      ""PARENT_REGION_NAME"": ""Санкт-Петербург"",
      ""FO_ID"": ""9000003""
  },
  {
      ""CITY_OKATO_ID"": ""40277000000"",
      ""NAME"": ""Колпино"",
      ""PARENT_REGION_ID"": ""1203936"",
      ""PARENT_REGION_NAME"": ""Санкт-Петербург"",
      ""FO_ID"": ""9000003""
  },
  {
      ""CITY_OKATO_ID"": ""40281509000"",
      ""NAME"": ""Зеленогорск"",
      ""PARENT_REGION_ID"": ""1203936"",
      ""PARENT_REGION_NAME"": ""Санкт-Петербург"",
      ""FO_ID"": ""9000003""
  },
  {
      ""CITY_OKATO_ID"": ""41417000000"",
      ""NAME"": ""Выборг"",
      ""PARENT_REGION_ID"": ""1204092"",
      ""PARENT_REGION_NAME"": ""Ленинградская область"",
      ""FO_ID"": ""9000003""
  },
  {
      ""CITY_OKATO_ID"": ""41466000000"",
      ""NAME"": ""Тосно"",
      ""PARENT_REGION_ID"": ""1204092"",
      ""PARENT_REGION_NAME"": ""Ленинградская область"",
      ""FO_ID"": ""9000003""
  },
  {
      ""CITY_OKATO_ID"": ""41413000000"",
      ""NAME"": ""Всеволожск"",
      ""PARENT_REGION_ID"": ""1204092"",
      ""PARENT_REGION_NAME"": ""Ленинградская область"",
      ""FO_ID"": ""9000003""
  },
  {
      ""CITY_OKATO_ID"": ""41448000000"",
      ""NAME"": ""Приозерск"",
      ""PARENT_REGION_ID"": ""1204092"",
      ""PARENT_REGION_NAME"": ""Ленинградская область"",
      ""FO_ID"": ""9000003""
  },
  {
      ""CITY_OKATO_ID"": ""41454000000"",
      ""NAME"": ""Сосновый Бор"",
      ""PARENT_REGION_ID"": ""1204092"",
      ""PARENT_REGION_NAME"": ""Ленинградская область"",
      ""FO_ID"": ""9000003""
  },
  {
      ""CITY_OKATO_ID"": ""86401000000"",
      ""NAME"": ""Петрозаводск"",
      ""PARENT_REGION_ID"": ""1300033"",
      ""PARENT_REGION_NAME"": ""Республика Карелия"",
      ""FO_ID"": ""9000003""
  },
  {
      ""CITY_OKATO_ID"": ""86224501000"",
      ""NAME"": ""Медвежьегорск"",
      ""PARENT_REGION_ID"": ""1300033"",
      ""PARENT_REGION_NAME"": ""Республика Карелия"",
      ""FO_ID"": ""9000003""
  },
  {
      ""CITY_OKATO_ID"": ""86215501000"",
      ""NAME"": ""Кондопога"",
      ""PARENT_REGION_ID"": ""1300033"",
      ""PARENT_REGION_NAME"": ""Республика Карелия"",
      ""FO_ID"": ""9000003""
  },
  {
      ""CITY_OKATO_ID"": ""86410000000"",
      ""NAME"": ""Сортавала"",
      ""PARENT_REGION_ID"": ""1300033"",
      ""PARENT_REGION_NAME"": ""Республика Карелия"",
      ""FO_ID"": ""9000003""
  },
  {
      ""CITY_OKATO_ID"": ""86406000000"",
      ""NAME"": ""Костомукша"",
      ""PARENT_REGION_ID"": ""1300033"",
      ""PARENT_REGION_NAME"": ""Республика Карелия"",
      ""FO_ID"": ""9000003""
  },
  {
      ""CITY_OKATO_ID"": ""47401000000"",
      ""NAME"": ""Мурманск"",
      ""PARENT_REGION_ID"": ""1217738"",
      ""PARENT_REGION_NAME"": ""Мурманская область"",
      ""FO_ID"": ""9000003""
  },
  {
      ""CITY_OKATO_ID"": ""47530000000"",
      ""NAME"": ""Североморск"",
      ""PARENT_REGION_ID"": ""1217738"",
      ""PARENT_REGION_NAME"": ""Мурманская область"",
      ""FO_ID"": ""9000003""
  },
  {
      ""CITY_OKATO_ID"": ""47412000000"",
      ""NAME"": ""Кировск"",
      ""PARENT_REGION_ID"": ""1217738"",
      ""PARENT_REGION_NAME"": ""Мурманская область"",
      ""FO_ID"": ""9000003""
  },
  {
      ""CITY_OKATO_ID"": ""47417000000"",
      ""NAME"": ""Оленегорск"",
      ""PARENT_REGION_ID"": ""1217738"",
      ""PARENT_REGION_NAME"": ""Мурманская область"",
      ""FO_ID"": ""9000003""
  },
  {
      ""CITY_OKATO_ID"": ""47202501000"",
      ""NAME"": ""Кандалакша"",
      ""PARENT_REGION_ID"": ""1217738"",
      ""PARENT_REGION_NAME"": ""Мурманская область"",
      ""FO_ID"": ""9000003""
  },
  {
      ""CITY_OKATO_ID"": ""49401000000"",
      ""NAME"": ""Новгород Великий"",
      ""PARENT_REGION_ID"": ""1217915"",
      ""PARENT_REGION_NAME"": ""Новгородская область"",
      ""FO_ID"": ""9000003""
  },
  {
      ""CITY_OKATO_ID"": ""49413000000"",
      ""NAME"": ""Старая Русса"",
      ""PARENT_REGION_ID"": ""1217915"",
      ""PARENT_REGION_NAME"": ""Новгородская область"",
      ""FO_ID"": ""9000003""
  },
  {
      ""CITY_OKATO_ID"": ""49208501000"",
      ""NAME"": ""Валдай"",
      ""PARENT_REGION_ID"": ""1217915"",
      ""PARENT_REGION_NAME"": ""Новгородская область"",
      ""FO_ID"": ""9000003""
  },
  {
      ""CITY_OKATO_ID"": ""49250501000"",
      ""NAME"": ""Чудово"",
      ""PARENT_REGION_ID"": ""1217915"",
      ""PARENT_REGION_NAME"": ""Новгородская область"",
      ""FO_ID"": ""9000003""
  },
  {
      ""CITY_OKATO_ID"": ""49228501000"",
      ""NAME"": ""Окуловка"",
      ""PARENT_REGION_ID"": ""1217915"",
      ""PARENT_REGION_NAME"": ""Новгородская область"",
      ""FO_ID"": ""9000003""
  }
]
";

        private static readonly string _routesJsonStr = @"
[
  {
      ""ID"": ""1"",
      ""PARENT_REGION_ID"": ""1209975"",
      ""VALUE_SUM"": ""167"",
      ""VALUE_WOMEN_KID"": ""10"",
      ""VALUE_WOMEN_ADULT"": ""40"",
      ""VALUE_WOMEN_SENIOR"": ""25"",
      ""VALUE_MEN_KID"": ""9"",
      ""VALUE_MEN_ADULT"": ""50"",
      ""VALUE_MEN_SENIOR"": ""33"",
      ""REGION_NAME"": ""Москва"",
      ""CITY_FROM_ID"": ""45000000000"",
      ""CITY_TO_ID"": ""46221501000"",
      ""CITY_FROM"": ""Москва"",
      ""CITY_TO"": ""Клин""
  },
  {
      ""ID"": ""2"",
      ""PARENT_REGION_ID"": ""1209975"",
      ""VALUE_SUM"": ""167"",
      ""VALUE_WOMEN_KID"": ""60"",
      ""VALUE_WOMEN_ADULT"": ""190"",
      ""VALUE_WOMEN_SENIOR"": ""40"",
      ""VALUE_MEN_KID"": ""50"",
      ""VALUE_MEN_ADULT"": ""185"",
      ""VALUE_MEN_SENIOR"": ""50"",
      ""REGION_NAME"": ""Москва"",
      ""CITY_FROM_ID"": ""45000000000"",
      ""CITY_TO_ID"": ""46241501000"",
      ""CITY_FROM"": ""Москва"",
      ""CITY_TO"": ""Одинцово""
  },
  {
      ""ID"": ""3"",
      ""PARENT_REGION_ID"": ""1209975"",
      ""VALUE_SUM"": ""575"",
      ""VALUE_WOMEN_KID"": ""170"",
      ""VALUE_WOMEN_ADULT"": ""350"",
      ""VALUE_WOMEN_SENIOR"": ""220"",
      ""VALUE_MEN_KID"": ""140"",
      ""VALUE_MEN_ADULT"": ""420"",
      ""VALUE_MEN_SENIOR"": ""300"",
      ""REGION_NAME"": ""Москва"",
      ""CITY_FROM_ID"": ""45000000000"",
      ""CITY_TO_ID"": ""46483000000"",
      ""CITY_FROM"": ""Москва"",
      ""CITY_TO"": ""Химки""
  },
  {
      ""ID"": ""4"",
      ""PARENT_REGION_ID"": ""1171031"",
      ""VALUE_SUM"": ""81"",
      ""VALUE_WOMEN_KID"": ""2"",
      ""VALUE_WOMEN_ADULT"": ""24"",
      ""VALUE_WOMEN_SENIOR"": ""13"",
      ""VALUE_MEN_KID"": ""3"",
      ""VALUE_MEN_ADULT"": ""25"",
      ""VALUE_MEN_SENIOR"": ""14"",
      ""REGION_NAME"": ""Тверская область"",
      ""CITY_FROM_ID"": ""28401000000"",
      ""CITY_TO_ID"": ""28222501000"",
      ""CITY_FROM"": ""Тверь"",
      ""CITY_TO"": ""Калязин""
  },
  {
      ""ID"": ""5"",
      ""PARENT_REGION_ID"": ""1171031"",
      ""VALUE_SUM"": ""55"",
      ""VALUE_WOMEN_KID"": ""5"",
      ""VALUE_WOMEN_ADULT"": ""18"",
      ""VALUE_WOMEN_SENIOR"": ""7"",
      ""VALUE_MEN_KID"": ""4"",
      ""VALUE_MEN_ADULT"": ""15"",
      ""VALUE_MEN_SENIOR"": ""6"",
      ""REGION_NAME"": ""Тверская область"",
      ""CITY_FROM_ID"": ""28222501000"",
      ""CITY_TO_ID"": ""28450000000"",
      ""CITY_FROM"": ""Калязин"",
      ""CITY_TO"": ""Торжок""
  },
  {
      ""ID"": ""6"",
      ""PARENT_REGION_ID"": ""1171031"",
      ""VALUE_SUM"": ""43"",
      ""VALUE_WOMEN_KID"": ""3"",
      ""VALUE_WOMEN_ADULT"": ""15"",
      ""VALUE_WOMEN_SENIOR"": ""3"",
      ""VALUE_MEN_KID"": ""4"",
      ""VALUE_MEN_ADULT"": ""15"",
      ""VALUE_MEN_SENIOR"": ""3"",
      ""REGION_NAME"": ""Тверская область"",
      ""CITY_FROM_ID"": ""28401000000"",
      ""CITY_TO_ID"": ""28445000000"",
      ""CITY_FROM"": ""Тверь"",
      ""CITY_TO"": ""Ржев""
  },
  {
      ""ID"": ""7"",
      ""PARENT_REGION_ID"": ""1203936"",
      ""VALUE_SUM"": ""805"",
      ""VALUE_WOMEN_KID"": ""110"",
      ""VALUE_WOMEN_ADULT"": ""180"",
      ""VALUE_WOMEN_SENIOR"": ""120"",
      ""VALUE_MEN_KID"": ""100"",
      ""VALUE_MEN_ADULT"": ""190"",
      ""VALUE_MEN_SENIOR"": ""105"",
      ""REGION_NAME"": ""Санкт-Петербург"",
      ""CITY_FROM_ID"": ""40000000000"",
      ""CITY_TO_ID"": ""41417000000"",
      ""CITY_FROM"": ""Санкт-Петербург"",
      ""CITY_TO"": ""Выборг""
  },
  {
      ""ID"": ""8"",
      ""PARENT_REGION_ID"": ""1203936"",
      ""VALUE_SUM"": ""370"",
      ""VALUE_WOMEN_KID"": ""20"",
      ""VALUE_WOMEN_ADULT"": ""90"",
      ""VALUE_WOMEN_SENIOR"": ""70"",
      ""VALUE_MEN_KID"": ""30"",
      ""VALUE_MEN_ADULT"": ""110"",
      ""VALUE_MEN_SENIOR"": ""50"",
      ""REGION_NAME"": ""Санкт-Петербург"",
      ""CITY_FROM_ID"": ""40000000000"",
      ""CITY_TO_ID"": ""41448000000"",
      ""CITY_FROM"": ""Санкт-Петербург"",
      ""CITY_TO"": ""Приозерск""
  },
  {
      ""ID"": ""9"",
      ""PARENT_REGION_ID"": ""1203936"",
      ""VALUE_SUM"": ""820"",
      ""VALUE_WOMEN_KID"": ""70"",
      ""VALUE_WOMEN_ADULT"": ""220"",
      ""VALUE_WOMEN_SENIOR"": ""150"",
      ""VALUE_MEN_KID"": ""80"",
      ""VALUE_MEN_ADULT"": ""190"",
      ""VALUE_MEN_SENIOR"": ""110"",
      ""REGION_NAME"": ""Санкт-Петербург"",
      ""CITY_FROM_ID"": ""40000000000"",
      ""CITY_TO_ID"": ""40277000000"",
      ""CITY_FROM"": ""Санкт-Петербург"",
      ""CITY_TO"": ""Колпино""
  },
  {
      ""ID"": ""10"",
      ""PARENT_REGION_ID"": ""1300033"",
      ""VALUE_SUM"": ""220"",
      ""VALUE_WOMEN_KID"": ""30"",
      ""VALUE_WOMEN_ADULT"": ""60"",
      ""VALUE_WOMEN_SENIOR"": ""15"",
      ""VALUE_MEN_KID"": ""25"",
      ""VALUE_MEN_ADULT"": ""80"",
      ""VALUE_MEN_SENIOR"": ""10"",
      ""REGION_NAME"": ""Карелия"",
      ""CITY_FROM_ID"": ""86401000000"",
      ""CITY_TO_ID"": ""86215501000"",
      ""CITY_FROM"": ""Петрозаводск"",
      ""CITY_TO"": ""Кондопога""
  },
  {
      ""ID"": ""11"",
      ""PARENT_REGION_ID"": ""1300033"",
      ""VALUE_SUM"": ""165"",
      ""VALUE_WOMEN_KID"": ""20"",
      ""VALUE_WOMEN_ADULT"": ""45"",
      ""VALUE_WOMEN_SENIOR"": ""10"",
      ""VALUE_MEN_KID"": ""15"",
      ""VALUE_MEN_ADULT"": ""55"",
      ""VALUE_MEN_SENIOR"": ""20"",
      ""REGION_NAME"": ""Карелия"",
      ""CITY_FROM_ID"": ""86224501000"",
      ""CITY_TO_ID"": ""86410000000"",
      ""CITY_FROM"": ""Медвежьегорск"",
      ""CITY_TO"": ""Сортавала""
  },
  {
      ""ID"": ""12"",
      ""PARENT_REGION_ID"": ""1300033"",
      ""VALUE_SUM"": ""382"",
      ""VALUE_WOMEN_KID"": ""45"",
      ""VALUE_WOMEN_ADULT"": ""100"",
      ""VALUE_WOMEN_SENIOR"": ""25"",
      ""VALUE_MEN_KID"": ""52"",
      ""VALUE_MEN_ADULT"": ""130"",
      ""VALUE_MEN_SENIOR"": ""30"",
      ""REGION_NAME"": ""Карелия"",
      ""CITY_FROM_ID"": ""86410000000"",
      ""CITY_TO_ID"": ""86401000000"",
      ""CITY_FROM"": ""Сортавала"",
      ""CITY_TO"": ""Петрозаводск""
  },
  {
      ""ID"": ""13"",
      ""PARENT_REGION_ID"": ""2200003"",
      ""VALUE_SUM"": ""540"",
      ""VALUE_WOMEN_KID"": ""55"",
      ""VALUE_WOMEN_ADULT"": ""150"",
      ""VALUE_WOMEN_SENIOR"": ""70"",
      ""VALUE_MEN_KID"": ""50"",
      ""VALUE_MEN_ADULT"": ""170"",
      ""VALUE_MEN_SENIOR"": ""45"",
      ""REGION_NAME"": ""Севастополь"",
      ""CITY_FROM_ID"": ""67269000000"",
      ""CITY_TO_ID"": ""35419000000"",
      ""CITY_FROM"": ""Севастополь"",
      ""CITY_TO"": ""Ялта""
  },
  {
      ""ID"": ""14"",
      ""PARENT_REGION_ID"": ""2200003"",
      ""VALUE_SUM"": ""547"",
      ""VALUE_WOMEN_KID"": ""80"",
      ""VALUE_WOMEN_ADULT"": ""130"",
      ""VALUE_WOMEN_SENIOR"": ""90"",
      ""VALUE_MEN_KID"": ""70"",
      ""VALUE_MEN_ADULT"": ""120"",
      ""VALUE_MEN_SENIOR"": ""57"",
      ""REGION_NAME"": ""Севастополь"",
      ""CITY_FROM_ID"": ""67269000000"",
      ""CITY_TO_ID"": ""35401000000"",
      ""CITY_FROM"": ""Севастополь"",
      ""CITY_TO"": ""Симферополь""
  },
  {
      ""ID"": ""15"",
      ""PARENT_REGION_ID"": ""2200003"",
      ""VALUE_SUM"": ""252"",
      ""VALUE_WOMEN_KID"": ""30"",
      ""VALUE_WOMEN_ADULT"": ""50"",
      ""VALUE_WOMEN_SENIOR"": ""40"",
      ""VALUE_MEN_KID"": ""25"",
      ""VALUE_MEN_ADULT"": ""70"",
      ""VALUE_MEN_SENIOR"": ""37"",
      ""REGION_NAME"": ""Севастополь"",
      ""CITY_FROM_ID"": ""67269000000"",
      ""CITY_TO_ID"": ""67263505000"",
      ""CITY_FROM"": ""Севастополь"",
      ""CITY_TO"": ""Инкерман""
  },
  {
      ""ID"": ""16"",
      ""PARENT_REGION_ID"": ""2200002"",
      ""VALUE_SUM"": ""330"",
      ""VALUE_WOMEN_KID"": ""30"",
      ""VALUE_WOMEN_ADULT"": ""80"",
      ""VALUE_WOMEN_SENIOR"": ""50"",
      ""VALUE_MEN_KID"": ""40"",
      ""VALUE_MEN_ADULT"": ""90"",
      ""VALUE_MEN_SENIOR"": ""40"",
      ""REGION_NAME"": ""Крым"",
      ""CITY_FROM_ID"": ""35412000000"",
      ""CITY_TO_ID"": ""35419000000"",
      ""CITY_FROM"": ""Керчь"",
      ""CITY_TO"": ""Ялта""
  },
  {
      ""ID"": ""17"",
      ""PARENT_REGION_ID"": ""2200002"",
      ""VALUE_SUM"": ""392"",
      ""VALUE_WOMEN_KID"": ""40"",
      ""VALUE_WOMEN_ADULT"": ""90"",
      ""VALUE_WOMEN_SENIOR"": ""70"",
      ""VALUE_MEN_KID"": ""40"",
      ""VALUE_MEN_ADULT"": ""105"",
      ""VALUE_MEN_SENIOR"": ""47"",
      ""REGION_NAME"": ""Крым"",
      ""CITY_FROM_ID"": ""35412000000"",
      ""CITY_TO_ID"": ""35401000000"",
      ""CITY_FROM"": ""Керчь"",
      ""CITY_TO"": ""Симферополь""
  },
  {
      ""ID"": ""18"",
      ""PARENT_REGION_ID"": ""2200002"",
      ""VALUE_SUM"": ""341"",
      ""VALUE_WOMEN_KID"": ""33"",
      ""VALUE_WOMEN_ADULT"": ""70"",
      ""VALUE_WOMEN_SENIOR"": ""80"",
      ""VALUE_MEN_KID"": ""42"",
      ""VALUE_MEN_ADULT"": ""66"",
      ""VALUE_MEN_SENIOR"": ""50"",
      ""REGION_NAME"": ""Крым"",
      ""CITY_FROM_ID"": ""35412000000"",
      ""CITY_TO_ID"": ""35417000000"",
      ""CITY_FROM"": ""Керчь"",
      ""CITY_TO"": ""Феодосия""
  }
]
";

        private static readonly string _subjectsJsonStr = @"
[
        {
            ""REGION_ID"": ""1209975"",
            ""PARENT_REGION_ID"": ""9000001"",
            ""VALUE_SUM"": ""2342"",
            ""VALUE_WOMEN_KID"": ""240"",
            ""VALUE_WOMEN_ADULT"": ""580"",
            ""VALUE_WOMEN_SENIOR"": ""285"",
            ""VALUE_MEN_KID"": ""199"",
            ""VALUE_MEN_ADULT"": ""655"",
            ""VALUE_MEN_SENIOR"": ""383"",
            ""REGION_NAME"": ""Москва""
        },
        {
            ""REGION_ID"": ""1210475"",
            ""PARENT_REGION_ID"": ""9000001"",
            ""VALUE_SUM"": ""0"",
            ""VALUE_WOMEN_KID"": ""0"",
            ""VALUE_WOMEN_ADULT"": ""0"",
            ""VALUE_WOMEN_SENIOR"": ""0"",
            ""VALUE_MEN_KID"": ""0"",
            ""VALUE_MEN_ADULT"": ""0"",
            ""VALUE_MEN_SENIOR"": ""0"",
            ""REGION_NAME"": ""Московская область""
        },
        {
            ""REGION_ID"": ""1171031"",
            ""PARENT_REGION_ID"": ""9000001"",
            ""VALUE_SUM"": ""179"",
            ""VALUE_WOMEN_KID"": ""10"",
            ""VALUE_WOMEN_ADULT"": ""57"",
            ""VALUE_WOMEN_SENIOR"": ""23"",
            ""VALUE_MEN_KID"": ""11"",
            ""VALUE_MEN_ADULT"": ""55"",
            ""VALUE_MEN_SENIOR"": ""23"",
            ""REGION_NAME"": ""Тверская область""
        },
        {
            ""REGION_ID"": ""1181365"",
            ""PARENT_REGION_ID"": ""9000001"",
            ""VALUE_SUM"": ""0"",
            ""VALUE_WOMEN_KID"": ""0"",
            ""VALUE_WOMEN_ADULT"": ""0"",
            ""VALUE_WOMEN_SENIOR"": ""0"",
            ""VALUE_MEN_KID"": ""0"",
            ""VALUE_MEN_ADULT"": ""0"",
            ""VALUE_MEN_SENIOR"": ""0"",
            ""REGION_NAME"": ""Калужская область""
        },
        {
            ""REGION_ID"": ""1262864"",
            ""PARENT_REGION_ID"": ""9000001"",
            ""VALUE_SUM"": ""0"",
            ""VALUE_WOMEN_KID"": ""0"",
            ""VALUE_WOMEN_ADULT"": ""0"",
            ""VALUE_WOMEN_SENIOR"": ""0"",
            ""VALUE_MEN_KID"": ""0"",
            ""VALUE_MEN_ADULT"": ""0"",
            ""VALUE_MEN_SENIOR"": ""0"",
            ""REGION_NAME"": ""Смоленская область""
        },
        {
            ""REGION_ID"": ""1120524"",
            ""PARENT_REGION_ID"": ""9000002"",
            ""VALUE_SUM"": ""0"",
            ""VALUE_WOMEN_KID"": ""0"",
            ""VALUE_WOMEN_ADULT"": ""0"",
            ""VALUE_WOMEN_SENIOR"": ""0"",
            ""VALUE_MEN_KID"": ""0"",
            ""VALUE_MEN_ADULT"": ""0"",
            ""VALUE_MEN_SENIOR"": ""0"",
            ""REGION_NAME"": ""Краснодарский край""
        },
        {
            ""REGION_ID"": ""1143778"",
            ""PARENT_REGION_ID"": ""9000002"",
            ""VALUE_SUM"": ""0"",
            ""VALUE_WOMEN_KID"": ""0"",
            ""VALUE_WOMEN_ADULT"": ""0"",
            ""VALUE_WOMEN_SENIOR"": ""0"",
            ""VALUE_MEN_KID"": ""0"",
            ""VALUE_MEN_ADULT"": ""0"",
            ""VALUE_MEN_SENIOR"": ""0"",
            ""REGION_NAME"": ""Волгоградская область""
        },
        {
            ""REGION_ID"": ""2200002"",
            ""PARENT_REGION_ID"": ""9000002"",
            ""VALUE_SUM"": ""1063"",
            ""VALUE_WOMEN_KID"": ""103"",
            ""VALUE_WOMEN_ADULT"": ""240"",
            ""VALUE_WOMEN_SENIOR"": ""200"",
            ""VALUE_MEN_KID"": ""122"",
            ""VALUE_MEN_ADULT"": ""261"",
            ""VALUE_MEN_SENIOR"": ""137"",
            ""REGION_NAME"": ""Республика Крым""
        },
        {
            ""REGION_ID"": ""2200003"",
            ""PARENT_REGION_ID"": ""9000002"",
            ""VALUE_SUM"": ""1339"",
            ""VALUE_WOMEN_KID"": ""165"",
            ""VALUE_WOMEN_ADULT"": ""330"",
            ""VALUE_WOMEN_SENIOR"": ""200"",
            ""VALUE_MEN_KID"": ""145"",
            ""VALUE_MEN_ADULT"": ""360"",
            ""VALUE_MEN_SENIOR"": ""139"",
            ""REGION_NAME"": ""Севастополь""
        },
        {
            ""REGION_ID"": ""1249220"",
            ""PARENT_REGION_ID"": ""9000002"",
            ""VALUE_SUM"": ""0"",
            ""VALUE_WOMEN_KID"": ""0"",
            ""VALUE_WOMEN_ADULT"": ""0"",
            ""VALUE_WOMEN_SENIOR"": ""0"",
            ""VALUE_MEN_KID"": ""0"",
            ""VALUE_MEN_ADULT"": ""0"",
            ""VALUE_MEN_SENIOR"": ""0"",
            ""REGION_NAME"": ""Ростовская область""
        },
        {
            ""REGION_ID"": ""1203936"",
            ""PARENT_REGION_ID"": ""9000003"",
            ""VALUE_SUM"": ""1995"",
            ""VALUE_WOMEN_KID"": ""200"",
            ""VALUE_WOMEN_ADULT"": ""490"",
            ""VALUE_WOMEN_SENIOR"": ""340"",
            ""VALUE_MEN_KID"": ""210"",
            ""VALUE_MEN_ADULT"": ""490"",
            ""VALUE_MEN_SENIOR"": ""265"",
            ""REGION_NAME"": ""Санкт-Петербург""
        },
        {
            ""REGION_ID"": ""1204092"",
            ""PARENT_REGION_ID"": ""9000003"",
            ""VALUE_SUM"": ""0"",
            ""VALUE_WOMEN_KID"": ""0"",
            ""VALUE_WOMEN_ADULT"": ""0"",
            ""VALUE_WOMEN_SENIOR"": ""0"",
            ""VALUE_MEN_KID"": ""0"",
            ""VALUE_MEN_ADULT"": ""0"",
            ""VALUE_MEN_SENIOR"": ""0"",
            ""REGION_NAME"": ""Ленинградская область""
        },
        {
            ""REGION_ID"": ""1300033"",
            ""PARENT_REGION_ID"": ""9000003"",
            ""VALUE_SUM"": ""767"",
            ""VALUE_WOMEN_KID"": ""95"",
            ""VALUE_WOMEN_ADULT"": ""205"",
            ""VALUE_WOMEN_SENIOR"": ""50"",
            ""VALUE_MEN_KID"": ""92"",
            ""VALUE_MEN_ADULT"": ""265"",
            ""VALUE_MEN_SENIOR"": ""60"",
            ""REGION_NAME"": ""Республика Карелия""
        },
        {
            ""REGION_ID"": ""1217738"",
            ""PARENT_REGION_ID"": ""9000003"",
            ""VALUE_SUM"": ""0"",
            ""VALUE_WOMEN_KID"": ""0"",
            ""VALUE_WOMEN_ADULT"": ""0"",
            ""VALUE_WOMEN_SENIOR"": ""0"",
            ""VALUE_MEN_KID"": ""0"",
            ""VALUE_MEN_ADULT"": ""0"",
            ""VALUE_MEN_SENIOR"": ""0"",
            ""REGION_NAME"": ""Мурманская область""
        },
        {
            ""REGION_ID"": ""1217915"",
            ""PARENT_REGION_ID"": ""9000003"",
            ""VALUE_SUM"": ""0"",
            ""VALUE_WOMEN_KID"": ""0"",
            ""VALUE_WOMEN_ADULT"": ""0"",
            ""VALUE_WOMEN_SENIOR"": ""0"",
            ""VALUE_MEN_KID"": ""0"",
            ""VALUE_MEN_ADULT"": ""0"",
            ""VALUE_MEN_SENIOR"": ""0"",
            ""REGION_NAME"": ""Новгородская область""
        },
        {
            ""REGION_ID"": ""4"",
            ""PARENT_REGION_ID"": ""9000004"",
            ""VALUE_SUM"": ""0"",
            ""VALUE_WOMEN_KID"": ""0"",
            ""VALUE_WOMEN_ADULT"": ""0"",
            ""VALUE_WOMEN_SENIOR"": ""0"",
            ""VALUE_MEN_KID"": ""0"",
            ""VALUE_MEN_ADULT"": ""0"",
            ""VALUE_MEN_SENIOR"": ""0""
        },
        {
            ""REGION_ID"": ""5"",
            ""PARENT_REGION_ID"": ""9000005"",
            ""VALUE_SUM"": ""0"",
            ""VALUE_WOMEN_KID"": ""0"",
            ""VALUE_WOMEN_ADULT"": ""0"",
            ""VALUE_WOMEN_SENIOR"": ""0"",
            ""VALUE_MEN_KID"": ""0"",
            ""VALUE_MEN_ADULT"": ""0"",
            ""VALUE_MEN_SENIOR"": ""0""
        },
        {
            ""REGION_ID"": ""6"",
            ""PARENT_REGION_ID"": ""9000006"",
            ""VALUE_SUM"": ""0"",
            ""VALUE_WOMEN_KID"": ""0"",
            ""VALUE_WOMEN_ADULT"": ""0"",
            ""VALUE_WOMEN_SENIOR"": ""0"",
            ""VALUE_MEN_KID"": ""0"",
            ""VALUE_MEN_ADULT"": ""0"",
            ""VALUE_MEN_SENIOR"": ""0""
        },
        {
            ""REGION_ID"": ""7"",
            ""PARENT_REGION_ID"": ""9000007"",
            ""VALUE_SUM"": ""0"",
            ""VALUE_WOMEN_KID"": ""0"",
            ""VALUE_WOMEN_ADULT"": ""0"",
            ""VALUE_WOMEN_SENIOR"": ""0"",
            ""VALUE_MEN_KID"": ""0"",
            ""VALUE_MEN_ADULT"": ""0"",
            ""VALUE_MEN_SENIOR"": ""0""
        },
        {
            ""REGION_ID"": ""8"",
            ""PARENT_REGION_ID"": ""9000008"",
            ""VALUE_SUM"": ""0"",
            ""VALUE_WOMEN_KID"": ""0"",
            ""VALUE_WOMEN_ADULT"": ""0"",
            ""VALUE_WOMEN_SENIOR"": ""0"",
            ""VALUE_MEN_KID"": ""0"",
            ""VALUE_MEN_ADULT"": ""0"",
            ""VALUE_MEN_SENIOR"": ""0""
        }
    ]
";

        private static readonly string _federalDistrictJsonStr = @"
[
        {
            ""REGION_ID"": ""9000001"",
            ""VALUE_SUM"": ""0"",
            ""VALUE_WOMEN_KID"": ""0"",
            ""VALUE_WOMEN_ADULT"": ""0"",
            ""VALUE_WOMEN_SENIOR"": ""0"",
            ""VALUE_MEN_KID"": ""0"",
            ""VALUE_MEN_ADULT"": ""0"",
            ""VALUE_MEN_SENIOR"": ""0"",
            ""REGION_NAME"": ""Центральный федеральный округ"",
            ""CURATOR_ID"": ""1"",
            ""OPERATOR_ID"": ""1""
        },
        {
            ""REGION_ID"": ""9000002"",
            ""VALUE_SUM"": ""0"",
            ""VALUE_WOMEN_KID"": ""0"",
            ""VALUE_WOMEN_ADULT"": ""0"",
            ""VALUE_WOMEN_SENIOR"": ""0"",
            ""VALUE_MEN_KID"": ""0"",
            ""VALUE_MEN_ADULT"": ""0"",
            ""VALUE_MEN_SENIOR"": ""0"",
            ""REGION_NAME"": ""Южный федеральный округ"",
            ""CURATOR_ID"": ""2"",
            ""OPERATOR_ID"": ""2""
        },
        {
            ""REGION_ID"": ""9000003"",
            ""VALUE_SUM"": ""0"",
            ""VALUE_WOMEN_KID"": ""0"",
            ""VALUE_WOMEN_ADULT"": ""0"",
            ""VALUE_WOMEN_SENIOR"": ""0"",
            ""VALUE_MEN_KID"": ""0"",
            ""VALUE_MEN_ADULT"": ""0"",
            ""VALUE_MEN_SENIOR"": ""0"",
            ""REGION_NAME"": ""Северо-Западный федеральный округ"",
            ""CURATOR_ID"": ""1"",
            ""OPERATOR_ID"": ""3""
        },
        {
            ""REGION_ID"": ""9000004"",
            ""VALUE_SUM"": ""0"",
            ""VALUE_WOMEN_KID"": ""0"",
            ""VALUE_WOMEN_ADULT"": ""0"",
            ""VALUE_WOMEN_SENIOR"": ""0"",
            ""VALUE_MEN_KID"": ""0"",
            ""VALUE_MEN_ADULT"": ""0"",
            ""VALUE_MEN_SENIOR"": ""0"",
            ""REGION_NAME"": ""Дальневосточный федеральный округ"",
            ""CURATOR_ID"": ""3"",
            ""OPERATOR_ID"": ""4""
        },
        {
            ""REGION_ID"": ""9000005"",
            ""VALUE_SUM"": ""0"",
            ""VALUE_WOMEN_KID"": ""0"",
            ""VALUE_WOMEN_ADULT"": ""0"",
            ""VALUE_WOMEN_SENIOR"": ""0"",
            ""VALUE_MEN_KID"": ""0"",
            ""VALUE_MEN_ADULT"": ""0"",
            ""VALUE_MEN_SENIOR"": ""0"",
            ""REGION_NAME"": ""Сибирский федеральный округ"",
            ""CURATOR_ID"": ""3"",
            ""OPERATOR_ID"": ""5""
        },
        {
            ""REGION_ID"": ""9000006"",
            ""VALUE_SUM"": ""0"",
            ""VALUE_WOMEN_KID"": ""0"",
            ""VALUE_WOMEN_ADULT"": ""0"",
            ""VALUE_WOMEN_SENIOR"": ""0"",
            ""VALUE_MEN_KID"": ""0"",
            ""VALUE_MEN_ADULT"": ""0"",
            ""VALUE_MEN_SENIOR"": ""0"",
            ""REGION_NAME"": ""Уральский федеральный округ"",
            ""CURATOR_ID"": ""3"",
            ""OPERATOR_ID"": ""6""
        },
        {
            ""REGION_ID"": ""9000007"",
            ""VALUE_SUM"": ""0"",
            ""VALUE_WOMEN_KID"": ""0"",
            ""VALUE_WOMEN_ADULT"": ""0"",
            ""VALUE_WOMEN_SENIOR"": ""0"",
            ""VALUE_MEN_KID"": ""0"",
            ""VALUE_MEN_ADULT"": ""0"",
            ""VALUE_MEN_SENIOR"": ""0"",
            ""REGION_NAME"": ""Приволжский федеральный округ"",
            ""CURATOR_ID"": ""1"",
            ""OPERATOR_ID"": ""7""
        },
        {
            ""REGION_ID"": ""9000008"",
            ""VALUE_SUM"": ""0"",
            ""VALUE_WOMEN_KID"": ""0"",
            ""VALUE_WOMEN_ADULT"": ""0"",
            ""VALUE_WOMEN_SENIOR"": ""0"",
            ""VALUE_MEN_KID"": ""0"",
            ""VALUE_MEN_ADULT"": ""0"",
            ""VALUE_MEN_SENIOR"": ""0"",
            ""REGION_NAME"": ""Северо-Кавказский федеральный округ"",
            ""CURATOR_ID"": ""2"",
            ""OPERATOR_ID"": ""8""
        }
    ]
";

        #endregion
    }
}
