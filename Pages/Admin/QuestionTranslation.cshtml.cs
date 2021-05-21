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
    public class QuestionTranslationModel : PageModel
    {
        private readonly Surveymatic.Data.HelpContext _context;

        public QuestionTranslationModel(Surveymatic.Data.HelpContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["QuestionId"] = new SelectList(_context.Questions, "QuestionId", "QuestionId");
            return Page();
        }

        [BindProperty]
        public QuestionTranslation QuestionTranslation { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.QuestionTranslations.Add(QuestionTranslation);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
