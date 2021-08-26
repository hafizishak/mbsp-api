using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Iaf.API.Data.Email;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Iaf.API.Controllers.Email
{
    [ApiController]
    [Route("[controller]")]
    public class Email : ControllerBase
    {
        private readonly IEmailSender _emailSender;
        public Email(IEmailSender emailSender)
        {
            _emailSender = emailSender;

        }
        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();

            var message = new Message(new string[] { "muhammad-hafiz.ishak@inari-amertron.com.my" }, new string[] { "muhammad-hafiz.ishak@inari-amertron.com.my" }, "Test email", "This is the content from our email.", null);
            _emailSender.SendEmail(message);

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55)
            })
            .ToArray();
        }
        [HttpPost("create")]
        public async Task<IEnumerable<WeatherForecast>> Post()
        {
            var rng = new Random();
        
            var files = Request.Form.Files.Any() ? Request.Form.Files : new FormFileCollection();
        
            // var message = new Message(new string[] { "muhammad-hafiz.ishak@inari-amertron.com.my" }, new string[] { "muhammad-hafiz.ishak@inari-amertron.com.my" }, "Test mail with Attachments", "This is the content from our mail with attachments.", files);
            var message = new Message(new string[] { "muhammad-hafiz.ishak@inari-amertron.com.my" }, new string[] { "muhammad-hafiz.ishak@inari-amertron.com.my" }, "Test mail with Attachments", "This is the content from our mail with attachments.", null);
            await _emailSender.SendEmailAsync(message);
        
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55)
            })
            .ToArray();
        }        
    }
}