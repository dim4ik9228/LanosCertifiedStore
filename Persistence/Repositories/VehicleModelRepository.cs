﻿using Domain.Contracts.RepositoryRelated;
using Domain.Entities.VehicleRelated.Classes;
using Persistence.Contexts;
using Persistence.Repositories.Common.Classes;

namespace Persistence.Repositories;

internal class VehicleModelRepository(ApplicationDatabaseContext dbContext)
    : GenericRepository<VehicleModel>(dbContext);