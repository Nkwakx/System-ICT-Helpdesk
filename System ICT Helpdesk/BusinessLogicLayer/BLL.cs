using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLL
    {
        DAL myDal = new DAL();
        public DataTable GetBuilding()
        {
            return myDal.GetBuilding();
        }
        public int InsertBuilding(Building myBd)
        {
            return myDal.InsertBUilding(myBd);
        }
        public DataTable GetDepart()
        {
            return myDal.GetDepartment();
        }
        public int InsertDepart(Department depart)
        {
            return myDal.InsertDepartment(depart);
        }
        public int UpdateDepart(Department depart)
        {
            return myDal.UpdateDepartment(depart);
        }
        public DataTable GetDepartmentByDepId(int dep)
        {
            return myDal.GetDepartmentByDepID(dep);
        }
        public DataTable DeleteFromDep(int dep)
        {
            return myDal.DeleteFromDepartment(dep);
        }
        public int UpdateBuilding(Building buil)
        {
            return myDal.UpdateBuilding(buil);
        }
        public DataTable DeleteFromBuilding(int build)
        {
            return myDal.DeleteFromBuilding(build);
        }
        public DataTable GetBuildingByBuildingID(int buil)
        {
            return myDal.GetBuildingByBuildingID(buil);
        }
        public int InsertStaff(Staff myStaff)
        {
            return myDal.InsertStaff(myStaff);
        }
        public DataTable GetStaff()
        {
            return myDal.GetStaff();
        }
        public DataTable GetStaffByStaffID(int staffID)
        {
            return myDal.GetStaffByStaffID(staffID);
        }
        public int UpdateStaff(Staff mySt)
        {
            return myDal.UpdateStaff(mySt);
        }
        public DataTable DeleteFromStaff(int staffID)
        {
            return myDal.DeleteFromStaff(staffID);
        }
        public int InsertFloor(Floor myF)
        {
            return myDal.InsertFloor(myF);
        }
        public DataTable GetFloor()
        {
            return myDal.GetFloor();
        }
        public DataTable GetVenue()
        {
            return myDal.GetVenue();
        }
        public int InsertVenue(Venue mYVenue)
        {
            return myDal.InsertVenue(mYVenue);
        }
        public DataTable GetTask()
        {
            return myDal.GetTask();
        }
        public int InsertTask(Tasks task)
        {
            return myDal.InsertTask(task);
        }
        public int InsertModule(Module md)
        {
            return myDal.InsertModule(md);
        }
        public DataTable GetModule()
        {
            return myDal.GetModule();
        }
        public DataTable GetCourse()
        {
            return myDal.GetCourse();
        }
        public int InsertCourse(Course myCourse)
        {
            return myDal.InsertCourse(myCourse);
        }
        public int InsertStudent(Student stud)
        {
            return myDal.InsertStudent(stud);
        }
        public int UpdateStudent(Student stud)
        {
            return myDal.UpdateStudent(stud);
        }
        public DataTable GetStudent()
        {
            return myDal.GetStudent();
        }
        public DataTable GetStudentByCourse(int courseCode)
        {
            return myDal.GetStudentByCourse(courseCode);
        }
        public DataTable GetStudentByStudentNumber(int stud)
        {
            return myDal.GetStudentByStudentNumber(stud);
        }
        public DataTable GetSearchedStudent(string studNumber)
        {
            return myDal.GetSearchedStudent(studNumber);
        }
        public DataTable DeleteFromStudent(int stud)
        {
            return myDal.DeleteFromStudent(stud);
        }
        public DataTable GetRequest()
        {
            return myDal.GetRequest();
        }
        public int InsertRequest(Request req)
        {
            return myDal.InsertRequest(req);
        }
        public int InsertTutor(Tutor tutorial)
        {
            return myDal.InsertTutor(tutorial);
        }
        public DataTable GetTutor()
        {
            return myDal.GetTutor();
        }
        public DataTable Login(string userN, string passW)
        {
            return myDal.Login(userN, passW);
        }
        public DataTable ContinueLogin(string staffNo)
        {
            return myDal.ContinueLogin(staffNo);
        }
        public DataTable GetByModule(string moduleCode)
        {
            return myDal.GetByModule(moduleCode);
        }
        public DataTable GetTutorRequestByVenue(int venue)
        {
            return myDal.GetTutorRequestByVenue(venue);
        }
        public DataTable GetEquipment()
        {
            return myDal.GetEquipment();
        }
        public int InsertEquipment(Equipment myEq)
        {
            return myDal.InsertEquipment(myEq);
        }
        public int UpdateEquipment(Equipment myEq)
        {
            return myDal.UpdateEquipment(myEq);
        }
        public DataTable GetDeleteEquipment(int eqp)
        {
            return myDal.GetDeleteEquip(eqp);
        }
        public DataTable GetEquipmentByEquipmentID(int eqp)
        {
            return myDal.GetEquipmentByEquipmentID(eqp);
        }
        public DataTable GetEquipmentByEquipDescription(string eqp)
        {
            return myDal.GetEquipmentByEquipDescription(eqp);
        }
        public DataTable GetEquipmentType()
        {
            return myDal.GetEquipmentType();
        }
        public int InsertEquipmentType(EquipmentType myEq)
        {
            return myDal.InsertEquipmentType(myEq);
        }
        public DataTable GetEquipmentHistory()
        {
            return myDal.GetEquipmentHistory();
        }
        public int InsertEquipmentHistory(EquipmentHistory myEq)
        {
            return myDal.InsertEquipmentHistory(myEq);
        }
        public int UpdateEquipmentHistory(EquipmentHistory myEq)
        {
            return myDal.UpdateEquipmentHistory(myEq);
        }
        public DataTable GetEquipmentByEquipmentHostoryID(string eqp)
        {
            return myDal.GetEquipmentByEquipmentHostoryID(eqp);
        }
        public DataTable GetInspection()
        {
            return myDal.GetInspection();
        }
        public int InsertInspection(Inspection myIN)
        {
            return myDal.InsertInspection(myIN);
        }
        public DataTable GetInspectionDetails()
        {
            return myDal.GetInspectionDetails();
        }
        public int InsertInspectionDetails(InspectionDetails myIN)
        {
            return myDal.InsertInspectionDetails(myIN);
        }
        public DataTable ValidationCheckStudent(string studNumber)
        {
            return myDal.ValidationCheckStudent(studNumber);
        }
        public DataTable ValidationCheckStaff(string staff)
        {
            return myDal.ValidationCheckStaff(staff);
        }
        public DataTable LoginDetails(string userN, string passW)
        {
            return myDal.LoginDetails(userN, passW);
        }
        public DataTable ValidationCheckCourse(string course)
        {
            return myDal.ValidationCheckCourse(course);
        }
        public DataTable ValidationCheckModule(string mod)
        {
            return myDal.ValidationCheckModule(mod);
        }
        public DataTable ValidationCheckBuilding(string building)
        {
            return myDal.ValidationCheckBuilding(building);
        }
        public DataTable ValidationCheckDepart(string dep)
        {
            return myDal.ValidationCheckDepart(dep);
        }
        public DataTable GetEquipmentByEqipName(int eqH)
        {
            return myDal.GetEquipmentByEqipName(eqH);
        }
        public DataTable GetDeleteEquip(int eqp)
        {
            return myDal.GetDeleteEquip(eqp);
        }
       
        public int UpdateInspection(Inspection inspec)
        {
            return myDal.UpdateInspection(inspec);
        }
        public int UpdateInspectionDetails(InspectionDetails inspecD)
        {
            return myDal.UpdateInspectionDetails(inspecD);
        }
        public int UpdateRequest(Request req)
        {
            return myDal.UpdateRequest(req);
        }
        public int UpdateTask(Tasks mYT)
        {
            return myDal.UpdateTask(mYT);
        }
        public int UpdateTutor(Tutor tutorial)
        {
            return myDal.UpdateTutor(tutorial);
        }
        public int UpdateVenue(Venue mYVenue)
        {
            return myDal.UpdateVenue(mYVenue);
        }
        public DataTable DeleteFromEquipmentType(int equipmentT)
        {
            return myDal.DeleteFromEquipmentType(equipmentT);
        }
        public DataTable DeleteFromInspection(int inspection)
        {
            return myDal.DeleteFromInspection(inspection);
        }
        public DataTable DeleteFromInspectionDetails(int inspectionD)
        {
            return myDal.DeleteFromInspectionDetails(inspectionD);
        }
        public DataTable DeleteFromTask(int task)
        {
            return myDal.DeleteFromTask(task);
        }
        public DataTable DeleteFromTutor(int tutor)
        {
            return myDal.DeleteFromTutor(tutor);
        }
        public DataTable DeleteFromVenue(int venue)
        {
            return myDal.DeleteFromVenue(venue);
        }
        public DataTable DeleteFromEquipmentHistory(int equipHist)
        {
            return myDal.DeleteFromEquipmentHistory(equipHist);
        }
        public DataTable DeleteFromRequest(int req)
        {
            return myDal.DeleteFromRequest(req);
        }
        public int UpdateEquipmentType(EquipmentType myEq)
        {
            return myDal.UpdateEquipmentType(myEq);
        }
        public DataTable GetEquipmentTypeByEquipmentTypeID(int eqp)
        {
            return myDal.GetEquipmentTypeByEquipmentTypeID(eqp);
        }
        public DataTable GetInspectionDetailsByInspectionDetailsID(int inspD)
        {
            return myDal.GetInspectionDetailsByInspectionDetailsID(inspD);
        }
        public DataTable GetRequestByRequestID(int Req)
        {
            return myDal.GetRequestByRequestID(Req);
        }
        public DataTable GetEquipTypeByEquipmentTypeID(int typeID)
        {
            return myDal.GetEquipTypeByEquipmentTypeID(typeID);
        }
        public DataTable GetStaffInspection()
        {
            return myDal.GetStaffInspection();
        }
        public DataTable GetInspectionByInspectionID(int inspect)
        {
            return myDal.GetInspectionByInspectionID(inspect);
        }
        public DataTable GetStaffDisabled(int staf)
        {
            return myDal.GetStaffDisabled(staf);
        }
        public DataTable GetStaffLabManager()
        {
            return myDal.GetStaffLabManager();
        }
        public DataTable GetEquipmentByDescription(string eqT)
        {
            return myDal.GetEquipmentByDescription(eqT);
        }
        public DataTable GetEquipmentByType(string eqT)
        {
            return myDal.GetEquipmentByType(eqT);
        }
        public DataTable GetEquipmentDetailsByDate(string startDate, string endDate)
        {
            return myDal.GetEquipmentDetailsByDate(startDate, endDate);
        }
        public DataTable GetRequestDetailsByDate(string startDate, string endDate)
        {
            return myDal.GetRequestDetailsByDate(startDate, endDate);
        }
        public DataTable GetEquipmentByRepairs()
        {
            return myDal.GetEquipmentByRepairs();
        }
        public DataTable GetInspectReportByDate(string startDate, string endDate)
        {
            return myDal.GetInspectReportByDate(startDate, endDate);
        }
        public DataTable GetInspectReportByVenue(string venue, string startDate, string endDate)
        {
            return myDal.GetInspectReportByVenue(venue, startDate, endDate);
        }
        public DataTable GetInspectReportByStaff(string staff, string startDate, string endDate)
        {
            return myDal.GetInspectReportByStaff(staff, startDate, endDate);
        }
        public DataTable GetRequestByTaskType(int eqT)
        {
            return myDal.GetRequestByTaskType(eqT);
        }
        public DataTable GetRequestReportByStaff(string staff, string startDate, string endDate)
        {
            return myDal.GetRequestReportByStaff(staff, startDate, endDate);
        }
        public DataTable GetRequestTutor()
        {
            return myDal.GetRequestTutor();
        }
        public DataTable GetInspDetailByInspID(int inspec)
        {
            return myDal.GetInspDetailByInspID(inspec);
        }
    }
}