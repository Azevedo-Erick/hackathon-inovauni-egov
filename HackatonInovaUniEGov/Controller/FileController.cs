using Microsoft.AspNetCore.Mvc;

namespace HackatonInovaUniEGov.Controller;

[ApiController]
[Route("api/file")]
public class FileController : ControllerBase
{
    
    [HttpPost("upload")]
    public async Task<IActionResult> Create([FromForm] IFormFile file)
    {
        Console.WriteLine("AQUI");
        string newFileName = Guid.NewGuid() + Path.GetExtension(file.FileName);
        string filePath = Path.Combine("./files", newFileName);
        await using var fileOutput = new FileStream(filePath, FileMode.Create);
      
        await file.OpenReadStream().CopyToAsync(fileOutput);
        
        var url = Url.Content($"~/api/file/{newFileName}");
        return Ok(new { Url = url});
    }
    
    [HttpGet("{fileName}")]
    public async Task<IActionResult> Find([FromRoute] string fileName)
    {
        try
        {

       
            string filePath = Path.Combine("./files", fileName);

            if (!System.IO.File.Exists(filePath))
            {
                return null;
            }
            
            
            var file =  System.IO.File.OpenRead(filePath);
            var mimeType = "application/text";

            return await Task.FromResult(new FileStreamResult(file, mimeType));
        }
        catch (Exception e)
        {
            return Ok();
        }
    }



}
