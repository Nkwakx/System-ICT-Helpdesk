using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class DAL
    {
        SqlConnection dbConn = new SqlConnection("Data Source=localhost;Initial Catalog=HelpDeskSystemDB;Integrated Security=True");
        SqlCommand dbComm;
        SqlDataAdapter dbAd;
        DataTable dt;

        public DataTable GetBuilding()
        {
            try
            {

            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetBuilding", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public int InsertBUilding(Building myB)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            dbComm = new SqlCommand("sp_InsertBuilding", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@BuildingName", myB.BuildingName);
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();
            return x;
        }
        public DataTable GetDepartment()
        {
            try
            {

            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetDepartment", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public int InsertDepartment(Department department)
        {
            try
            {

            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_InsertDepartment", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@DepName", department.DepName);
            dbComm.Parameters.AddWithValue("@BuildingID", department.BuildingID);
            dbComm.Parameters.AddWithValue("@DepContactNumber", department.DepContactNumber);
            dbComm.Parameters.AddWithValue("@DepEmailAddress", department.DepEmailAddress);
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();
            return x;
        }
        public int UpdateDepartment(Department depart)
        {
            try
            {

            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_UpdateDepartmentDetails", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@DepartmentID", depart.DepartmentID);
            dbComm.Parameters.AddWithValue("@DepName", depart.DepName);
            dbComm.Parameters.AddWithValue("@BuildingID", depart.BuildingID);
            dbComm.Parameters.AddWithValue("@DepContactNumber", depart.DepContactNumber);
            dbComm.Parameters.AddWithValue("@DepEmailAddress", depart.DepEmailAddress);
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();
            return x;
        }
        public DataTable GetDepartmentByDepID(int dep)
        {
            try
            {

            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetDepartmentByDepartmentID", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@DepartmentID", dep);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public DataTable DeleteFromDepartment(int dep)
        {
            try
            {

            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_DeleteFromDepartment", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@DepartmentID", dep);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public DataTable DeleteFromBuilding(int build)
        {
            try
            {

            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_DeleteFromBuilding", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@BuildingID", build);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public int UpdateBuilding(Building buil)
        {
            try
            {

            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_UpdateBuilding", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@BuildingID", buil.BuildingID);
            dbComm.Parameters.AddWithValue("@BuildingName", buil.BuildingName);
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();
            return x;
        }
        public DataTable GetBuildingByBuildingID(int buil)
        {
            try
            {

            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetBuildingByBuildingID", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@BuildingID", buil);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public int InsertStaff(Staff myStaff)
        {
            try
            {

            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_InsertStaff", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@StaffNumber", myStaff.StaffNumber);
            dbComm.Parameters.AddWithValue("@FirstName", myStaff.FirstName);
            dbComm.Parameters.AddWithValue("@LastName", myStaff.LastName);
            dbComm.Parameters.AddWithValue("@UserName", myStaff.UserName);
            dbComm.Parameters.AddWithValue("@IDNumber", myStaff.IDNumber);
            dbComm.Parameters.AddWithValue("@Password", myStaff.Password);
            dbComm.Parameters.AddWithValue("@EmailAddress", myStaff.EmailAddress);
            dbComm.Parameters.AddWithValue("@ContactNo", myStaff.ContactNo);
            dbComm.Parameters.AddWithValue("@StaffType", myStaff.StaffType);
            dbComm.Parameters.AddWithValue("@Active", myStaff.Active);

            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();
            return x;
        }
        public DataTable GetStaff()
        {
            dbComm = new SqlCommand("sp_GetStaff", dbConn);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public DataTable GetStaffByStaffID(int staffID)
        {
            dbComm = new SqlCommand("sp_GetStaffByStaffID", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@StaffID", staffID);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public int UpdateStaff(Staff mySt)
        {
            try
            {

            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_UpdateStaff", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@StaffID", mySt.StaffID);
            dbComm.Parameters.AddWithValue("@StaffNumber", mySt.StaffNumber);
            dbComm.Parameters.AddWithValue("@FirstName", mySt.FirstName);
            dbComm.Parameters.AddWithValue("@LastName", mySt.LastName);
            dbComm.Parameters.AddWithValue("@UserName", mySt.UserName);
            dbComm.Parameters.AddWithValue("@IDNumber", mySt.IDNumber);
            dbComm.Parameters.AddWithValue("@Password", mySt.Password);
            dbComm.Parameters.AddWithValue("@EmailAddress", mySt.EmailAddress);
            dbComm.Parameters.AddWithValue("@ContactNo", mySt.ContactNo);
            dbComm.Parameters.AddWithValue("@StaffType", mySt.StaffType);
            dbComm.Parameters.AddWithValue("@Active", mySt.Active);

            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();
            return x;
        }
        public DataTable DeleteFromStaff(int staffID)
        {
            dbComm = new SqlCommand("sp_DeleteFromStaff", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@StaffID", staffID);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public int InsertFloor(Floor myFloor)
        {
            try
            {

            }
            catch
            {

            }
            string query1 = "sp_InsertFloor";
            dbComm = new SqlCommand(query1, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@FloorName", myFloor.FloorName);
            dbComm.Parameters.AddWithValue("@BuildingID", myFloor.BuildingID);
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }

            int x = dbComm.ExecuteNonQuery();
            return x;
        }
        public DataTable GetFloor()
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            string query1 = "sp_GetFloor";
            dbComm = new SqlCommand(query1, dbConn);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public int InsertVenue(Venue mYVenue)
        {
            try
            {

            }
            catch
            {

            }
            string query1 = "sp_InsertVenue";
            dbComm = new SqlCommand(query1, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@VenueCode", mYVenue.VenueCode);
            dbComm.Parameters.AddWithValue("@VenueCapacity", mYVenue.VenueCapacity);
            dbComm.Parameters.AddWithValue("@FloorID", mYVenue.FloorID);
            dbComm.Parameters.AddWithValue("@BuildingID", mYVenue.BuildingID);
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }

            int x = dbComm.ExecuteNonQuery();
            return x;
        }
        public DataTable GetVenue()
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            string query1 = "sp_GetVenue";
            dbComm = new SqlCommand(query1, dbConn);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public int InsertTask(Tasks mYT)
        {
            dbComm = new SqlCommand("sp_InsertTask", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@TaskDescription", mYT.TaskDescription);
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();
            return x;
        }
        public DataTable GetTask()
        {
            dbComm = new SqlCommand("sp_GetTask", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public DataTable GetModule()
        {
            dbComm = new SqlCommand("sp_GetModule", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public int InsertModule(Module modules)
        {
            try
            {

            }
            catch
            {

            }
            string query1 = "sp_InsertModule";
            dbComm = new SqlCommand(query1, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@ModuleCode", modules.ModuleCode);
            dbComm.Parameters.AddWithValue("@ModuleDescription", modules.ModuleDescription);
            dbComm.Parameters.AddWithValue("@CourseCode", modules.CourseCode);
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();
            return x;
        }
        public DataTable GetCourse()
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            string query1 = "sp_GetCourse";
            dbComm = new SqlCommand(query1, dbConn);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public int InsertCourse(Course myCourse)
        {
            dbComm = new SqlCommand("sp_InsertCourse", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@CourseDescription", myCourse.CourseDescription);
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();
            return x;
        }
        public int InsertStudent(Student stud)
        {
            dbComm = new SqlCommand("sp_InsertStudent", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@StudentNumber", stud.StudentNumber);
            dbComm.Parameters.AddWithValue("@StudentName", stud.StudentName);
            dbComm.Parameters.AddWithValue("@StudentSurname", stud.StudentSurname);
            dbComm.Parameters.AddWithValue("@IDNumber", stud.IDNumber);
            dbComm.Parameters.AddWithValue("@StudentEmailAddress", stud.StudentEmailAddress);
            dbComm.Parameters.AddWithValue("@StudentContactNo", stud.StudentContactNo);
            dbComm.Parameters.AddWithValue("@CourseCode", stud.CourseCode);
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();

            return x;
        }
        public int UpdateStudent(Student stud)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_UpdateStudentDetails", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@StudentNumber", stud.StudentNumber);
            dbComm.Parameters.AddWithValue("@StudentName", stud.StudentName);
            dbComm.Parameters.AddWithValue("@StudentSurname", stud.StudentSurname);
            dbComm.Parameters.AddWithValue("@IDNumber", stud.IDNumber);
            dbComm.Parameters.AddWithValue("@StudentEmailAddress", stud.StudentEmailAddress);
            dbComm.Parameters.AddWithValue("@StudentContactNo", stud.StudentContactNo);
            dbComm.Parameters.AddWithValue("@CourseCode", stud.CourseCode);
            dbComm.Parameters.AddWithValue("@StudentID", stud.StudentID);

            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetStudent()
        {
            dbComm = new SqlCommand("sp_GetStudent", dbConn);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public DataTable GetStudentByCourse(int courseCode)
        {
            dbComm = new SqlCommand("sp_GetStudentByCourse", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@CourseCode", courseCode);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public DataTable GetStudentByStudentNumber(int stud)
        {
            dbComm = new SqlCommand("sp_GetStudentByStundentNumber", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@StudentID", stud);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public DataTable GetSearchedStudent(string studNumber)
        {
            dbComm = new SqlCommand("sp_GetStudentBySearch", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@StudentNumber", studNumber);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public DataTable DeleteFromStudent(int stud)
        {
            try
            {

            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_DeleteFromStudent", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@StudentID", stud);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public DataTable GetRequest()
        {
            dbComm = new SqlCommand("sp_GetRequest", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public int InsertRequest(Request req)
        {
            dbComm = new SqlCommand("sp_InsertRequest", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@RequestDescription", req.RequestDescription);
            dbComm.Parameters.AddWithValue("@StaffID", req.StaffID);
            dbComm.Parameters.AddWithValue("@StudentID", req.StudentID);
            dbComm.Parameters.AddWithValue("@TaskID", req.TaskID);
            dbComm.Parameters.AddWithValue("@Date", req.Date);
            dbComm.Parameters.AddWithValue("@Time", req.Time);
            dbComm.Parameters.AddWithValue("@RequestStatus", req.RequestStatus);
            dbComm.Parameters.AddWithValue("@StaffAssigned", req.StaffAssigned);
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();

            return x;
        }
        public DataTable GetTutor()
        {
            dbComm = new SqlCommand("sp_GetTutor", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public int InsertTutor(Tutor tutorial)
        {
            dbComm = new SqlCommand("sp_InsertTutor", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@RequestID", tutorial.RequestID);
            dbComm.Parameters.AddWithValue("@ModuleID", tutorial.ModuleID);
            dbComm.Parameters.AddWithValue("@VenueID", tutorial.VenueID);
            dbComm.Parameters.AddWithValue("@TutorDate", tutorial.TutorDate);
            dbComm.Parameters.AddWithValue("@StartTime", tutorial.StartTime);
            dbComm.Parameters.AddWithValue("@EndTime", tutorial.EndTime);
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();

            return x;
        }
        public DataTable Login(string userN, string IDNo)
        {
            dbComm = new SqlCommand("sp__GetUserLogin", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@UserName", userN);
            dbComm.Parameters.AddWithValue("@IDNumber", IDNo);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public DataTable ContinueLogin(string staffNo)
        {
            dbComm = new SqlCommand("sp__ContinueLogin", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@StaffNumber", staffNo);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
       
        public DataTable GetByModule(string moduleCode)
        {
            dbComm = new SqlCommand("sp_GetModuleByModuleCode ", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@ModuleCode", moduleCode);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;

        }
        public DataTable GetTutorRequestByVenue(int v)
        {
            dbComm = new SqlCommand("sp_GetTutorRequestByVenue ", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@VenueID", v);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public DataTable GetEquipment()
        {
            dbComm = new SqlCommand("sp_GetEquipment", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public int InsertEquipment(Equipment myEq)
        {
            dbComm = new SqlCommand("sp_InsertEquipment", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Barcode", myEq.Barcode);
            dbComm.Parameters.AddWithValue("@EquipmentDescription", myEq.EquipmentDescription);
            dbComm.Parameters.AddWithValue("@DateRecieved", myEq.DateRecieved);
            dbComm.Parameters.AddWithValue("@EquipmentTypeID", myEq.EquipmentTypeID);
            dbComm.Parameters.AddWithValue("@VenueID", myEq.VenueID);
            dbComm.Parameters.AddWithValue("@EquipmentStatus", myEq.EquipmentStatus);
            dbComm.Parameters.AddWithValue("@YearsValid", myEq.YearsValid);
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();
            return x;
        }
        public int UpdateEquipment(Equipment myEq)
        {
            dbComm = new SqlCommand("sp_UpdateEquipment", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@EquipmentID", myEq.EquipmentID);
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();
            return x;
        }
        public DataTable GetDeleteEquip(int eqp)
        {
            dbComm = new SqlCommand("sp_HardDeleteEquipment", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@EquipmentID", eqp);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public DataTable GetEquipmentByEquipmentID(int eqp)
        {
            dbComm = new SqlCommand("sp_GetEquipmentByEquipmentID", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@EquipmentID", eqp);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public DataTable GetEquipmentByEquipDescription(string eqp)
        {
            dbComm = new SqlCommand("sp_GetEquipmentByEquipDescription ", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@EquipmentDescription", eqp);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public DataTable GetEquipmentType()
        {
            dbComm = new SqlCommand("sp_GetEquipmentType", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public int InsertEquipmentType(EquipmentType myEq)
        {
            try
            {

            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_InsertEquipmentType", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@EquipmentTypeName", myEq.EquipmentTypeName);
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();
            return x;
        }
        public DataTable GetEquipmentHistory()
        {
            dbComm = new SqlCommand("sp_GetEquipmentHistory", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public int InsertEquipmentHistory(EquipmentHistory myEq)
        {
            try
            {

            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_InsertEquipmentHistory", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@EquipHistoryDate", myEq.EquipHistoryDate);
            dbComm.Parameters.AddWithValue("@HistoryDescription", myEq.HistoryDescription);
            dbComm.Parameters.AddWithValue("@EquipmentID", myEq.EquipmentID);
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();
            return x;
        }
        public int UpdateEquipmentHistory(EquipmentHistory myEq)
        {
            try
            {

            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_UpdateEquipmentHistory", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@EquipmentHistoryID", myEq.EquipmentHistoryID);
            dbComm.Parameters.AddWithValue("@EquipHistoryDate", myEq.EquipHistoryDate);
            dbComm.Parameters.AddWithValue("@HistoryDiscription", myEq.HistoryDescription);
            dbComm.Parameters.AddWithValue("@EquipmentID", myEq.EquipmentID);
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();
            return x;
        }
        public DataTable GetEquipmentByEquipmentHostoryID(string eqp)
        {
            dbComm = new SqlCommand("sp_GetEquipmentByEquipmentHostoryID", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@EquipmentHistoryID", eqp);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public DataTable GetInspection()
        {
            dbComm = new SqlCommand("sp_GetInspection", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public int InsertInspection(Inspection myIN)
        {
            try
            {

            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_InsertInspection", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@VenueID", myIN.VenueID);
            dbComm.Parameters.AddWithValue("@StaffID", myIN.StaffID);
            dbComm.Parameters.AddWithValue("@InspectionDate", myIN.InspectionDate);
            dbComm.Parameters.AddWithValue("@StartTime", myIN.StartTime);
            dbComm.Parameters.AddWithValue("@EndTime", myIN.EndTime);
            dbComm.Parameters.AddWithValue("@Comment", myIN.Comment);
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();
            return x;
        }
        public DataTable GetInspectionDetails()
        {
            dbComm = new SqlCommand("sp_GetInspectionDetails", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public int InsertInspectionDetails(InspectionDetails myIN)
        {
            try
            {

            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_InsertInspectionDetails", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@InspectionID", myIN.InspectionID);
            dbComm.Parameters.AddWithValue("@EquipmentID", myIN.EquipmentID);
            dbComm.Parameters.AddWithValue("@StaffID", myIN.StaffID);
            dbComm.Parameters.AddWithValue("@InspecDate", myIN.InspecDate);
            dbComm.Parameters.AddWithValue("@FaultComment", myIN.FaultComment);
            dbComm.Parameters.AddWithValue("@Status", myIN.Status);
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();
            return x;
        }
        public DataTable ValidationCheckStudent(string studNumber)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            dbComm = new SqlCommand("sp_GetValidationCheckStudent", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@StudentNumber", studNumber);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            dt.Load(dbComm.ExecuteReader());
            return dt;
        }
        public DataTable ValidationCheckStaff(string staff)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            dbComm = new SqlCommand("sp_GetValidationCheckStaffNumber", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@StaffNumber", staff);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            dt.Load(dbComm.ExecuteReader());
            return dt;
        }
        public DataTable LoginDetails(string userN, string passW)
        {
            dbComm = new SqlCommand("sp__GetUserDetails", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@UserName", userN);
            dbComm.Parameters.AddWithValue("@Password", passW);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public DataTable ValidationCheckCourse(string course)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            dbComm = new SqlCommand("sp_GetValidationCheckCourse", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@CourseDescription", course);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            dt.Load(dbComm.ExecuteReader());
            return dt;
        }
        public DataTable ValidationCheckModule(string mod)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            dbComm = new SqlCommand("sp_GetValidationCheckModule", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@ModuleCode", mod);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            dt.Load(dbComm.ExecuteReader());
            return dt;
        }
        public DataTable ValidationCheckBuilding(string building)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            dbComm = new SqlCommand("sp_GetValidationCheckBuilding", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@BuildingName", building);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            dt.Load(dbComm.ExecuteReader());
            return dt;
        }
        public DataTable ValidationCheckDepart(string dep)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            dbComm = new SqlCommand("sp_GetValidationCheckDepartment", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@DepName", dep);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            dt.Load(dbComm.ExecuteReader());
            return dt;
        }
        public DataTable GetEquipmentByEqipName(int eqH)
        {
            dbComm = new SqlCommand("sp_GetEquipHistoryByEquipmentDescription", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@EquipmentID", eqH);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
       
        public int UpdateEquipmentType(EquipmentType myEq)
        {
            try
            {

            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_UpdateEquipmentType", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@EquipmentTypeID", myEq.EquipmentTypeID);
            dbComm.Parameters.AddWithValue("@EquipmentTypeName", myEq.EquipmentTypeName);
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();
            return x;
        }
        public int UpdateInspection(Inspection inspec)
        {
            try
            {

            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_UpdateInspection", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@InspectionID", inspec.InspectionID);
            dbComm.Parameters.AddWithValue("@VenueID", inspec.VenueID);
            dbComm.Parameters.AddWithValue("@StaffID", inspec.StaffID);
            dbComm.Parameters.AddWithValue("@InspectionDate", inspec.InspectionDate);
            dbComm.Parameters.AddWithValue("@StartTime", inspec.StartTime);
            dbComm.Parameters.AddWithValue("@EndTime", inspec.EndTime);
            dbComm.Parameters.AddWithValue("@Comment", inspec.Comment);
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();
            return x;
        }
        public int UpdateInspectionDetails(InspectionDetails inspecD)
        {
            try
            {

            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_UpdateInspectionDetails", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@InspectionDetailsID", inspecD.InspectionDetailsID);
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();
            return x;
        }
        public int UpdateRequest(Request req)
        {
            dbComm = new SqlCommand("sp_UpdateRequest", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@RequestID", req.RequestID);
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();

            return x;
        }
        public int UpdateTask(Tasks mYT)
        {
            dbComm = new SqlCommand("sp_UpdateTask", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@TaskID", mYT.TaskID);
            dbComm.Parameters.AddWithValue("@TaskDescription", mYT.TaskDescription);
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();
            return x;
        }
        public int UpdateTutor(Tutor tutorial)
        {
            dbComm = new SqlCommand("sp_UpdateTutor", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@TutorID", tutorial.TutorID);
            dbComm.Parameters.AddWithValue("@ModuleID", tutorial.ModuleID);
            dbComm.Parameters.AddWithValue("@VenueID", tutorial.VenueID);
            dbComm.Parameters.AddWithValue("@TutorDate", tutorial.TutorDate);
            dbComm.Parameters.AddWithValue("@StartTime", tutorial.StartTime);
            dbComm.Parameters.AddWithValue("@EndTime", tutorial.EndTime);
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbComm.ExecuteNonQuery();

            return x;
        }
        public int UpdateVenue(Venue mYVenue)
        {
            try
            {

            }
            catch
            {

            }
            string query1 = "sp_UpdateVenue";
            dbComm = new SqlCommand(query1, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@VenueID", mYVenue.VenueID);
            dbComm.Parameters.AddWithValue("@VenueCode", mYVenue.VenueCode);
            dbComm.Parameters.AddWithValue("@VenueCapacity", mYVenue.VenueCapacity);
            dbComm.Parameters.AddWithValue("@FloorID", mYVenue.FloorID);
            dbComm.Parameters.AddWithValue("@BuildingID", mYVenue.BuildingID);
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }

            int x = dbComm.ExecuteNonQuery();
            return x;
        }
        public DataTable DeleteFromEquipmentType(int equipmentT)
        {
            try
            {

            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_HardDeleteEquipmentType", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@EquipmentTypeID", equipmentT);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public DataTable DeleteFromInspection(int inspection)
        {
          
            dbComm = new SqlCommand("sp_HardDeleteInspection", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@InspectionID", inspection);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public DataTable DeleteFromInspectionDetails(int inspectionD)
        {
            
            dbComm = new SqlCommand("sp_HardDeleteInspectionDetails", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@InspectionDetailsID", inspectionD);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public DataTable DeleteFromTask(int task)
        {
           
            dbComm = new SqlCommand("sp_HardDeleteTask", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@TaskID", task);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public DataTable DeleteFromTutor(int tutor)
        {
            
            dbComm = new SqlCommand("sp_HardDeleteTutor", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@TutorID", tutor);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public DataTable DeleteFromVenue(int venueID)
        {
            dbComm = new SqlCommand("sp_HardDeleteVenue", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@VenueID", venueID);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public DataTable DeleteFromEquipmentHistory(int inspection)
        {
            
            dbComm = new SqlCommand("sp_HardDeleteEquipmentHistory", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@EquipmentHistoryID", inspection);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public DataTable DeleteFromRequest(int req)
        {
           
            dbComm = new SqlCommand("sp_HardDeleteRequest", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@RequestID", req);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public DataTable GetEquipmentTypeByEquipmentTypeID(int eqp)
        {
            dbComm = new SqlCommand("sp_GetEquipTypeByEquipmentTypeID", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@EquipmentTypeID", eqp);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public DataTable GetInspectionDetailsByInspectionDetailsID(int inspD)
        {
            dbComm = new SqlCommand("sp_GetInspectionDetailsBYInspID", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@InspectionDetailsID", inspD);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public DataTable GetRequestByRequestID(int Req)
        {
            dbComm = new SqlCommand("sp_GetRequestByRequestID", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@RequestID", Req);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public DataTable GetEquipTypeByEquipmentTypeID(int typeID)
        {
            dbComm = new SqlCommand("sp_GetEquipTypeByEquipmentTypeID", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@EquipmentTypeID", typeID);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public DataTable GetStaffInspection()
        {
            dbComm = new SqlCommand("sp_GetStaffInspection", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public DataTable GetInspectionByInspectionID(int inspect)
        {
            dbComm = new SqlCommand("sp_GetInspectionByInspectionID", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@InspectionID", inspect);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public DataTable GetStaffDisabled(int staf)
        {
            dbComm = new SqlCommand("sp_SoftDeleteStaff", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@StaffID", staf);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public DataTable GetStaffLabManager()
        {
            dbComm = new SqlCommand("sp_GetStaffManagers", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public DataTable GetEquipmentByDescription(string eqT)
        {
            dbComm = new SqlCommand("sp_GetEquipmentByDescription", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@HistoryDescription", eqT);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public DataTable GetEquipmentByType(string eqT)
        {
            dbComm = new SqlCommand("sp_GetEquipmentByType", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@EquipmentTypeName", eqT);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public DataTable GetEquipmentDetailsByDate(string startDate, string endDate)
        {
            dbComm = new SqlCommand("sp_GetEquipmentDetailsByDate", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@StartDate", startDate);
            dbComm.Parameters.AddWithValue("@EndDate", endDate);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public DataTable GetRequestDetailsByDate(string startDate, string endDate)
        {
            dbComm = new SqlCommand("sp_GetRequestByDate", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@StartDate", startDate);
            dbComm.Parameters.AddWithValue("@EndDate", endDate);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public DataTable GetEquipmentByRepairs()
        {
            dbComm = new SqlCommand("sp_GetEquipmentByRepairDescription", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public DataTable GetInspectReportByDate(string startDate, string endDate)
        {
            dbComm = new SqlCommand("sp_GetInspectionReportByDATES", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@StartDate", startDate);
            dbComm.Parameters.AddWithValue("@EndDate", endDate);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public DataTable GetInspectReportByVenue(string venue, string startDate, string endDate)
        {
            dbComm = new SqlCommand("sp_InspectionReportByLabANDDate", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@StartDate", startDate);
            dbComm.Parameters.AddWithValue("@EndDate", endDate);
            dbComm.Parameters.AddWithValue("@VenueCode", venue);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public DataTable GetInspectReportByStaff(string staff, string startDate, string endDate)
        {
            dbComm = new SqlCommand("sp_InspectionReportByStaffANDDate", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@StartDate", startDate);
            dbComm.Parameters.AddWithValue("@EndDate", endDate);
            dbComm.Parameters.AddWithValue("@FirstName", staff);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public DataTable GetRequestByTaskType(int eqT)
        {
            dbComm = new SqlCommand("sp_GetRequestReportByTaskType", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@TaskID", eqT);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public DataTable GetRequestReportByStaff(string staff, string startDate, string endDate)
        {
            dbComm = new SqlCommand("sp_GetRequestByStaff", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@StartDate", startDate);
            dbComm.Parameters.AddWithValue("@EndDate", endDate);
            dbComm.Parameters.AddWithValue("@StaffAssigned", staff);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public DataTable GetRequestTutor()
        {
            dbComm = new SqlCommand("sp_GetTutorRequest", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
        public DataTable GetInspDetailByInspID(int inspec)
        {
            dbComm = new SqlCommand("sp_GetInspDetailByInspID", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@InspectionID", inspec);
            dbAd = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAd.Fill(dt);
            return dt;
        }
    }
}