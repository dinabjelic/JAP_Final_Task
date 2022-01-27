using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PdfSharpCore;
using PdfSharpCore.Pdf;
using RecipesApp.Core.Responses;
using RecipesApp.Database;
using RecipesApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TheArtOfDev.HtmlRenderer.PdfSharp;

namespace RecipesApp.Services.Services
{
    public class ReportJobService : IReportJobService
    {
        private readonly RecipesDbContext _context;
        private readonly IMapper _mapper;

        public ReportJobService(RecipesDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task  GetRecipesAsync()
        {
            var document = new PdfDocument();
            var recipes = await _context.Recipes.ToListAsync();

            if (recipes == null)
            {
                throw new ArgumentException("Invalid data");
            }
            var recipeDetails = _mapper.Map<List<GetRecipesResponse>>(recipes);
           
            PdfGenerator.AddPdfPages(document, ReportView(recipeDetails), PageSize.A3);

            Byte[] res = null;

            using (MemoryStream ms = new MemoryStream())
            {
                document.Save(ms);
                res = ms.ToArray();
            }

            string Base64String = Convert.ToBase64String(res);

            var reportName = $"{Guid.NewGuid().ToString()}_recipes.pdf";

            System.IO.File.WriteAllBytes($@"C:\Users\DinaBjelic\Documents\{reportName}", Convert.FromBase64String(Base64String));
        }

        private string ReportView(List<GetRecipesResponse> recipeDetails)
        {
            var reportDetails = "<div>";
            reportDetails += "<span>Total count:</span>";
            reportDetails += recipeDetails.Count() + " ";
            reportDetails += "<span>Date:</span>";
            reportDetails += DateTime.Now;
            reportDetails += "</div>";


            string htmlstring = "<table style='font-family: arial, sans-serif;border-collapse: collapse;width: 100%;'> <tr> ";
            htmlstring += "<th style='border: 1px solid #dddddd;text-align: left;padding: 8px;'>RECIPE NAME</th>";
            htmlstring += "<th style='border: 1px solid #dddddd;text-align: left;padding: 8px;'>RECIPE PRICE</th>";
            htmlstring += "<th style='border: 1px solid #dddddd;text-align: left;padding: 8px;'>RECIPE DESCRIPTION</th>";
            htmlstring += "</tr><tbody>";

            foreach (var x in recipeDetails)
            {
                htmlstring += "<tr><td style='border: 1px solid #dddddd;text-align: left;padding: 8px;'>" + x.Name + "</td>";
                htmlstring += "<td style='border: 1px solid #dddddd;text-align: left;padding: 8px;'>" + x.Price + "</td>";
                htmlstring += "<td style='border: 1px solid #dddddd;text-align: left;padding: 8px;'>" + x.Description + "</td></tr>";
            }

            htmlstring += "</tbody></table>";

            return htmlstring + reportDetails;
        }
    }
}
