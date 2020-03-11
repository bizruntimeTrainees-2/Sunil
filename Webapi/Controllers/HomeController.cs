
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("~/api/StoreData")]
        [HttpPost]
        public IActionResult StoreData([FromBody]StudentDetails student)
        {
            StudentDataToDB studentDataTo = new StudentDataToDB();

            try
            {
                if (ModelState.IsValid)
                {
                    string resp = studentDataTo.AddStudentData(student);
                    TempData["msg"] = resp;

                }
            }
            catch (Exception ex)
            {
                TempData["msg"] = ex.Message;
            }
            return View();
        }
        [Route("~/api/GetData")]
        [HttpGet]
        public JsonResult GetData()
        {
            GetDataFromDataBase getData = new GetDataFromDataBase();
            DataSet dataSet = getData.ShowData();
            List<StudentDetails> studentDetails = new List<StudentDetails>();
            foreach (DataRow dataRow in dataSet.Tables[0].Rows)
            {
                studentDetails.Add(new StudentDetails
                {
                    Id = Convert.ToInt32(dataRow["Id"]),
                    Name = dataRow["Name"].ToString(),
                    Email = dataRow["Email"].ToString(),
                    MobileNumber = dataRow["MobileNumber"].ToString(),
                    CollegeName = dataRow["CollegeName"].ToString(),
                    Stream = dataRow["Stream"].ToString()
                });
            }
            return Json(studentDetails);
        }
        [Route("~/api/GetDataByStudentId")]
        [HttpGet]
        public JsonResult GetDataByStudentId(int studentId)
        {
            GetEditableData getEditableData = new GetEditableData();
            DataSet dataSet = getEditableData.GetDataById(studentId);
            List<StudentDetails> studentDetails = new List<StudentDetails>();
            foreach (DataRow dataRow in dataSet.Tables[0].Rows)
            {
                studentDetails.Add(new StudentDetails
                {
                    Id = Convert.ToInt32(dataRow["Id"]),
                    Name = dataRow["Name"].ToString(),
                    Email = dataRow["Email"].ToString(),
                    MobileNumber = dataRow["MobileNumber"].ToString(),
                    CollegeName = dataRow["CollegeName"].ToString(),
                    Stream = dataRow["Stream"].ToString()
                });
            }
            return Json(studentDetails);
        }
        [Route("~/api/UpdateStudentRecords")]
        [HttpPatch]
        public string UpdateStudentRecords([FromBody]StudentDetails StudentData)
        {
            UpdateStudentData updateStudentData = new UpdateStudentData();
            updateStudentData.UpdateRecord(StudentData.Id, StudentData);
            return ("Updated Successfully");
        }
        [Route("~/api/DeleteData")]
        [HttpDelete]
        public IActionResult DeleteData(int studentId)
        {
            DeleteStudentData deleteData = new DeleteStudentData();            
            deleteData.Delete(studentId);
            return View();
        }
    }
}
