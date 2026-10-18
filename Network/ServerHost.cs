using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using MobileServer.Service;

namespace MobileServer.Network
{
    public class ServerHost
    {

         public void startserver()
        {
            var f1 = new FileService();
            Task.Run(() => 
            {
                var builder = WebApplication.CreateBuilder();
                var app = builder.Build();
                //اگه بنویسم پینگ 110 رو برمیگردونه
                app.MapGet("/ping", () => "110");
                app.MapGet("/file1", () =>
                {

                    if (File.Exists(f1.folder) == true)
                    {
                        return File(f1.folder);
                    }
                    else
                    {
                        return "error404";
                    }
                });
                //عبارت لامبادا هست این کصکش پایینی
                app.MapPost("/upload", async (IFormFile file) =>
                {
                   await f1.SaveFile(file);
                return  "succesful get it:" + file.FileName;
                }).DisableAntiforgery();
                app.Run("http://0.0.0.0:5000");

            });
        }
    }
}