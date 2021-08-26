using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Iaf.API.Data;
using Iaf.API.DTO;
using Iaf.API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
namespace Iaf.API.Controllers
{
    [Authorize]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]    
    public class AttachmentController : ControllerBase
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly IAttachmentRepository _repository;
        private readonly IMapper _mapper;
        private IWebHostEnvironment _hostingEnvironment;

        public AttachmentController(IAttachmentRepository repository, ITicketRepository ticketRepository, IWebHostEnvironment webHostEnvironment, IMapper mapper)
        {
            _mapper = mapper;
            _ticketRepository = ticketRepository;
            _repository = repository;
            _hostingEnvironment = webHostEnvironment;
        }

        // GET api/values
        [HttpGet]
        public async Task<IActionResult> GetValues()
        {
            var val = await _repository.GetAllAttachment();

            return Ok(val);
        }

        // GET api/values/5
        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetValue(int id)
        {
            var value = await _repository.GetAttachment(id);

            //var valuetoReturn = _mapper.Map<Ticket>(value);

            return Ok(value);

        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] AttachmentDTO attachmentDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            //if (await _repository.UserExists (userForRegisterDto.Username))
            //return BadRequest ("Username already exist");

            //List<TicketDTO> ticketsDTO = ticketDTO.TicketDetailDTO;

            //var ticketToCreate = ticketDTO;
            var attachment = new Attachment
            {
                TicketId = attachmentDTO.TicketId,
                FileName = attachmentDTO.FileName,
                FileType = attachmentDTO.FileType,
                CreatedBy = attachmentDTO.CreatedBy,
                CreatedOn = attachmentDTO.CreatedOn,
                Deleted = attachmentDTO.Deleted
            };

            var attachments = await _repository.Create(attachment);


            //return CreatedAtRoute
            return StatusCode(201);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [HttpGet("download")]
        public async Task<IActionResult> Download([FromQuery] string file)
        {
           var uploads = Path.Combine(_hostingEnvironment.WebRootPath, "Upload//" + file.Split('-')[0]);
           var filePath = Path.Combine(uploads, file);
           if (!System.IO.File.Exists(filePath))
               return NotFound();
 
           var memory = new MemoryStream();
           using (var stream = new FileStream(filePath, FileMode.Open))
           {
               await stream.CopyToAsync(memory);
           }
           memory.Position = 0;
 
           return File(memory, GetContentType(filePath), file);
        }        

        [HttpPost("uploadFile"), DisableRequestSizeLimit]
        public IActionResult UploadFile()
        {
            try
            {
                if(Request.Form.Files.Count > 0){
                    var file = Request.Form.Files[0];

                    if(file == null)
                        return Ok("Tadak");
                    
                    string folderName = "Upload\\" + ContentDispositionHeaderValue.Parse(file.ContentDisposition).Name.Trim('"').Split('-')[0];
                    string webRootPath = _hostingEnvironment.WebRootPath;

                    if (string.IsNullOrWhiteSpace(webRootPath))
                    {
                        webRootPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
                    }
                    
                    string newPath = Path.Combine(webRootPath, folderName);

                    if (!Directory.Exists(newPath))
                    {
                        Directory.CreateDirectory(newPath);
                    }

                    if (file.Length > 0)
                    {
                        string fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).Name.Trim('"');
                        string fullPath = Path.Combine(newPath, fileName);
                        using (var stream = new FileStream(fullPath, FileMode.Create))
                        {
                            file.CopyTo(stream);
                        }
                    }

                    return Ok("Upload Successful.");
                    
                }else
                    return Ok("Upload Fail. File Empty");
                
            }
            catch (System.Exception ex)
            {
                return Ok("Upload Failed: " + ex.Message);
                //return Ok("Upload Failed: Test");
            }
        }  

        [HttpPost("uploadFilePDF"), DisableRequestSizeLimit]
        public IActionResult uploadFilePDF()
        {
            try
            {
                if(Request.Form.Files.Count > 0){
                    var file = Request.Form.Files[0];

                    if(file == null)
                        return Ok("Tadak");
                    
                    string folderName = "Upload\\" + ContentDispositionHeaderValue.Parse(file.ContentDisposition).Name.Trim('"').Split('-')[0];
                    string webRootPath = _hostingEnvironment.WebRootPath;

                    if (string.IsNullOrWhiteSpace(webRootPath))
                    {
                        webRootPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
                    }
                    
                    string newPath = Path.Combine(webRootPath, folderName);

                    if (!Directory.Exists(newPath))
                    {
                        Directory.CreateDirectory(newPath);
                    }

                    if (file.Length > 0)
                    {
                        string fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).Name.Trim('"') + ".pdf";
                        string fullPath = Path.Combine(newPath, fileName);

                        if(System.IO.File.Exists(fullPath)){
                            using (var stream = System.IO.File.Open(fullPath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
                            {
                                file.CopyTo(stream);
                                stream.Close();
                                //stream.Dispose();
                            }                               
                        }else{
                            using (var stream = new FileStream(fullPath, FileMode.Create))
                            {
                                file.CopyTo(stream);
                                stream.Close();
                                //stream.Dispose();
                            }                            
                        }
                    }

                    return Ok("Upload Successful.");
                    
                }else
                    return Ok("Upload Fail. File Empty");
                
            }
            catch (System.Exception ex)
            {
                return Ok("Upload Failed: " + ex.Message);
                //return Ok("Upload Failed: Test");
            }
        }            
       private string GetContentType(string path)
       {
           var provider = new FileExtensionContentTypeProvider();
           string contentType;
           if(!provider.TryGetContentType(path, out contentType))
           {
               contentType = "application/octet-stream";
           }
           return contentType;
       }                     
    }
}