﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using netcore.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace netcore.Controllers
{
    public class TeacherController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index(int id,int idteacher)
        {
            Connectdb context = HttpContext.RequestServices.GetService(typeof(netcore.Models.Connectdb)) as Connectdb;
            string strSQL;
            MySqlDataReader dtReader;
            strSQL = "SELECT * FROM savecs1 WHERE studentid = '" + User.FindFirst("id").Value + "' ";
            dtReader = context.QueryDataReader(strSQL);
            dtReader.Read();
            ViewBag.id = id;
            ViewBag.idteacher = idteacher;
            ViewBag.title = dtReader["title"].ToString();
            ViewBag.titleEng = dtReader["titleEng"].ToString();
            return View(context.GetAllTecher());

            
        }
        public IActionResult Saveidteacher(int idteacher)
        {
            Connectdb con = HttpContext.RequestServices.GetService(typeof(netcore.Models.Connectdb)) as Connectdb;
            string strSQL, strSQL2;
            strSQL = "UPDATE `student` SET idteacher = '" + idteacher + "'WHERE id =  '"+User.FindFirst("id").Value+"'";
            strSQL2 = "UPDATE `teacher` SET `Status` = Status+1 WHERE `teacher`.`Id` = '"+idteacher+"'";

            con.QueryDataSet(strSQL);
            con.QueryDataSet(strSQL2);

            return RedirectToAction("Index","Checkstatus");
        }
        
    }
}
