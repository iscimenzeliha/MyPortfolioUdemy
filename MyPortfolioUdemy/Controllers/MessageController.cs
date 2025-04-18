﻿using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.Controllers
{
	public class MessageController : Controller
	{
		MyPortfolioContext context=new MyPortfolioContext();
		public IActionResult Inbox()
		{
			var vaules=context.Messages.ToList();
			return View(vaules);
		}
		public IActionResult ChangeIsReadToTrue(int id)
		{
			var values=context.Messages.Find(id);
			values.IsRead=true;
			context.SaveChanges();
			return RedirectToAction("Inbox");
		}
		public IActionResult ChangeIsReadToFalse(int id)
		{
			var values=context.Messages.Find(id);
			values.IsRead=false;
			context.SaveChanges();
			return RedirectToAction("Inbox");
		}
		public IActionResult DeleteMessage(int id)
		{
			var values = context.Messages.Find(id);
			context.Messages.Remove(values);
			context.SaveChanges();
			return RedirectToAction("Inbox");
		}
		public IActionResult MessageDetails(int id)
		{
			var values = context.Messages.Find(id);
			return View(values);
		}
	}
}
