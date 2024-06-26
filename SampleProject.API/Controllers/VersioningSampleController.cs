﻿using Asp.Versioning;
using BuildingBlocks.API.Controllers;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace SampleProject.API.Controllers;

[ApiVersion("1")]
[ApiVersion("2")]
[Route("v{version:apiVersion}/[controller]")]
[SwaggerTag("VersioningSample Service")]
public class VersioningSampleController : BaseController
{
    [HttpGet]
    [MapToApiVersion("1")]
    public IActionResult RedirectTestV1()
    {
        return Redirect("https://www.google.com/");
    }

    [HttpGet]
    [MapToApiVersion("2")]
    public IActionResult RedirectTestV2()
    {
        return Redirect("https://www.bing.com/");
    }
}