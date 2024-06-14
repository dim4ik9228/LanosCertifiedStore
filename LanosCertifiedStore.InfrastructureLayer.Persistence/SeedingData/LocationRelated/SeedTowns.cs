﻿using Persistence.Entities.VehicleRelated.LocationRelated;

namespace Persistence.SeedingData.LocationRelated;

internal static class SeedTowns
{
    public static List<VehicleLocationTownEntity> GetTowns(
        ICollection<VehicleLocationRegionEntity> regions,
        ICollection<VehicleLocationAreaEntity> areas,
        Dictionary<string, Dictionary<string, List<string>>> regionAreaTownDictionary) =>
        regionAreaTownDictionary.SelectMany(
            regionAreaPair => regionAreaPair.Value.SelectMany(
                areaTownPair => areaTownPair.Value.Select(
                    town => new VehicleLocationTownEntity(town)
                    {
                        LocationRegionId = regions.Single(
                            r => r.Name.Equals(regionAreaPair.Key)).Id,
                        LocationAreaId = areas.Single(
                            r => r.Name.Equals(areaTownPair.Key)).Id,
                    }))).ToList();
}