﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace ReleaseManagementAssignment
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

using System.Data.Entity.Core.Objects;
using System.Linq;


public partial class releasedbEntities1 : DbContext
{
    public releasedbEntities1()
        : base("name=releasedbEntities1")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<EmployeeList> EmployeeLists { get; set; }

    public virtual DbSet<EmpTeam> EmpTeams { get; set; }

    public virtual DbSet<Team> Teams { get; set; }

    public virtual DbSet<Project1> Project1 { get; set; }

    public virtual DbSet<ProjectList> ProjectLists { get; set; }

    public virtual DbSet<AddEmployee> AddEmployees { get; set; }

    public virtual DbSet<developer> developers { get; set; }

    public virtual DbSet<Module> Modules { get; set; }

    public virtual DbSet<tester> testers { get; set; }

    public virtual DbSet<module1> module1 { get; set; }


    public virtual ObjectResult<proc_CheckLogin_Result> proc_CheckLogin(Nullable<int> un, string pass)
    {

        var unParameter = un.HasValue ?
            new ObjectParameter("un", un) :
            new ObjectParameter("un", typeof(int));


        var passParameter = pass != null ?
            new ObjectParameter("pass", pass) :
            new ObjectParameter("pass", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<proc_CheckLogin_Result>("proc_CheckLogin", unParameter, passParameter);
    }


    public virtual int S_InsertIntoProject_p(Nullable<int> id, string name, Nullable<System.DateTime> actualstartdate, Nullable<System.DateTime> actualenddate, Nullable<System.DateTime> expectstartdate, Nullable<System.DateTime> expectenddate)
    {

        var idParameter = id.HasValue ?
            new ObjectParameter("id", id) :
            new ObjectParameter("id", typeof(int));


        var nameParameter = name != null ?
            new ObjectParameter("name", name) :
            new ObjectParameter("name", typeof(string));


        var actualstartdateParameter = actualstartdate.HasValue ?
            new ObjectParameter("actualstartdate", actualstartdate) :
            new ObjectParameter("actualstartdate", typeof(System.DateTime));


        var actualenddateParameter = actualenddate.HasValue ?
            new ObjectParameter("actualenddate", actualenddate) :
            new ObjectParameter("actualenddate", typeof(System.DateTime));


        var expectstartdateParameter = expectstartdate.HasValue ?
            new ObjectParameter("expectstartdate", expectstartdate) :
            new ObjectParameter("expectstartdate", typeof(System.DateTime));


        var expectenddateParameter = expectenddate.HasValue ?
            new ObjectParameter("expectenddate", expectenddate) :
            new ObjectParameter("expectenddate", typeof(System.DateTime));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("S_InsertIntoProject_p", idParameter, nameParameter, actualstartdateParameter, actualenddateParameter, expectstartdateParameter, expectenddateParameter);
    }


    public virtual int S_AddTeamLeadtoProject_p(Nullable<int> pid, string pname, Nullable<int> leadid)
    {

        var pidParameter = pid.HasValue ?
            new ObjectParameter("Pid", pid) :
            new ObjectParameter("Pid", typeof(int));


        var pnameParameter = pname != null ?
            new ObjectParameter("Pname", pname) :
            new ObjectParameter("Pname", typeof(string));


        var leadidParameter = leadid.HasValue ?
            new ObjectParameter("leadid", leadid) :
            new ObjectParameter("leadid", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("S_AddTeamLeadtoProject_p", pidParameter, pnameParameter, leadidParameter);
    }


    public virtual int S_AddEmployee_p(Nullable<int> eid, string ename, string erole)
    {

        var eidParameter = eid.HasValue ?
            new ObjectParameter("Eid", eid) :
            new ObjectParameter("Eid", typeof(int));


        var enameParameter = ename != null ?
            new ObjectParameter("Ename", ename) :
            new ObjectParameter("Ename", typeof(string));


        var eroleParameter = erole != null ?
            new ObjectParameter("Erole", erole) :
            new ObjectParameter("Erole", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("S_AddEmployee_p", eidParameter, enameParameter, eroleParameter);
    }


    public virtual int S_InsertIntoModule_P(Nullable<int> mid, Nullable<System.DateTime> exStDate, Nullable<System.DateTime> exEdDate, Nullable<System.DateTime> acStDate, Nullable<System.DateTime> acEdDate, Nullable<int> pid)
    {

        var midParameter = mid.HasValue ?
            new ObjectParameter("mid", mid) :
            new ObjectParameter("mid", typeof(int));


        var exStDateParameter = exStDate.HasValue ?
            new ObjectParameter("ExStDate", exStDate) :
            new ObjectParameter("ExStDate", typeof(System.DateTime));


        var exEdDateParameter = exEdDate.HasValue ?
            new ObjectParameter("ExEdDate", exEdDate) :
            new ObjectParameter("ExEdDate", typeof(System.DateTime));


        var acStDateParameter = acStDate.HasValue ?
            new ObjectParameter("AcStDate", acStDate) :
            new ObjectParameter("AcStDate", typeof(System.DateTime));


        var acEdDateParameter = acEdDate.HasValue ?
            new ObjectParameter("acEdDate", acEdDate) :
            new ObjectParameter("acEdDate", typeof(System.DateTime));


        var pidParameter = pid.HasValue ?
            new ObjectParameter("pid", pid) :
            new ObjectParameter("pid", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("S_InsertIntoModule_P", midParameter, exStDateParameter, exEdDateParameter, acStDateParameter, acEdDateParameter, pidParameter);
    }


    public virtual int I_AssignModuleToDeveloper_P(string empname, Nullable<int> modid)
    {

        var empnameParameter = empname != null ?
            new ObjectParameter("Empname", empname) :
            new ObjectParameter("Empname", typeof(string));


        var modidParameter = modid.HasValue ?
            new ObjectParameter("modid", modid) :
            new ObjectParameter("modid", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("I_AssignModuleToDeveloper_P", empnameParameter, modidParameter);
    }


    public virtual int I_AssignModuleToTester_P(string empname, Nullable<int> modid)
    {

        var empnameParameter = empname != null ?
            new ObjectParameter("Empname", empname) :
            new ObjectParameter("Empname", typeof(string));


        var modidParameter = modid.HasValue ?
            new ObjectParameter("modid", modid) :
            new ObjectParameter("modid", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("I_AssignModuleToTester_P", empnameParameter, modidParameter);
    }

}

}

