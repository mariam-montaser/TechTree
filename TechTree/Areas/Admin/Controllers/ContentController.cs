﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TechTree.Data;
using TechTree.Entities;

namespace TechTree.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ContentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContentController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Content
        

        // GET: Admin/Content/Create
        public IActionResult Create(int catItemId, int categoryId)
        {
            Content content = new Content
            {
                CategoryId = categoryId,
                CatItemId = catItemId,
            };
            return View(content);
        }

        // POST: Admin/Content/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,HTMLContent,VideoLink,CategoryId,CatItemId")] Content content)
        {
            if (ModelState.IsValid)
            {
                content.CategoryItem = await _context.CategoryItems.FindAsync(content.CatItemId);
                _context.Add(content);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index), "CategoryItem", new { categoryId = content.CategoryId});
            }
            return View(content);
        }

        // GET: Admin/Content/Edit/5
        public async Task<IActionResult> Edit(int catItemId, int categoryId)
        {
            if (catItemId == 0)
                return NotFound();
            var content = await _context.Contents.SingleOrDefaultAsync(item => item.CategoryItem.Id == catItemId);
            content.CategoryId = categoryId;
            if (content == null)
                return NotFound();
            return View(content);
        }

        // POST: Admin/Content/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,HTMLContent,VideoLink,CategoryId")] Content content)
        {
            if (id != content.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(content);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContentExists(content.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index), "CategoryItem", new {categoryId = content.CategoryId});
            }
            return View(content);
        }
        

        private bool ContentExists(int id)
        {
            return _context.Contents.Any(e => e.Id == id);
        }
    }
}
