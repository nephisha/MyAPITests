using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;

namespace CI.ClinicalTrials.APITests
{
    class TrialDatesValidationTest
    {
        [Test]
        public void verify_FirstPatient_Trialdate_must_be_later_than_startdate_of_firstEnrollment()
        {
            var dateValidationRequestPayload = new List<RootObject>
            {
                new RootObject
                {
                    Activity = new Activity
                    {
                        BeginsOnDate = "26/03/2017",
                        CurrentCTUId = 53,
                        EndsOnDate = "31/10/2017",
                        SiteResponsibilityLookupItemId = 1
                    },
                    Dates = new Dates
                    {
                        AbandonedDate = "",
                        Acronym = "Rapid Pharmacovigilance",
                        CanArchive = false,
                        CanRemove = false,
                        CreatedOn = "11/07/2016",
                        ExtendedSubmissionDueDate = "",
                        FirstPatientDate = "02/09/2011",
                        FollowUpCompleteDate = "",
                        HRECApprovalDate = "",
                        LastMaintainedBy = "CTU User",
                        LastMaintainedDate = "17/01/2017",
                        Maintainers = null,
                        Participants = 10,
                        Percentage = 100,
                        PerformanceFundingPaymentStartDate = "01/01/2016",
                        RGOApprovalDate = "13/04/2011",
                        RGONotApplicable = false,
                        RGOSubmissionDate = "30/03/2011",
                        RecruitmentClosedDate = "",
                        RecruitmentOpenDate = "01/09/2011",
                        ReportPeriodEndDate = "31/10/2017",
                        SiteHRECApprovalDate = "20/03/2011",
                        SiteTarget = 10,
                        Status = null,
                        StudyClosureDate = "",
                        SuspendedDate = "",
                        TargetRecruitmentMaxRange = null,
                        TargetRecruitmentMinRange = null,
                        TargetRecruitmentTimePeriod = 1,
                        TargetRecruitmentType = 1
                    }
                    ,
                    CTUEmployees = new List<CTUEmployee2>
                    {
                        new CTUEmployee2
                        {
                            Id = 12737,
                            Name = "Test User"
                        }
                    },
                    Details = new Details
                    {
                        CTUEmployee = new CTUEmployee
                        {
                            Id = 949,
                            Name = "Mary Perry"
                        },
                        Investigator = "Caitlin Sheehan",
                        KeyContact = "Mary Perry"
                    },
                    Id = 4625,
                    IsArchived = false,
                    IsEditable = true,
                    IsIncludeCurrentPeriodData = false,
                    IsSignedOff = false,
                    SiteTargetTimePeriodLookups = new List<SiteTargetTimePeriodLookup>
                    {

                    },
                    SiteTargetTypeLookups = new List<SiteTargetTypeLookup>
                    {

                    },
                    UI = new UI
                    {

                    }
                }
            };
            var json = JsonConvert.SerializeObject(dateValidationRequestPayload);
            Console.WriteLine(json);

            var restClient = new RestClient("http://uat-clinicaltrials.cancerinstitute.org.au/");
            var restRequest = new RestRequest(Method.POST) { Resource = "MySite/EditSiteTrial/4625" };
            restRequest.AddHeader("Accept", "application/json, text/javascript, */*; q=0.01");
            restRequest.AddHeader("Content-Type", "application/json");
            restRequest.AddHeader("Cookie",
                "CurrentUserCTUId-F3E448AC-E587-4C89-86C3-9DAACC697E28=; CurrentUserCTUName-F3E448AC-E587-4C89-86C3-9DAACC697E28=; user.id=10621; user.lastlogindate=07/08/2017; user.displayname=Emmanuel Russel; .ASPXAUTH=D2214097514FEF69AF1A576B513E006300A342FCBD1F1E4A84DF02DB32104D78CBE8DEC4B3E64E53436268E166E9BB25057D2EEA4D7F8326B71185801A1A81F1B62A1AA0450E18A010F231A84AC46AF08C7B41825C7833D129ED161D5827FB931C408D7A; ASP.NET_SessionId=qjworo00n4ewu0zmnu2amgae; user.ctucount=61; user.ctuids=,2,60,64,3,42,53,51,10,49,12,13,4,67,48,38,23,22,6,21,20,61,45,52,57,63,71,7,5,58,65,66,8,28,9,54,29,72,56,14,15,16,17,36,18,24,19,27,43,47,50,26,37,30,31,44,55,62,32,33,34,35,; X-Qlik-Session-ctp-uat=qjworo00n4ewu0zmnu2amgae; __RequestVerificationToken=ErBetRPlQEJF9x3udm-ZMF2buQlLZ_EXdwrteJBuGka9_YdfexBtUC0quS2-oCGXoQYP9tLnzxue0ftcJSjNHy_Ts1M1; user.currentctuid=53; _ga=GA1.3.928026109.1502104832; _gid=GA1.3.667905507.1502104832");
            restRequest.AddParameter("application/json",json,ParameterType.RequestBody);
            var response = restClient.Execute(restRequest);
            response.StatusCode.Equals(HttpStatusCode.OK);
        }
    }
}