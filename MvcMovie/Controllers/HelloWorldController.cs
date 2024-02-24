﻿using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    //GET: /HelloWorld/
    public IActionResult Index()
    {
        return View();
    }

    //GET: /HelloWorld/Welcome/
    public IActionResult Welcome(string name, int numTimes = 1)
    {
        ViewData["Message"] = "Hello " + name;
        ViewData["NumTimes"] = numTimes;
        return View();
    }

    /*public string Welcome(string name, int id = 1)
    {
        return HtmlEncoder.Default.Encode($"Hello {name} , ID: {id}");
    }
     * 
     * public string Welcome(string name, int numTimes = 1)
    {
        return HtmlEncoder.Default.Encode($"Hello {name} , NumTimes is {numTimes}");
    }
     * 
     * public string Welcome()
    {
        return "This is the Welcome acion method";
    }*/


}