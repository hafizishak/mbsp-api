using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Iaf.API.Data;
using Iaf.API.DTO;
using Iaf.API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Iaf.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly ITicketRepository _repository;
        private readonly IAttachmentRepository _attachmentRepository;
        private readonly IMapper _mapper;
        private readonly IAuthRepository _authRepository;

        public TicketController(ITicketRepository repository, IAttachmentRepository attachmentRepository, IMapper mapper, IAuthRepository authRepository)
        {
            _mapper = mapper;
            _repository = repository;
            _attachmentRepository = attachmentRepository;
            _authRepository = authRepository;
        }       
    }
}