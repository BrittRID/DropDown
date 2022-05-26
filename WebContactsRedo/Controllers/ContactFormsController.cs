using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebContactsRedo.Data;
using WebContactsRedo.Models;


namespace WebContactsRedo.Controllers
{
    public class ContactFormsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContactFormsController(ApplicationDbContext context)
        {
            _context = context;
        }


        // GET: ContactForms
        public async Task<IActionResult> Index()
        {

            ViewBag.BrandItems = new List<SelectListItem>
            {
                new SelectListItem { Text = "Mitsubishi", Value = "1" },
                new SelectListItem { Text = "Ford", Value = "2" },
                new SelectListItem { Text = "Sony", Value = "3" },
            };

            return View(await _context.ContactForm.ToListAsync());
        }

        public async Task<IActionResult> Brands()
        {
            return View();
        }


        // GET: ContactForms/ShowSearchForm - search for name 
        public async Task<IActionResult> ShowSearchForm()
        {
            return View();
        }

        public async Task<IActionResult> ShowSearchResults(string SearchPhrase)
        {
            return View("Index", await _context.ContactForm.Where(j => j.LastName.Contains(SearchPhrase)).ToListAsync());
        }



        // GET: ContactForms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactForm = await _context.ContactForm
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contactForm == null)
            {
                return NotFound();
            }

            return View(contactForm);
        }

        // GET: ContactForms/Create
        //public async Task<IActionResult> Create()
        //{

        //    ViewBag.BrandItems = new List<SelectListItem>
        //    {
        //        new SelectListItem { Text = "Mitsubishi", Value = "1" },
        //        new SelectListItem { Text = "Ford", Value = "2" },
        //        new SelectListItem { Text = "Sony", Value = "3" },
        //    };

        //    return View(await _context.ContactForm.ToListAsync());
        //}


        public IActionResult Create()
        {
            return View();
        }

        // POST: ContactForms/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,DOB,Address,City,State,ZipCode,Brand,Sphere,Cylinder,Axis,BaseCurve,Dia,MF")] ContactForm contactForm)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contactForm);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contactForm);
        }

        // GET: ContactForms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactForm = await _context.ContactForm.FindAsync(id);
            if (contactForm == null)
            {
                return NotFound();
            }
            return View(contactForm);
        }

        // POST: ContactForms/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,DOB,Address,City,State,ZipCode,Brand,Sphere,Cylinder,Axis,BaseCurve,Dia,MF")] ContactForm contactForm)
        {
            if (id != contactForm.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contactForm);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContactFormExists(contactForm.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(contactForm);
        }

        // GET: ContactForms/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactForm = await _context.ContactForm
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contactForm == null)
            {
                return NotFound();
            }

            return View(contactForm);
        }

        // POST: ContactForms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contactForm = await _context.ContactForm.FindAsync(id);
            _context.ContactForm.Remove(contactForm);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContactFormExists(int id)
        {
            return _context.ContactForm.Any(e => e.Id == id);
        }
    }


}

