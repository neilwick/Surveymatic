using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Surveymatic.Data;
using Surveymatic.Model;

namespace Surveymatic.Pages.Admin
{
    public class QuestionModel : PageModel
    {
        private readonly Surveymatic.Data.HelpContext _context;

        public QuestionModel(Surveymatic.Data.HelpContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["SurveyId"] = new SelectList(_context.Surveys, "SurveyId", "SurveyId");
            return Page();
        }

        [BindProperty]
        public Question Question { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Questions.Add(Question);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
