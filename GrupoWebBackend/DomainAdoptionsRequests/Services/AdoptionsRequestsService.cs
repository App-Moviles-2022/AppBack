using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GrupoWebBackend.DomainAdoptionsRequests.Domain.Models;
using GrupoWebBackend.DomainAdoptionsRequests.Domain.Repositories;
using GrupoWebBackend.DomainAdoptionsRequests.Domain.Services;
using GrupoWebBackend.DomainPets.Domain.Repositories;
using GrupoWebBackend.Shared.Persistence.Repositories;
using GrupoWebBackend.Shared.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using GrupoWebBackend.DomainAdoptionsRequests.Domain.Services.Communications;
using GrupoWebBackend.DomainPublications.Domain.Repositories;
using GrupoWebBackend.DomainReport;
using GrupoWebBackend.Security.Domain.Repositories;
using GrupoWebBackend.Shared.Domain.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GrupoWebBackend.DomainAdoptionsRequests.Services
{
    public class AdoptionsRequestsService:IAdoptionsRequestsService
    {
        
    }
}